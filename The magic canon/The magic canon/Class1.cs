// written by Ibrahim Traore
// 02/06/2025

using System;

class MagicCannon
{
    private int turn;

    // Getter and Setter
    public int Turn
    {
        get { return turn; }
        set { turn = value; }
    }

    // Method to determine blast type
    public string GetBlastType()
    {
        if (turn % 3 == 0 && turn % 5 == 0) return "Electric and Fire";
        if (turn % 3 == 0) return "Fire";
        if (turn % 5 == 0) return "Electric";
        return "Normal";
    }

    // Method to display output with colors
    public void DisplayBlast()
    {
        Console.Write($"{turn}: {GetBlastType()} ");
    }
}
