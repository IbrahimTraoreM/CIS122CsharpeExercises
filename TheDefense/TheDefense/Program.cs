//written by Ibrahim
//02/02/2025

using System;


class Program
{
    static void Main()
    {
        Console.Title = "Defense of Consolas";

        //get target position
        Console.Write("Enter target row: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter target column: ");
        int column = Convert.ToInt32(Console.ReadLine());

        //deploy squad
        new TheDefense(row, column).Deploy();
    }
}
