using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        int k = RemoveElementLogic.RemoveElement(nums, val);

        Console.WriteLine("k = " + k);
        Console.Write("Modified array: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
