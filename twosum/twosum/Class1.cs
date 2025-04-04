// written by Ibrahim
// 04/03/25
using System.Collections.Generic;

public class TwoSumLogic
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];
            if (map.ContainsKey(needed))
            {
                return new int[] { map[needed], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }
        return new int[] { };
    }
}
