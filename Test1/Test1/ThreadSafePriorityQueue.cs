namespace Test1;

public class ThreadSafePriorityQueue<P, V > where P : IComparable<P>
{
    private readonly SortedList<P, V> list = new();
    private int count = 0;
    private readonly object listLock = new();

    public void Enqueue(P priority, V value)
    {
        lock (listLock)
        {
            list.Add(priority, value);
            count++;
            Monitor.PulseAll(listLock);
        }
    }

    public V Dequeue()
    {
        lock (listLock)
        {
            if (list.Count == 0) Monitor.Wait(listLock);

            var element = list.Values.Last();
            list.RemoveAt(list.Count - 1);
            count--;

            return element;
        }
    }

    public int Size() => count;
}