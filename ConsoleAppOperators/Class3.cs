using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            Console.Write("Enter int value-1 : ");
            int b1 = byte.Parse(Console.ReadLine());

            Console.Write("Enter int value-2 : ");
            int b2 = byte.Parse(Console.ReadLine());

            Console.WriteLine($"b1 : {b1}\tb2 : {b2}");

            Console.WriteLine($"Sum : {b1 + b2}");
            Console.WriteLine($"Sub : {b1 - b2}");
            Console.WriteLine($"Mul : {b1 * b2}");
            Console.WriteLine($"Div : {b1 / b2}");
            Console.WriteLine($"Rem : {b1 % b2}");

        }
    }
}
