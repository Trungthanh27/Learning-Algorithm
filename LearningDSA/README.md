# LearningDSA

Solutions to problems from *Coding Interview Patterns* (Alex Xu, Shaun Gunawardane), with a generic test runner.

- `LearningDSA.Algo` - the solutions, one folder per chapter.
- `LearningDSA.Algo.Test` - xUnit tests. One generic test (`ProblemTests`) runs every case in every file under `TestData/`.

Open `LearningDSA.slnx` in Visual Studio and use **Test > Test Explorer > Run All**
(or `dotnet test` from this folder). Right-click a test case and choose **Debug** to step through your solution.

## Adding a problem

1. **Solution:** add a class to `LearningDSA.Algo/<Chapter>/` with a `public static` method named `Solve`
   (or a class with only one public static method):

   ```csharp
   namespace LearningDSA.Algo.TwoPointers;

   public static class IsPalindromeValid
   {
       public static bool Solve(string s) => throw new NotImplementedException();
   }
   ```

2. **Test cases:** add `LearningDSA.Algo.Test/TestData/<Chapter>/<ClassName>.txt`.
   The file name must match the class name.

   ```
   # Each line: arguments | expected output   (both written as JSON)
   "a dog! a panic in a pagoda" | true
   "abc123" | false
   "" | true
   ```

That's it - no test code. The new cases show up in Test Explorer after a build.

## Test data format

- One case per line: `arguments | expected`. Arguments are separated by commas, in the order of the method's parameters.
- Values are JSON: `5`, `true`, `"text"`, `[1, 2, 3]`, `[[1, 2], [3]]`, `[]`.
- Lines starting with `#` are comments. Blank lines are ignored.
- If the method returns `void` (it changes its input in place, like sorting), the first argument after the call is compared with the expected output.

### Directives

| Directive | Meaning |
|---|---|
| `#! order: exact` | Output must match exactly (default). |
| `#! order: any` | The order of items in the output list doesn't matter. |
| `#! order: any-deep` | Order doesn't matter at any level, e.g. a list of triplets where each triplet can also be in any order. |

## More than one valid answer

When any of several answers is correct (e.g. Pair Sum returns *any* valid pair), add a checker in
`LearningDSA.Algo.Test/Checkers/` named `<ClassName>Checker` that implements `IChecker`.
It's used instead of comparing with the expected output. See `PairSumSortedChecker.cs`.

## Other tests

Regular xUnit tests still work for things a data file can't express, such as expected exceptions.
See `BubbleSorterTests.cs`.

## Custom types

Problems that use linked lists or trees need a JSON converter so test files can write them as `[1, 2, 3]`.
Register it in `JsonSerializerOptions` in `Framework/ProblemRunner.cs`.
