using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            Console.Write("Enter  number1 : ");
            string num1 = Console.ReadLine();

            Console.Write("Enter  number2 : ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"Sum is : {num1+num2}");
        }
    }
}
