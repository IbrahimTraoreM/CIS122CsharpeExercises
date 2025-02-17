// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? (0-100): ");
        int distance = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        ManticoreGame game = new ManticoreGame(distance);
        game.PlayGame();
    }
}
