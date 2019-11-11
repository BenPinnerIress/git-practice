using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Fibonnaci();

        }

        static List<int> Fibonnaci()
        {
            List<int> fib = new List<int>() { 1, 2 };

            var last = fib.Last();
            var next = fib[fib.Count - 2];
            int hold;
            while (next < 4000000)
            {
                hold = next;
                next += last;
                last = hold;

                fib.Add(next);
            }
            foreach(int num in fib)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
            return new List<int>() { 0 };
        }
    }
}
