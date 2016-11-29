using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise6
    {
        static void inv(ref int a,ref int b)
        {
            int x;
            x = a;
            a = b;
            b = x;
        }

        static void Main(string[] args)
        {
            int m, n;
            Console.Write("  Input first number: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input second number: ");
            n = Convert.ToInt32(Console.ReadLine());
            inv(ref m, ref n);

            Console.Write("Now, first is {0} and second is {1}.", m,n);

            Console.ReadLine();
        }
    }
}
