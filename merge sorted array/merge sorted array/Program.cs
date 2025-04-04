// written by Ibrahim
// 04/03/25
using System;

public class Program
{
    public static void Main()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;

        MergeSortedArraysLogic.Merge(nums1, m, nums2, n);

        Console.Write("Merged array: ");
        for (int i = 0; i < m + n; i++)
        {
            Console.Write(nums1[i] + " ");
        }
        Console.WriteLine();
    }
}
