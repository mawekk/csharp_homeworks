namespace Test1;

public class ThreadSafePriorityQueue<P, V > where P : IComparable<P>
{
    private readonly SortedDictionary<P, List<V>> queue = new();
    private int count = 0;
    private readonly object queueLock = new();

    public void Enqueue(P priority, V value)
    {
        lock (queueLock)
        {
            if (queue.ContainsKey(priority) != true)
            {
                var list = new List<V>();
                queue.Add(priority, list);
            }
            queue[priority].Add(value);
            count++;
            Monitor.PulseAll(queueLock);
        }
    }

    public V Dequeue()
    {
        lock (queueLock)
        {
            if (queue.Count == 0) Monitor.Wait(queueLock);

            var key = queue.Keys.Last();
            var element = queue[key].First();
            queue[key].RemoveAt(0);
            count--;

            if (queue[key].Count == 0)
            {
                queue.Remove(key);
            }

            return element;
        }
    }

    public int Size() => count;
}