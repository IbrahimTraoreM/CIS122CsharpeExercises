// written by Ibrahim
// 02/13/25
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose arrowhead (Steel, Wood, Obsidian):");
        string head = Console.ReadLine();

        Console.WriteLine("Choose fletching (Plastic, Turkey Feathers, Goose Feathers):");
        string feathers = Console.ReadLine();

        Console.WriteLine("Enter shaft length (60-100 cm):");
        float length = float.Parse(Console.ReadLine());

        Arrow arrow = new Arrow(head, feathers, length);
        Console.WriteLine("Arrow cost: " + arrow.GetCost() + " gold");
    }
}
