// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        PivotFinder finder = new PivotFinder();
        int[] nums = { 1, 7, 3, 6, 5, 6 };

        int index = finder.PivotIndex(nums);
        Console.WriteLine("Pivot index: " + index);
    }
}
