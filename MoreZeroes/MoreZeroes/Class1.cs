// Written by Ibrahim Traore
// 04/27/25

public class MoveZeros
{
    public void MoveZeroes(int[] nums)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                if (index != i) nums[i] = 0;
                index++;
            }
        }
    }
}
