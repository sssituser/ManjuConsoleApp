using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            Console.Write("Enter  float value 1 : ");
            float f1 =float.Parse(Console.ReadLine());

            Console.Write("Enter  float value 2 : ");
            float f2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is : {f1+f2}");

        }
    }
}
