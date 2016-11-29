using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            welcome();
            nice();
            Console.ReadLine();
        }

        static void welcome()
        {
            Console.WriteLine("   Welcome !!!!");
        }

        static void nice()
        {
            Console.Write(" Have a nice day.");
        }
    }
}
