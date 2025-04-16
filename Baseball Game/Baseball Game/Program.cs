// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        BaseballGame game = new BaseballGame();

        string[] ops = { "5", "2", "C", "D", "+" };
        int result = game.CalPoints(ops);

        Console.WriteLine("Total score: " + result);
    }
}
