// written by Ibrahim
// 02/13/25
using System;

namespace mp3
{
    public class Solution
    {
        public static int[] FindNums(int[] arr)
        {
            if (arr.Length == 0) return new int[] { };
            int min = arr[0];
            int max = arr[0];

            foreach (int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }

            return new int[] { min, max };
        }
    }
}
