namespace TwoPointer.Algo.Test;

public class BubbleSorterTests
{
    [Theory]
    [InlineData(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 2, 2, 1 }, new[] { 1, 2, 2 })]
    [InlineData(new[] { 0, -7, 4 }, new[] { -7, 0, 4 })]
    [InlineData(new[] { 7 }, new[] { 7 })]
    [InlineData(new int[0], new int[0])]
    public void Sort_InlineData_SortsAscending(int[] input, int[] expected)
    {
        BubbleSorter.Sort(input);
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(CasesFromFile))]
    public void Sort_FileData_SortsAscending(int[] input, int[] expected)
    {
        BubbleSorter.Sort(input);
        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_Null_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => BubbleSorter.Sort(null!));
    }

    public static TheoryData<int[], int[]> CasesFromFile()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "TestData", "bubble-sort-cases.txt");
        var data = new TheoryData<int[], int[]>();

        foreach (var raw in File.ReadLines(path))
        {
            var line = raw.Trim();
            if (line.Length == 0 || line.StartsWith('#'))
                continue;

            var parts = line.Split('|');
            data.Add(ParseNumbers(parts[0]), ParseNumbers(parts[1]));
        }

        return data;
    }

    private static int[] ParseNumbers(string text) =>
        text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
}
