using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            Console.Write("Enter decimal value-1 : ");
            decimal b1 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter decimal value-2 : ");
            decimal b2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"b1 : {b1}\tb2 : {b2}");

            Console.WriteLine($"Sum : {b1 + b2}");
            Console.WriteLine($"Sub : {b1 - b2}");
            Console.WriteLine($"Mul : {b1 * b2}");
            Console.WriteLine($"Div : {b1 / b2}");
            Console.WriteLine($"Rem : {b1 % b2}");
        }
    }
}
