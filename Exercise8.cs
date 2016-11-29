using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise8
    {
        static int fib(int n)
        {
            int i, m, a = 0, b = 1;
            for (i = 0; i < n; i++)
            {
                m = a;a = b;b += m;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("  Input the size: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" The Fibonacci series is: ");
            for (y = 0; y < x; y++)
                Console.Write(fib(y) + " ");
            Console.ReadLine();
        }
    }
}
