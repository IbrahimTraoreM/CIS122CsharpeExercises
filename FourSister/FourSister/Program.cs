//written By Ibrahim Traore
//02/02/25

using System;

namespace FourSister
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input
            Console.WriteLine("enter the total number of chocolate eggs collected: ");
            int eggs = Convert.ToInt32(Console.ReadLine());

            //create an object of ChocolateFarm
            ChocolateFarm farm = new ChocolateFarm(eggs);

            //display results
            Console.WriteLine("each sister gets " + farm.GetEggsPerSisters() + " eggs.");
            Console.WriteLine("the duck gets " + farm.GetDuckbearEggs() + " leftover eggs.");
        }
    }
}
