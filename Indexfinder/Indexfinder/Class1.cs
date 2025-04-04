// written by Ibrahim
// 04/03/25
public class StringSearchLogic
{
    public static int FindNeedle(string haystack, string needle)
    {
        int h = haystack.Length;
        int n = needle.Length;

        for (int i = 0; i <= h - n; i++)
        {
            int j = 0;
            while (j < n && haystack[i + j] == needle[j])
            {
                j++;
            }
            if (j == n)
            {
                return i;
            }
        }

        return -1;
    }
}
