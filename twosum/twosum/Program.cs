// written by Ibrahim
// 02/03/25
using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSumLogic.FindTwoSum(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}
