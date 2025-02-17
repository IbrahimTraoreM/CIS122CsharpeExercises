// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        string input = "Dogs and Ducks dance daily.";
        LetterCounter counter = new LetterCounter();
        Console.WriteLine("Number of 'D' or 'd': " + counter.CountDs(input));
    }
}