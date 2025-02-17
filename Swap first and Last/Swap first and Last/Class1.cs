// written by Ibrahim
// 02/16/25
using System;

public class StringSwapper
{
    public string FlipEndChars(string str)
    {
        if (str.Length < 2) return "Incompatible.";
        if (str[0] == str[str.Length - 1]) return "Two's a pair.";
        char first = str[0];
        char last = str[str.Length - 1];
        string mid = "";
        for (int i = 1; i < str.Length - 1; i++) mid += str[i];
        return last + mid + first;
    }
}

