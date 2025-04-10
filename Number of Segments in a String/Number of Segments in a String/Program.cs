// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        SegmentCounter counter = new SegmentCounter();

        Console.WriteLine("Enter a sentence:");
        string s = Console.ReadLine();

        int segments = counter.CountSegments(s);

        Console.WriteLine("Number of segments: " + segments);
    }
}
