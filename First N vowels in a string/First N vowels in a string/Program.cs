// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        VowelExtractor extractor = new VowelExtractor();
        Console.WriteLine(extractor.FirstNVowels("sharpening skills", 3));
    }
}
