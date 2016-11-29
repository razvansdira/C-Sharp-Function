using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise7
    {
        static int pow(int a, int b)
        {
            int i, x=1;
            for (i = 1; i <= b; i++)
            x = x* a;
            return x;
        }

        static void Main(string[] args)
        {
            int m, n;
            Console.Write("  Input the base: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the exponent: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("  The result is: {0}", pow(m,n));
            Console.ReadLine();
        }
    }
}
