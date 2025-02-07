// written by Ibrahim Traore
// 02/06/2025

using System;

class Program
{
    static void Main()
{
    DiscountCalculator discount = new DiscountCalculator();

    Console.Write("Enter your name: ");
    discount.UserName = Console.ReadLine();

    Console.Write("Enter the price: ");
    discount.Price = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Final price: ${discount.GetFinalPrice()} ");
}
}