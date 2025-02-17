// written by Ibrahim
// 02/13/25
using System;

public class AbsoluteSum
{
    public int SumAbsoluteValues(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            int absValue = num < 0 ? -num : num;
            sum += absValue;
        }
        return sum;
    }
}
