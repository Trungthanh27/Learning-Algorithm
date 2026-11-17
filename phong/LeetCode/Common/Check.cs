// So kết quả với đáp án mong đợi, in PASS / FAIL.
public static class Check
{
    public static void Equal<T>(string name, T actual, T expected)
    {
        bool ok = EqualityComparer<T>.Default.Equals(actual, expected);
        Print(name, ok, Show(actual), Show(expected));
    }

    public static void Equal<T>(string name, T[] actual, T[] expected)
    {
        bool ok = actual != null && expected != null && actual.SequenceEqual(expected);
        Print(name, ok, Show(actual), Show(expected));
    }

    static string Show<T>(T value) => value?.ToString() ?? "null";

    static string Show<T>(T[] arr) => arr == null ? "null" : "[" + string.Join(",", arr) + "]";

    static void Print(string name, bool ok, string actual, string expected)
    {
        Console.ForegroundColor = ok ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Write(ok ? "PASS " : "FAIL ");
        Console.ResetColor();
        Console.WriteLine(ok ? name : $"{name}: ra {actual}, mong đợi {expected}");
    }
}
