using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_ends_with
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution("!@#$%^&*() :-)", ":-r"));
            Console.ReadKey();
        }
    }
    public class Kata
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }
}
