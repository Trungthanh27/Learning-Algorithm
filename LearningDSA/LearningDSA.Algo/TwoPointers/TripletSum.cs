namespace LearningDSA.Algo.TwoPointers;

// Chapter 1 - Two Pointers: Triplet Sum
//
// Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0.
// The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1]
// are considered duplicates). If no such triplets are found, return an empty list.
//
// Each triplet can be arranged in any order, and the output can be returned in any order.
public static class TripletSum
{
    public static List<int[]> Solve(int[] nums)
    {
        // TODO: your solution here.
        throw new NotImplementedException();
    }

    // Hint: the book splits this into a helper - a version of Pair Sum that
    // starts at index `start` and collects ALL pairs that sum to `target`
    // (skipping duplicates) instead of returning the first one.
    // You don't have to use it, but it's here if you want to follow the book.
    private static List<int[]> PairSumSortedAllPairs(int[] nums, int start, int target)
    {
        throw new NotImplementedException();
    }
}
