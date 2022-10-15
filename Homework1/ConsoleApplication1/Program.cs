using System;
using Task2;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string example = "ABACABA";
            Console.WriteLine("Before: " + example);
            var transformed = BurrowsWheelerTransformation.Transform(example);
            Console.WriteLine("After BWT: " + transformed.Item1 + ", " + transformed.Item2);
        }
    }
}