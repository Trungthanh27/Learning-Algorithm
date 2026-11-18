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
        var result = new List<int[]>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // skip duplicates
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int target = -nums[i];
            var pairs = PairSumSortedAllPairs(nums, i + 1, target);
            foreach (var pair in pairs)
            {
                result.Add([nums[i], nums[pair[0]], nums[pair[1]]]);
            }
        }
        return result;
    }

    private static List<int[]> PairSumSortedAllPairs(int[] nums, int start, int target)
    {
        var result = new List<int[]>();
        int left = start;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum == target)
            {
                result.Add([left, right]);
                // skip duplicates
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                left++;
                right--;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return result;
    }
}
