// written by Ibrahim
// 04/03/25
public class EvenOddSorterLogic
{
    public static int[] SortByParity(int[] nums)
    {
        int[] result = new int[nums.Length];
        int start = 0;
        int end = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[start] = nums[i];
                start++;
            }
            else
            {
                result[end] = nums[i];
                end--;
            }
        }

        return result;
    }
}
