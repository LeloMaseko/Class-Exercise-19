using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The while loop for reference");

            int i = 0;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("This a for loop");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
