// written by Ibrahim
// 02/13/25
using System;

public class Solution
{
    public int GetArrayLength(int[] numbers)
    {
        int length = 0;
        foreach (int num in numbers) length++;
        return length;
    }

    public int[] MultiplyValues(int[] numbers)
    {
        int length = GetArrayLength(numbers);
        for (int i = 0; i < length; i++) numbers[i] *= length;
        return numbers;
    }
}
