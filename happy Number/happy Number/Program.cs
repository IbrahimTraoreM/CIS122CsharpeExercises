// Written by Ibrahim Traore
// 04/27/25

using System;

public class Program
{
    public static void Main()
    {
        HappyNumberChecker checker = new HappyNumberChecker();

        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        bool happy = checker.IsHappy(n);
        Console.WriteLine("Is happy? " + happy);
    }
}
