// written by Ibrahim
// 02/16/25
using System;

public class LetterMover
{
    public string Move(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            char c = (char)(str[i] + 1);
            result += c;
        }
        return result;
    }
}
