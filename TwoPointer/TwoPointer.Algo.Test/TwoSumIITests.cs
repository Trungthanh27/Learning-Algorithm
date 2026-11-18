namespace TwoPointer.Algo.Test;

public class TwoSumIITests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
    [InlineData(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { -1, 0 }, -1, new[] { 1, 2 })]
    public void TwoSum_InlineData_ReturnsIndices(int[] numbers, int target, int[] expected)
    {
        Assert.Equal(expected, TwoSumII.TwoSum(numbers, target));
    }

    [Theory]
    [MemberData(nameof(CasesFromFile))]
    public void TwoSum_FileData_ReturnsIndices(int[] numbers, int target, int[] expected)
    {
        Assert.Equal(expected, TwoSumII.TwoSum(numbers, target));
    }

    public static TheoryData<int[], int, int[]> CasesFromFile()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "TestData", "two-sum-ii-cases.txt");
        var data = new TheoryData<int[], int, int[]>();

        foreach (var raw in File.ReadLines(path))
        {
            var line = raw.Trim();
            if (line.Length == 0 || line.StartsWith('#'))
                continue;

            var parts = line.Split('|');
            data.Add(ParseNumbers(parts[0]), int.Parse(parts[1].Trim()), ParseNumbers(parts[2]));
        }

        return data;
    }

    private static int[] ParseNumbers(string text) =>
        text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
}
