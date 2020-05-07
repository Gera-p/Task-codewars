using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_People_in_the_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTest myTest = new MyTest();
            myTest.FirstTest();
            Console.ReadKey();
         }
    }
    public class MyTest
    {
         public void FirstTest()
         {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Console.WriteLine(Kata.Number(peopleList));
        }
    }
    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(Item => Item[0] - Item[1]);
        }
    }
}
