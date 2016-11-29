using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            Console.Write(" Input a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Input other number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   The sum is: {0}", suma(a,b));
            Console.ReadLine();
        }

        static int suma(int a, int b)
        {
            int s;
            s = a + b;
            return s;
        }
    }
}
