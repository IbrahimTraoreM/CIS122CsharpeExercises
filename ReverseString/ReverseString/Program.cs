// Written by Ibrahim Traore
// 04/27/25

using System;

public class Program
{
    public static void Main()
    {
        StringReverser reverser = new StringReverser();

        char[] s = { 'h', 'e', 'l', 'l', 'o' };
        reverser.ReverseString(s);

        Console.WriteLine("Reversed string:");
        foreach (char c in s)
        {
            Console.Write(c);
        }
    }
}
