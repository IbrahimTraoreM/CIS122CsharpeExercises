// Written by Ibrahim Traore
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        RobotLogic robot = new RobotLogic();

        Console.WriteLine("Enter the robot moves (e.g., UDLR):");
        string moves = Console.ReadLine();

        bool result = robot.JudgeCircle(moves);

        Console.WriteLine("Does the robot return to origin? " + result);
    }
}
