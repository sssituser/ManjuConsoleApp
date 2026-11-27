using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            Console.Write("Enter boolean value : ");
            bool c1 = bool.Parse(Console.ReadLine());

            Console.Write("Enter boolean value : ");
            bool c2 = bool.Parse(Console.ReadLine());

            Console.WriteLine("&&-Operator\t\t||--Operator ");
            Console.WriteLine($"{c1}&&{c2}:{c1 && c2}\t{c1}||{c2}:{c1 || c2} ");


        }
    }
}
