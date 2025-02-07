// written by Ibrahim Traore
// 02/06/2025

using System;

class Replicator
{
    private int[] originalArray = new int[5];
    private int[] copiedArray = new int[5];

    // Getters and Setters
    public int[] OriginalArray
    {
        get { return originalArray; }
        set { originalArray = value; }
    }

    public int[] CopiedArray
    {
        get { return copiedArray; }
        set { copiedArray = value; }
    }

    // Method to take user input
    public void GetUserInput()
    {
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Method to copy array
    public void CopyArray()
    {
        copiedArray = (int[])originalArray.Clone();
    }

    // Method to display both arrays
    public void DisplayArrays()
    {
        Console.WriteLine("\nOriginal Array: " + string.Join(" ", originalArray));
        Console.WriteLine("Copied Array: " + string.Join(" ", copiedArray));
    }
}
