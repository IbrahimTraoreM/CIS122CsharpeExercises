// written by Ibrahim
// 02/16/25
using System;

public class OrderChecker
{
    public bool IsInOrder(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] > str[i + 1]) return false;
        }
        return true;
    }
}
