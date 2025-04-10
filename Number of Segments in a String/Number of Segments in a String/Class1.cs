// Written by Ibrahim Traore
// 04/09/25

public class SegmentCounter
{
    public int CountSegments(string s)
    {
        int count = 0;
        bool inSegment = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                if (!inSegment)
                {
                    count++;
                    inSegment = true;
                }
            }
            else
            {
                inSegment = false;
            }
        }

        return count;
    }
}
