// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        UniqueCharFinder finder = new UniqueCharFinder();

        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int index = finder.FirstUniqueChar(input);

        Console.WriteLine("Index of first non-repeating character: " + index);
    }
}
