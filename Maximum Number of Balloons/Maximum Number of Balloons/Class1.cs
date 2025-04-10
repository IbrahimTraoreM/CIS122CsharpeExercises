// Written by Ibrahim Traore
// 04/09/25

using System;
using System.Collections.Generic;

namespace BalloonApp
{
    public class BalloonCounter
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char c in text)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            string balloon = "balloon";
            Dictionary<char, int> balloonCounts = new Dictionary<char, int>();
            foreach (char c in balloon)
            {
                if (balloonCounts.ContainsKey(c))
                    balloonCounts[c]++;
                else
                    balloonCounts[c] = 1;
            }

            int minInstances = int.MaxValue;
            foreach (var kvp in balloonCounts)
            {
                char letter = kvp.Key;
                int requiredCount = kvp.Value;
                if (charCounts.ContainsKey(letter))
                    minInstances = Math.Min(minInstances, charCounts[letter] / requiredCount);
                else
                    return 0;
            }

            return minInstances;
        }
    }
}
