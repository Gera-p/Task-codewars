using System;
using System.Linq;

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DescendingOrder(21445));
            Console.ReadKey();
        }
    }
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
