using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {22,34,1,2,44,23,13,14,24,11 };

            var a = from i in arr where i>20 orderby i select i;

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------------");

            string[] s = {"Hello","Good Morning", "Good Night" , "GoodBye" };

            var st = from greet in s where greet.Contains("Good") select greet;
            foreach (string greet in st)
            {
                Console.WriteLine(greet);
            }
            Console.ReadLine();
        }
    }
}
