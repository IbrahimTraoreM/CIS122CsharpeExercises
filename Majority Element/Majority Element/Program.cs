using System;
using System.Collections.Generic;
// Written by Ibrahim Traore
// 04/27/25

using System;

public class Program
{
    public static void Main()
    {
        MajorityElementFinder finder = new MajorityElementFinder();
        int[] nums = { 3, 2, 3 };

        int majority = finder.MajorityElement(nums);
        Console.WriteLine("Majority element: " + majority);
    }
}
