using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write(" Input a name: ");
            a = Console.ReadLine();
            welcome(a);
            nice();
            Console.ReadLine();
        }

        static void welcome(string n)
        {
            Console.WriteLine("  Welcome friend " + n);
        }

        static void nice()
        {
            Console.WriteLine(" Have a nice day!!!");
        }
    }
}
