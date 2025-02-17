// written by Ibrahim
// 02/13/25
using System;

public class LetterCounter
{
    // Method to count 'D' and 'd'
    public int CountDs(string sentence)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == 'D' || c == 'd') count++;
        }
        return count;
    }
}