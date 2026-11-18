using System.Collections.Concurrent;

namespace LearningDSA.Algo.Test.Framework;

/// <summary>How the expected and actual outputs are compared.</summary>
public enum OutputOrder
{
    /// <summary>Outputs must match exactly (the default).</summary>
    Exact,

    /// <summary>The order of items in the top-level list doesn't matter.</summary>
    Any,

    /// <summary>Order doesn't matter at any level, e.g. a list of triplets in any order, each in any order.</summary>
    AnyDeep,
}

/// <summary>One line of a test data file: <c>arguments | expected</c>.</summary>
/// <param name="Line">1-based line number in the file.</param>
/// <param name="Args">The text before the '|', e.g. <c>[1, 2, 3], 5</c>.</param>
/// <param name="Expected">The text after the '|', e.g. <c>[0, 1]</c>.</param>
/// <param name="Text">The whole line, shown in Test Explorer.</param>
public sealed record TestCase(int Line, string Args, string Expected, string Text);

/// <summary>
/// A test data file under TestData/. The file name (without .txt) must match the
/// solution's class name, e.g. TestData/TwoPointers/PairSumSorted.txt tests the PairSumSorted class.
/// </summary>
public sealed class TestCaseFile
{
    private static readonly ConcurrentDictionary<string, TestCaseFile> Cache = new();

    public static string Root => Path.Combine(AppContext.BaseDirectory, "TestData");

    /// <summary>Path relative to TestData without the extension, e.g. "TwoPointers/PairSumSorted".</summary>
    public string Problem { get; }

    /// <summary>The solution class this file tests, e.g. "PairSumSorted".</summary>
    public string ClassName => Path.GetFileName(Problem);

    /// <summary>Where the file lives in the test project, e.g. "TestData/TwoPointers/PairSumSorted.txt". Used in messages.</summary>
    public string FilePath => $"TestData/{Problem}.txt";

    public OutputOrder Order { get; private set; } = OutputOrder.Exact;
    public List<TestCase> Cases { get; } = [];

    /// <summary>Problems found in the file that should fail the test instead of being silently ignored.</summary>
    public List<string> Errors { get; } = [];

    private TestCaseFile(string path)
    {
        Problem = ProblemName(path);
        Parse(path);
    }

    public static IEnumerable<TestCaseFile> All() =>
        Directory.EnumerateFiles(Root, "*.txt", SearchOption.AllDirectories)
            .Select(ProblemName)
            .Order(StringComparer.Ordinal)
            .Select(Get);

    private static string ProblemName(string path) =>
        Path.ChangeExtension(Path.GetRelativePath(Root, path), null).Replace('\\', '/');

    public static TestCaseFile Get(string problem) =>
        Cache.GetOrAdd(problem, p => new TestCaseFile(Path.Combine(Root, p + ".txt")));

    private void Parse(string path)
    {
        var lineNumber = 0;
        foreach (var raw in File.ReadLines(path))
        {
            lineNumber++;
            var line = raw.Trim();

            if (line.StartsWith("#!"))
            {
                ParseDirective(line[2..], lineNumber);
                continue;
            }

            if (line.Length == 0 || line.StartsWith('#'))
                continue;

            var bar = FindSeparator(line);
            if (bar < 0)
            {
                Errors.Add($"Line {lineNumber}: missing '|' between the input and the expected output: {line}");
                continue;
            }

            Cases.Add(new TestCase(lineNumber, line[..bar].Trim(), line[(bar + 1)..].Trim(), line));
        }
    }

    // Directives look like "#! order: any-deep".
    private void ParseDirective(string text, int lineNumber)
    {
        var parts = text.Split(':', 2, StringSplitOptions.TrimEntries);
        switch (parts[0].ToLowerInvariant(), parts.ElementAtOrDefault(1)?.ToLowerInvariant())
        {
            case ("order", "exact"): Order = OutputOrder.Exact; break;
            case ("order", "any"): Order = OutputOrder.Any; break;
            case ("order", "any-deep"): Order = OutputOrder.AnyDeep; break;
            default:
                Errors.Add($"Line {lineNumber}: unknown directive '#!{text}'. Supported: '#! order: exact | any | any-deep'");
                break;
        }
    }

    // The first '|' that isn't inside a JSON string, so inputs like "a|b" still work.
    private static int FindSeparator(string line)
    {
        var inString = false;
        for (var i = 0; i < line.Length; i++)
        {
            switch (line[i])
            {
                case '\\' when inString: i++; break;
                case '"': inString = !inString; break;
                case '|' when !inString: return i;
            }
        }
        return -1;
    }
}
