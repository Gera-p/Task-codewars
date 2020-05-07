using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort_the_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Console.ReadKey();
        }
    }
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));

            return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
        }
    }
}
