// written by Ibrahim
// 04/15/25

using System.Collections.Generic;

public class RecentCounter
{
    public Queue<int> times;

    public RecentCounter()
    {
        times = new Queue<int>();
    }

    public int Ping(int t)
    {
        times.Enqueue(t);
        while (times.Peek() < t - 3000)
        {
            times.Dequeue();
        }
        return times.Count;
    }
}
