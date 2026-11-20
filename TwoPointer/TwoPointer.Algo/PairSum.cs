namespace TwoPointer.Algo;

public class PairSum
{
	public static int[] PairSumSorted(int [] nums, int target)
	{
		int left = 0;
		int right = nums.Length - 1;
		while(left < right)
		{
			int sum = nums[left] + nums[right];

			if(sum < target)
			{
				left++;
			}
			else if(sum > target)
			{
				right--;
			}
			else
			{
				return [left, right];
			}
		}
		return [];
	}
}
