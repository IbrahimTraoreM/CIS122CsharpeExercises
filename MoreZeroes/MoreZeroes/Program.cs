// Written by Ibrahim Traore
// 04/27/25

using System;

public class Program
{
    public static void Main()
    {
        MoveZeros mover = new MoveZeros();
        int[] nums = { 0, 1, 0, 3, 12 };

        mover.MoveZeroes(nums);

        Console.WriteLine("Array after moving zeros:");
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
}
