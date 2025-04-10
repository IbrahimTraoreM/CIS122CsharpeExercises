// Written by Ibrahim Traore
// 04/09/25

public class UniqueCharFinder
{
    public int FirstUniqueChar(string s)
    {
        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            count[index]++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            if (count[index] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}

