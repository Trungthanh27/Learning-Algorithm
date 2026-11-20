using System.Diagnostics;
using TwoPointer.Algo;
using Xunit;

namespace TwoPointer.Algo.Test;

public class PairSumTests
{
    #region Quick Tests with InlineData (5 to 10 elements)

    [Theory]
    // 5 elements
    [InlineData(new[] { 1, 2, 3, 4, 6 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { 2, 5, 9, 11, 15 }, 9, new int[0])]
    [InlineData(new[] { -10, -5, 0, 5, 10 }, 0, new[] { 0, 4 })]
    // 6 elements
    [InlineData(new[] { -5, -2, 0, 1, 4, 9 }, 2, new[] { 1, 4 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 7, new[] { 0, 5 })]
    // 7 elements
    [InlineData(new[] { 1, 3, 5, 7, 9, 11, 13 }, 16, new[] { 1, 6 })]
    [InlineData(new[] { -10, -5, -2, 0, 3, 8, 12 }, -7, new[] { 0, 4 })]
    // 8 elements
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 10, new[] { 1, 7 })]
    [InlineData(new[] { 2, 4, 6, 8, 10, 12, 14, 16 }, 21, new int[0])]
    // 9 elements
    [InlineData(new[] { -8, -6, -4, -2, 0, 2, 4, 6, 8 }, 0, new[] { 0, 8 })]
    [InlineData(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 }, 2, new[] { 0, 1 })]
    // 10 elements
    [InlineData(new[] { 1, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 22, new[] { 1, 8 })]
    [InlineData(new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }, 100, new int[0])]
    [InlineData(new[] { -20, -15, -10, -5, 0, 5, 10, 15, 20, 25 }, 5, new[] { 0, 9 })]
    public void PairSumSorted_InlineData_QuickTest(int[] nums, int target, int[] expected)
    {
        // Verify constraint: Array size is between 5 and 10 s
        Assert.InRange(nums.Length, 5, 10);

        var actual = PairSum.PairSumSorted(nums, target);

        Assert.Equal(expected, actual);
        if (expected.Length == 2)
        {
            Assert.Equal(target, nums[actual[0]] + nums[actual[1]]);
            Assert.True(actual[0] < actual[1]);
        }
    }

    #endregion

    #region Performance Tests with File Data (>= 100k items, one file per test case)

    [Theory]
    [InlineData("pair-sum-100k-case1-match-edges.txt")]
    [InlineData("pair-sum-100k-case2-match-middle.txt")]
    [InlineData("pair-sum-100k-case3-no-match.txt")]
    [InlineData("pair-sum-100k-case4-negative-range.txt")]
    public void PairSumSorted_FileData_PerformanceTest(string fileName)
    {
        var testCase = LoadTestCase(fileName);

        // Verify dataset satisfies the requirement (>= 100,000 items)
        Assert.True(testCase.Nums.Length >= 100_000,
            $"Expected at least 100,000 items in {fileName}, but got {testCase.Nums.Length}.");

        // Benchmark the two-pointer algorithm execution
        var stopwatch = Stopwatch.StartNew();
        var actual = PairSum.PairSumSorted(testCase.Nums, testCase.Target);
        stopwatch.Stop();

        // Correctness assertion
        Assert.Equal(testCase.Expected, actual);
        if (testCase.Expected.Length == 2)
        {
            Assert.Equal(testCase.Target, testCase.Nums[actual[0]] + testCase.Nums[actual[1]]);
            Assert.True(actual[0] < actual[1]);
        }

        // Performance assertion: O(n) two-pointer on 100,000 elements should take under 50 ms
        Assert.True(stopwatch.ElapsedMilliseconds < 50,
            $"Algorithm took {stopwatch.ElapsedMilliseconds} ms, exceeding the 50 ms performance limit for {fileName}.");
    }

    #endregion

    #region Edge Cases

    [Fact]
    public void PairSumSorted_EmptyArray_ReturnsEmpty()
    {
        var result = PairSum.PairSumSorted([], 10);
        Assert.Empty(result);
    }

    [Fact]
    public void PairSumSorted_SingleElement_ReturnsEmpty()
    {
        var result = PairSum.PairSumSorted([42], 42);
        Assert.Empty(result);
    }

    [Fact]
    public void PairSumSorted_NullArray_ThrowsException()
    {
        Assert.Throws<NullReferenceException>(() => PairSum.PairSumSorted(null!, 0));
    }

    #endregion

    #region Helpers for File Data

    public record PairSumTestCase(string Description, int Target, int[] Expected, int[] Nums);

    public static PairSumTestCase LoadTestCase(string fileName)
    {
        var path = Path.Combine(AppContext.BaseDirectory, "TestData", fileName);
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Test data file not found at: {path}");
        }

        string description = Path.GetFileNameWithoutExtension(fileName);
        int target = 0;
        int[] expected = [];
        var numsList = new List<int>();

        foreach (var rawLine in File.ReadLines(path))
        {
            var line = rawLine.Trim();
            if (line.Length == 0)
                continue;

            if (line.StartsWith("# Description:", StringComparison.OrdinalIgnoreCase))
            {
                description = line["# Description:".Length..].Trim();
            }
            else if (line.StartsWith("#", StringComparison.Ordinal))
            {
                continue;
            }
            else if (line.StartsWith("target:", StringComparison.OrdinalIgnoreCase))
            {
                target = int.Parse(line["target:".Length..].Trim());
            }
            else if (line.StartsWith("expected:", StringComparison.OrdinalIgnoreCase))
            {
                var expText = line["expected:".Length..].Trim();
                if (!string.Equals(expText, "none", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(expText))
                {
                    expected = expText.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();
                }
            }
            else
            {
                var parsed = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse);
                numsList.AddRange(parsed);
            }
        }

        return new PairSumTestCase(description, target, expected, numsList.ToArray());
    }

    #endregion
}
