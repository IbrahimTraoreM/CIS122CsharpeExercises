//written by Ibrahim Traore
//02/02/2025

using System;

class Program
{
    static void Main()
    {
        Console.Title = "The Dominion of Kings";

        // Get user input
        Console.Write("Enter number of Estates: ");
        int estates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of Duchies: ");
        int duchies = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of Provinces: ");
        int provinces = Convert.ToInt32(Console.ReadLine());

        // Create a Kingdom object and calculate the score
        Kingdom myKingdom = new Kingdom(estates, duchies, provinces);
        myKingdom.DisplayScore();
    }
}
