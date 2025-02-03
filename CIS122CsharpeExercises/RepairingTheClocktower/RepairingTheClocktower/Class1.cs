//written by Ibrahim Traore 
//02/02/25

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Repairing the Clocktower";

        //get user input
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        //create a ClockTower object and determine the pendulum movement
        ClockTower clock = new ClockTower(inputNumber);
        clock.DisplayPendulum();
    }
}
