using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" Input a big number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("   The sum is {0}.", tot(n));
            Console.ReadLine();
        }

        static int tot(int x)
        {
            string a = Convert.ToString(x);
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
                sum += Convert.ToInt32(a.Substring(i, 1));
            return sum;
        }
    }
}
