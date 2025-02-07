// written by Ibrahim Traore
// 02/06/2025

using System;

class GuessingGame
{
    private int targetNumber;
    private int userGuess;

    // Getters and Setters
    public int TargetNumber
    {
        get { return targetNumber; }
        set { targetNumber = value; }
    }

    public int UserGuess
    {
        get { return userGuess; }
        set { userGuess = value; }
    }

    // Generate random number
    public void GenerateTargetNumber()
    {
        Random random = new Random();
        targetNumber = random.Next(0, 101);
    }

    // Check guess
    public string CheckGuess()
    {
        if (userGuess > targetNumber) return "Too high! Try again.";
        if (userGuess < targetNumber) return "Too low! Try again.";
        return "Correct! You found the target.";
    }
}
