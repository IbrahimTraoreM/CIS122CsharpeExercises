// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { -5, 3, -2, 8, -4 };
        AbsoluteSum absSum = new AbsoluteSum();
        Console.WriteLine("Sum of absolute values: " + absSum.SumAbsoluteValues(numbers));
    }
}
