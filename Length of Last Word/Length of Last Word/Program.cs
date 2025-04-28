// Written by Ibrahim Traore
// 04/27/25

using System;

public class Program
{
    public static void Main()
    {
        LastWordLength finder = new LastWordLength();

        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();

        int result = finder.LengthOfLastWord(s);
        Console.WriteLine("Length of last word: " + result);
    }
}
