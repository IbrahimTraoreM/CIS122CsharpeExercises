﻿// Written by Ibrahim Traore
// 04/09/25

using System.Collections.Generic;

public class BracketValidator
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0) return false;

                char open = stack.Pop();
                if ((c == ')' && open != '(') ||
                    (c == '}' && open != '{') ||
                    (c == ']' && open != '['))
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
