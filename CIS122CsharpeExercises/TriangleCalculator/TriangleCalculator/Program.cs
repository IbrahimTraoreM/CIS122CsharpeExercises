//written by Ibrahim Traore
//02/02/2024

using System;

class Program
{
    static void Main()
    {
        //ask the user for input
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        //create an object of the Triangle class
        Triangle triangle = new Triangle(baseLength, height);

        //calculate and display the area
        Console.WriteLine("The area of the triangle is: " + triangle.CalculateArea());
    }
}
