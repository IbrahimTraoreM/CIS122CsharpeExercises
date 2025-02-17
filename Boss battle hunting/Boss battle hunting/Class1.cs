// written by Ibrahim
// 02/13/25
using System;

public class ManticoreGame
{
    private int manticoreDistance;
    private int cityHealth = 15;
    private int manticoreHealth = 10;
    private int round = 1;

    public ManticoreGame(int distance)
    {
        manticoreDistance = distance;
    }

    public void PlayGame()
    {
        while (cityHealth > 0 && manticoreHealth > 0)
        {
            DisplayStatus();
            int damage = CalculateDamage(round);
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
            int guess = GetPlayerGuess();

            ProcessTurn(guess, damage);
            round++;
        }

        DisplayResult();
    }

    private void DisplayStatus()
    {
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");
    }

    private int CalculateDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0) return 10;
        if (round % 3 == 0 || round % 5 == 0) return 3;
        return 1;
    }

    private int GetPlayerGuess()
    {
        Console.Write("Enter desired cannon range: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private void ProcessTurn(int guess, int damage)
    {
        if (guess > manticoreDistance)
        {
            Console.WriteLine("That round OVERSHOT the target.");
        }
        else if (guess < manticoreDistance)
        {
            Console.WriteLine("That round FELL SHORT of the target.");
        }
        else
        {
            Console.WriteLine("That round was a DIRECT HIT!");
            manticoreHealth -= damage;
        }

        if (manticoreHealth > 0) cityHealth--;
    }

    private void DisplayResult()
    {
        if (manticoreHealth <= 0)
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        else
            Console.WriteLine("The city of Consolas has been destroyed. The Manticore is victorious!");
    }
}
