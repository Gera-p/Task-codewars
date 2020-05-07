using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_the_first_nth_term_of_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthSeries.seriesSum(5));
            Console.ReadKey();
        }
    }
    public class NthSeries  
    {
        public static string seriesSum(int n)
        {
            return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
        }
    }
}
