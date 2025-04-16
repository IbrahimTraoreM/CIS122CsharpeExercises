// written by Ibrahim
// 04/15/25

using System;

public class Program
{
    public static void Main()
    {
        RecentCounter recentCounter = new RecentCounter();

        Console.WriteLine(recentCounter.Ping(1));     // Output: 1
        Console.WriteLine(recentCounter.Ping(100));   // Output: 2
        Console.WriteLine(recentCounter.Ping(3001));  // Output: 3
        Console.WriteLine(recentCounter.Ping(3002));  // Output: 3
    }
}

