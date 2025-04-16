// written by Ibrahim
// 04/15/25

using System.Collections.Generic;

public class SandwichCounter
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < students.Length; i++)
        {
            queue.Enqueue(students[i]);
        }

        int index = 0;
        int count = 0;

        while (queue.Count > 0 && count < queue.Count)
        {
            if (queue.Peek() == sandwiches[index])
            {
                queue.Dequeue();
                index++;
                count = 0;
            }
            else
            {
                int student = queue.Dequeue();
                queue.Enqueue(student);
                count++;
            }
        }

        return queue.Count;
    }
}
