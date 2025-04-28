// Written by Ibrahim Traore
// 04/27/25

public class MajorityElementFinder
{
    public int MajorityElement(int[] nums)
    {
        int count = 0, candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0) candidate = num;
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}
