// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        WordMerger merger = new WordMerger();

        Console.WriteLine("Enter the first word:");
        string word1 = Console.ReadLine();

        Console.WriteLine("Enter the second word:");
        string word2 = Console.ReadLine();

        string merged = merger.MergeAlternately(word1, word2);

        Console.WriteLine("Merged string: " + merged);
    }
}
