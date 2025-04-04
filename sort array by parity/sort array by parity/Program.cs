// written by Ibrahim
// 04/03/25
using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 3, 1, 2, 4 };

        int[] result = EvenOddSorterLogic.SortByParity(nums);

        Console.Write("Sorted by parity: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
