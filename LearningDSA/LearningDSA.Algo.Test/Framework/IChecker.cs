namespace LearningDSA.Algo.Test.Framework;

/// <summary>
/// Custom correctness check for a problem with more than one valid answer.
/// Name the class "{ProblemClassName}Checker" (e.g. PairSumSortedChecker) and the
/// generic runner uses it instead of comparing against the expected output.
/// </summary>
public interface IChecker
{
    /// <param name="args">The arguments the solution was called with (after the call, so in-place changes are visible).</param>
    /// <param name="expected">The expected output from the test data file, converted to the solution's return type.</param>
    /// <param name="actual">What the solution returned.</param>
    void Check(object?[] args, object? expected, object? actual);
}
