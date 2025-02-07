// written by Ibrahim Traore
// 02/06/2025

using System;

class Program
{
    static void Main()
    {
        GuessingGame game = new GuessingGame();
        game.GenerateTargetNumber();

        Console.Write("Guess the number between 0 and 100: ");

        do
        {
            game.UserGuess = Convert.ToInt32(Console.ReadLine());
            Console.Write(game.CheckGuess() + " ");
        } while (game.UserGuess != game.TargetNumber);

        Console.Write("Game Over! ");
    }
}
