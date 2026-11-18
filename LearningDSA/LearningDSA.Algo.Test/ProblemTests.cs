using LearningDSA.Algo.Test.Framework;

namespace LearningDSA.Algo.Test;

/// <summary>
/// Runs every test case in every file under TestData/. You don't need to edit this
/// to add a problem: add the solution class and a matching TestData/.../{ClassName}.txt file.
/// </summary>
public class ProblemTests
{
    [Theory]
    [MemberData(nameof(Cases))]
    public void Run(string problem, int line, string testCase)
    {
        var file = TestCaseFile.Get(problem);

        if (line == 0)
        {
            Assert.Fail($"{file.FilePath} has problems:\n{string.Join("\n", file.Errors)}");
        }

        var found = file.Cases.SingleOrDefault(c => c.Line == line);
        if (found is null || found.Text != testCase)
        {
            Assert.Fail($"{file.FilePath} changed since the tests were discovered. Rebuild and run the tests again.");
        }

        ProblemRunner.Run(file, found);
    }

    public static TheoryData<string, int, string> Cases()
    {
        var data = new TheoryData<string, int, string>();
        foreach (var file in TestCaseFile.All())
        {
            // Mistakes in a file show up as one failing test instead of being skipped.
            if (file.Errors.Count > 0)
                data.Add(file.Problem, 0, "file errors");

            foreach (var testCase in file.Cases)
                data.Add(file.Problem, testCase.Line, testCase.Text);
        }
        return data;
    }
}
