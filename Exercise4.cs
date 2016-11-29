using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise4
    {
        static int space(string a)
        {
            string b;
            int ctr=0;
            for(int i=0; i<a.Length; i++)
            {
                b = a.Substring(i, 1);
                if (b == " ")
                    ctr++;
            }
            return ctr++;
        }

        static void Main(string[] args)
        {
            Console.Write("  Input a string: ");
            string c = Console.ReadLine();
            Console.WriteLine(c+" -> contains {0} spaces.", space(c));
            Console.ReadLine();
        }

    }
}
