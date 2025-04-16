// written by Ibrahim
// 04/15/25

using System;

public class Program
{
    public static void Main()
    {
        int[] students = { 1, 1, 0, 0 };
        int[] sandwiches = { 0, 1, 0, 1 };

        SandwichCounter counter = new SandwichCounter();
        int result = counter.CountStudents(students, sandwiches);

        Console.WriteLine(result); // Output: 0
    }
}
