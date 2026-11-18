using LearningDSA.Algo.Sorting;

namespace LearningDSA.Algo.Test;

// Normal input/output cases live in TestData/Sorting/BubbleSorter.txt and run through ProblemTests.
// You can still write regular xUnit tests for things a data file can't express, like exceptions.
public class BubbleSorterTests
{
    [Fact]
    public void Sort_Null_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => BubbleSorter.Sort(null!));
    }
}
