// Written by Ibrahim Traore
// 04/27/25

public class StringReverser
{
    public void ReverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}
