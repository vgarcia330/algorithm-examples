using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRecursion
{
    class Program
    {
        static void Main()
        {
            A(0);
            Console.ReadLine();
        }

        static void A(int a)
        {
            Console.WriteLine(a);
            if (a < 5)
            {
                A(++a); // Recurse.
            }
        }
    }
}
