// Written by Ibrahim Traore
// 04/27/25

public class LastWordLength
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ') length++;
            else if (length > 0) break;
        }

        return length;
    }
}
