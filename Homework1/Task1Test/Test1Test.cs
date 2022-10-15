namespace Task1Test;

using NUnit.Framework;
using Task1;

public class Tests
{
    [Test]
    [Repeat(10)]
    public void IntList()
    {
        var rand = new Random();
        var lenght = rand.Next(5, 20);
        var list = new List<int>(lenght);
        var bubbleSortedList = new List<int>(lenght);

        for (var i = 0; i < lenght; i++)
        {
            var element = rand.Next(0, 100);
            list.Add(element);
            bubbleSortedList.Add(element);
        }
        
        list.Sort();
        bubbleSortedList.BubbleSort();
        Assert.That(bubbleSortedList, Is.EqualTo(list));
    }
    
    [Test]
    public void EmptyIntList()
    {
        var bubbleSortedList = new List<int>();
        
        bubbleSortedList.BubbleSort();
        Assert.That(bubbleSortedList, Is.EqualTo(new List<int>()));
    }
    
    [Test]
    public void ReversedIntList()
    {
        var list = new List<int>() {7, 6, 5, 4, 3, 2, 1};
        var bubbleSortedList = new List<int>() {7, 6, 5, 4, 3, 2, 1};

        list.Sort();
        bubbleSortedList.BubbleSort();
        Assert.That(bubbleSortedList, Is.EqualTo(list));
    }
}