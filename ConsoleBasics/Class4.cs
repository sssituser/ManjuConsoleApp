using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Console.WriteLine($"Byte\tMinimum Value:{byte.MinValue}\t\tMaxValue:{byte.MaxValue}");
            Console.WriteLine($"SByte\tMinimum Value:{sbyte.MinValue}\tMaxValue:{sbyte.MaxValue}");
            Console.WriteLine($"int\tMinimum Value:{int.MinValue}\tMaxValue:{int.MaxValue}");
            Console.WriteLine($"uint\tMinimum Value:{uint.MinValue}\tMaxValue:{uint.MaxValue}");
            Console.WriteLine($"long\tMinimum Value:{long.MinValue}\tMaxValue:{long.MaxValue}");
        }
    }
}
