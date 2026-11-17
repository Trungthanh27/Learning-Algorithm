namespace TwoPointer.Algo;

public static class BubbleSorter
{
    // Sorts the array in place, ascending. Stops early once a pass makes no swaps.
    public static void Sort(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        for (var end = nums.Length - 1; end > 0; end--)
        {
            var swapped = false;
            for (var i = 0; i < end; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    swapped = true;
                }
            }

            if (!swapped)
                return;
        }
    }
}
