// 167. Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
namespace P0167;

// Copy nguyên class Solution này lên LeetCode để nộp.
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        // code của bạn
        return new int[0];
    }
}

public static class Test
{
    public static void Run()
    {
        var s = new Solution();
        Check.Equal("vd 1", s.TwoSum(new[] { 2, 7, 11, 15 }, 9), new[] { 1, 2 });
        Check.Equal("vd 2", s.TwoSum(new[] { 2, 3, 4 }, 6), new[] { 1, 3 });
        Check.Equal("vd 3", s.TwoSum(new[] { -1, 0 }, -1), new[] { 1, 2 });
        // Tự thêm ca biên bạn nghĩ ra ở đây
    }
}
