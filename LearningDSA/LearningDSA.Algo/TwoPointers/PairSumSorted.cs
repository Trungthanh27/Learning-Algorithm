namespace LearningDSA.Algo.TwoPointers;

// Chapter 1 - Two Pointers: Pair Sum (Sorted)
//
// Given an array of integers sorted in ascending order and a target value,
// return the indexes of any pair of numbers that sum to the target.
// The order of the indexes doesn't matter. If no pair is found, return an empty array.
public static class PairSumSorted
{
    public static int[] Solve(int[] nums, int target)
    {
        var result = new int[0];
        int left = 0;
        int right = nums.Length - 1;
        while (left < right) {
            int sum = nums[left] + nums[right];
            if (sum == target) {
                result = new int[] { left, right };
                break;
            } else if (sum < target) {
                left++;
            } else {
                right--;
            }
        }
        return result;
    }
}
