using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators
{
    internal class Class8
    {
        static void Main (string[] args)
        {
            Console.Write("Enter int val-1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter int val-2 : ");
            int num2 = int.Parse(Console.ReadLine());


            Console.Write("Enter int val-3 : ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            int avg = sum / 3;

            Console.WriteLine($"Sum is : {sum}\tAverage : {avg}");
            Console.WriteLine($"Sum is : {num1+num2+num3}\tAverage : {(num1 + num2 + num3)/3}");
        }
    }
}
