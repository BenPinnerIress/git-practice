using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_Of_3_And_5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                Console.WriteLine("Argument Required: integer");
            }
            else
            {
                var numbers = new List<int>();

                int number = Int32.Parse(args[0]);
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        numbers.Add(i);
                    }
                }
                Console.WriteLine(numbers.AsQueryable().Sum());
                Console.ReadLine();
            }
        }
    }
}
