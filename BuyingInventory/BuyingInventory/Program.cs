// written by Ibrahim Traore
// 02/06/2025


using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        Console.WriteLine("1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
        Console.Write("Enter the number of the item to see its price: ");

        int itemNumber = Convert.ToInt32(Console.ReadLine());
        int price = inventory.GetItemPrice(itemNumber);

        if (price == -1)
            Console.Write("Invalid selection.");
        else
            Console.Write($"That item costs {price} gold.");
    }
}