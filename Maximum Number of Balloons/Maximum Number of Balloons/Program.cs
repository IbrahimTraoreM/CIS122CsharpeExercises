// Written by Ibrahim Traore
// 04/09/25

using System;

namespace BalloonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BalloonCounter counter = new BalloonCounter();

            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            int result = counter.MaxNumberOfBalloons(text);
            Console.WriteLine($"Maximum number of 'balloon' instances that can be formed: {result}");
        }
    }
}
