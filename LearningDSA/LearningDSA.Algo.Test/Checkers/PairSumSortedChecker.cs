using LearningDSA.Algo.Test.Framework;

namespace LearningDSA.Algo.Test.Checkers;

/// <summary>
/// Pair Sum can have several valid answers (e.g. [1, 1, 1] with target 2), so check the
/// answer's properties instead of matching the exact indexes in the test data file.
/// </summary>
public sealed class PairSumSortedChecker : IChecker
{
    public void Check(object?[] args, object? expected, object? actual)
    {
        var nums = (int[])args[0]!;
        var target = (int)args[1]!;
        var result = Assert.IsType<int[]>(actual);

        if (((int[])expected!).Length == 0)
        {
            Assert.Empty(result);
            return;
        }

        Assert.Equal(2, result.Length);
        Assert.NotEqual(result[0], result[1]);
        Assert.All(result, i => Assert.InRange(i, 0, nums.Length - 1));
        Assert.Equal(target, nums[result[0]] + nums[result[1]]);
    }
}
