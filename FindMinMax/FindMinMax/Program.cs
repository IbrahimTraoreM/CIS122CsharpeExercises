// written by Ibrahim
// 02/13/25
using System;

namespace mp3
{
    public class Program
    {
        public static void Main()
        {
            int[] numList = { 3, 7, 2, 9, 1 };
            int[] result = Solution.FindNums(numList);

            if (result.Length == 0)
                Console.WriteLine("The array is empty.");
            else
            {
                Console.WriteLine("Minimum: " + result[0]);
                Console.WriteLine("Maximum: " + result[1]);
            }
        }
    }
}
