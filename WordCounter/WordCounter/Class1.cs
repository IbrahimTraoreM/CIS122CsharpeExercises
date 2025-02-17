// written by Ibrahim
// 02/16/25
using System;

public class WordCounter
{
    public int CountWords(string sentence)
    {
        int count = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ' && (i == 0 || sentence[i - 1] == ' '))
                count++;
        }
        return count;
    }
}
