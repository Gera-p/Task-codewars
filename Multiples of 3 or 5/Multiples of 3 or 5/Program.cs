using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution(10));
            Console.ReadKey();
        }
    }
    public static class Kata
    {
        public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
}
