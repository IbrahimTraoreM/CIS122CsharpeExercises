// written by Ibrahim Traore
// 02/06/2025

using System;

class Program
{
    static void Main()
    {
        Watchtower watchtower = new Watchtower();

        // Get user input
        Console.Write("Enter x coordinate: ");
        watchtower.X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        watchtower.Y = Convert.ToInt32(Console.ReadLine());

        // Output direction
        Console.WriteLine(watchtower.GetDirection());
    }
}