// Written by Ibrahim Traore
// 04/09/25

public class WordMerger
{
    public string MergeAlternately(string word1, string word2)
    {
        string result = "";
        int i = 0;
        int j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                result += word1[i];
                i++;
            }
            if (j < word2.Length)
            {
                result += word2[j];
                j++;
            }
        }

        return result;
    }
}
