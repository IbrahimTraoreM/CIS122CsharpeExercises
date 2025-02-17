// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        int[] numList = { 2, 4, 6, 8 };
        Solution solution = new Solution();
        int[] modifiedArray = solution.MultiplyValues(numList);

        foreach (int num in modifiedArray) Console.Write(num + " ");
    }
}
