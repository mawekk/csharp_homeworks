namespace Task1;

public static class BubbleSorted
{
    public static void BubbleSort<T>(this List<T> list)where T : IComparable<T>
    {
        for (var i = 0; i < list.Count; i++)
        {
            for (var j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j].CompareTo(list[j + 1]) > 0)
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }
}

