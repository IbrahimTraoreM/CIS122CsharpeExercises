// Written by Ibrahim Traore
// 04/09/25

public class PivotFinder
{
    public int PivotIndex(int[] nums)
    {
        int total = 0, left = 0;
        for (int i = 0; i < nums.Length; i++) total += nums[i];

        for (int i = 0; i < nums.Length; i++)
        {
            if (left == total - left - nums[i]) return i;
            left += nums[i];
        }

        return -1;
    }
}
