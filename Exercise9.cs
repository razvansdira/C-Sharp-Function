using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("   Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (prim(a))
                Console.Write(" It is a prime number.");
            else
                Console.Write("It is not a prime number.");

            Console.ReadLine();
        }

        static bool prim(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
