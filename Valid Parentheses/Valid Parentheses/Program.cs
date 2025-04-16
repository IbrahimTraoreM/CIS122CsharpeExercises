// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        BracketValidator validator = new BracketValidator();

        Console.WriteLine("Enter brackets:");
        string input = Console.ReadLine();

        bool valid = validator.IsValid(input);
        Console.WriteLine("Valid? " + valid);
    }
}
