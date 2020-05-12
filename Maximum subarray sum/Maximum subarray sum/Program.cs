using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maximum_subarray_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{-2, 1, -3, 4, -1, 2, 1, -5, 4};
            Console.WriteLine(Kata.MaxSequence(arr));
            Console.ReadKey();
        }
    }
    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            int max = 0, res = 0, sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }
            return res;
        }
    }
}
