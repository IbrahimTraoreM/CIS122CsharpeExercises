// written by Ibrahim
// 02/13/25
using System;

public class VowelExtractor
{
    public string FirstNVowels(string str, int n)
    {
        string vowels = "aeiou";
        string result = "";
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            for (int j = 0; j < vowels.Length; j++)
            {
                if (c == vowels[j]) { result += c; count++; break; }
            }
        }
        if (count < n) return "invalid";
        return result.Substring(0, n);
    }
}
