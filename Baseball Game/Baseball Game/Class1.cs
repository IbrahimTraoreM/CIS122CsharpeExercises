// Written by Ibrahim Traore
// 04/09/25

using System.Collections.Generic;

public class BaseballGame
{
    public int CalPoints(string[] ops)
    {
        Stack<int> scores = new Stack<int>();

        foreach (string op in ops)
        {
            if (op == "C") scores.Pop();
            else if (op == "D") scores.Push(scores.Peek() * 2);
            else if (op == "+")
            {
                int top = scores.Pop();
                int sum = top + scores.Peek();
                scores.Push(top);
                scores.Push(sum);
            }
            else scores.Push(int.Parse(op));
        }

        int total = 0;
        foreach (int score in scores) total += score;
        return total;
    }
}
