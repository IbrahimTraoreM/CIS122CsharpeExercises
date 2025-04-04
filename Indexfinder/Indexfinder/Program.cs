using System;

public class Program
{
    public static void Main()
    {
        string haystack = "sadbutsad";
        string needle = "sad";

        int index = StringSearchLogic.FindNeedle(haystack, needle);
        Console.WriteLine(index);
    }
}
