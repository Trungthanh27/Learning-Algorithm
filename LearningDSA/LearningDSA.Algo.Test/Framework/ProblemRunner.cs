using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace LearningDSA.Algo.Test.Framework;

/// <summary>
/// Runs one test case: finds the solution method, converts the JSON inputs to its
/// parameter types, calls it, and compares the result with the expected output.
/// </summary>
public static class ProblemRunner
{
    private static readonly Assembly AlgoAssembly = Assembly.Load("LearningDSA.Algo");

    // Add JSON converters here when a problem needs custom types (e.g. ListNode, TreeNode).
    private static readonly JsonSerializerOptions Json = new();

    public static void Run(TestCaseFile file, TestCase testCase)
    {
        var method = FindSolveMethod(file);
        var parameters = method.GetParameters();
        var args = ParseArgs(file, testCase, method);
        var input = testCase.Args; // captured before the call, in case the solution changes its inputs

        object? actual;
        try
        {
            actual = method.Invoke(null, args);
        }
        catch (TargetInvocationException e) when (e.InnerException is not null)
        {
            // Rethrow the solution's own exception so Test Explorer points at your code.
            ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            throw;
        }

        // A void method changes its first argument in place (e.g. sorting): compare that instead.
        var outputType = method.ReturnType;
        if (outputType == typeof(void))
        {
            if (parameters.Length == 0)
                Assert.Fail($"{Describe(method)} returns void and takes no arguments, so there's nothing to check.");
            actual = args[0];
            outputType = parameters[0].ParameterType;
        }

        var expected = Deserialize(file, testCase, testCase.Expected, outputType, "expected output");

        var checker = FindChecker(file.ClassName);
        if (checker is not null)
        {
            checker.Check(args, expected, actual);
            return;
        }

        var expectedText = Canonical(JsonSerializer.SerializeToNode(expected, outputType, Json), file.Order);
        var actualText = Canonical(JsonSerializer.SerializeToNode(actual, outputType, Json), file.Order);
        if (expectedText != actualText)
        {
            var orderNote = file.Order == OutputOrder.Exact ? "" : $"\n(compared with order: {file.Order})";
            Assert.Fail(
                $"Input:    {input}\n" +
                $"Expected: {testCase.Expected}\n" +
                $"Actual:   {JsonSerializer.Serialize(actual, outputType, Json)}{orderNote}");
        }
    }

    // Uses the class's public static "Solve" method, or its only public static method.
    private static MethodInfo FindSolveMethod(TestCaseFile file)
    {
        var types = AlgoAssembly.GetTypes().Where(t => t.Name == file.ClassName).ToList();
        if (types.Count == 0)
            Assert.Fail($"No class named '{file.ClassName}' in LearningDSA.Algo. " +
                        $"The test data file name must match the class name: {file.FilePath}");
        if (types.Count > 1)
            Assert.Fail($"More than one class is named '{file.ClassName}': " +
                        string.Join(", ", types.Select(t => t.FullName)) + ". Class names must be unique.");

        var methods = types[0].GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
        var solve = methods.Where(m => m.Name == "Solve").ToList();
        var candidates = solve.Count > 0 ? solve : methods.ToList();
        if (candidates.Count != 1)
            Assert.Fail($"{types[0].Name} needs exactly one public static method named 'Solve' " +
                        $"(or exactly one public static method). Found: {string.Join(", ", methods.Select(m => m.Name))}");

        return candidates[0];
    }

    private static object?[] ParseArgs(TestCaseFile file, TestCase testCase, MethodInfo method)
    {
        var parameters = method.GetParameters();

        // "[1, 2], 5" becomes the JSON array "[[1, 2], 5]": one element per argument.
        var items = Deserialize<JsonElement[]>(file, testCase, $"[{testCase.Args}]", "input")!;
        if (items.Length != parameters.Length)
            Assert.Fail($"{file.FilePath}:{testCase.Line}: {Describe(method)} " +
                        $"takes {parameters.Length} argument(s) but the test case has {items.Length}: {testCase.Args}");

        return parameters
            .Select((p, i) => Deserialize(file, testCase, items[i].GetRawText(), p.ParameterType, $"argument '{p.Name}'"))
            .ToArray();
    }

    private static T? Deserialize<T>(TestCaseFile file, TestCase testCase, string json, string what) =>
        (T?)Deserialize(file, testCase, json, typeof(T), what);

    private static object? Deserialize(TestCaseFile file, TestCase testCase, string json, Type type, string what)
    {
        try
        {
            return JsonSerializer.Deserialize(json, type, Json);
        }
        catch (JsonException e)
        {
            Assert.Fail($"{file.FilePath}:{testCase.Line}: can't read the {what} '{json}' as {type.Name}. {e.Message}");
            return null;
        }
    }

    private static IChecker? FindChecker(string className)
    {
        var type = typeof(ProblemRunner).Assembly.GetTypes()
            .FirstOrDefault(t => t.Name == className + "Checker" && typeof(IChecker).IsAssignableFrom(t));
        return type is null ? null : (IChecker)Activator.CreateInstance(type)!;
    }

    // Turns a JSON value into a string where "equal" outputs produce identical text.
    // Sorting by text is fine here: it only needs to be consistent, not numerically ordered.
    private static string Canonical(JsonNode? node, OutputOrder order) => order switch
    {
        OutputOrder.Any when node is JsonArray array =>
            "[" + string.Join(",", array.Select(Text).Order(StringComparer.Ordinal)) + "]",
        OutputOrder.AnyDeep => Deep(node),
        _ => Text(node),
    };

    private static string Deep(JsonNode? node) => node is JsonArray array
        ? "[" + string.Join(",", array.Select(Deep).Order(StringComparer.Ordinal)) + "]"
        : Text(node);

    private static string Text(JsonNode? node) => node?.ToJsonString() ?? "null";

    private static string Describe(MethodInfo method) => $"{method.DeclaringType?.Name}.{method.Name}";
}
