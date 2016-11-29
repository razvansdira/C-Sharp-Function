using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise5
    {
        static int suma(int[] a)
        {
            int i, t=0;
            for(i=0; i<a.Length; i++)
            t = t + a[i];
            return t;
        }

        static void Main(String[] args)
        {
            int[] a = new int[5];
            int j;
            Console.Write("  Input 5 elements: ");
            for(j=0; j<5; j++)
            {
                Console.Write("\nElement {0} : ", j);
                a[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("  The sum is: {0}", suma(a));
            Console.ReadLine();
        }
    }
}
