//written by Ibrahim Traore
//02/02/2025

using System;

class ClockTower
{
    private int number;

    //constructor to initialize the number
    public ClockTower(int number)
    {
        this.number = number;
    }

    //method to determine and display "Tick" or "Tock"
    public void DisplayPendulum()
    {
        string result = (number % 2 == 0) ? "Tick" : "Tock";
        Console.WriteLine($"\n{result}");
    }
}
