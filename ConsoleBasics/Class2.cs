using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Console.WriteLine(sizeof(byte));   // 1 byte
            Console.WriteLine(sizeof(sbyte));   // 1 byte
            Console.WriteLine(sizeof(short));  // 2 bytes
            Console.WriteLine(sizeof(int));   // 4 bytes
            Console.WriteLine(sizeof(long));  // 8 bytess
            Console.WriteLine(sizeof(float)); // 4 bytes
            Console.WriteLine(sizeof(double));// 8 bytes
            Console.WriteLine(sizeof(decimal));// 16 bytes
            Console.WriteLine(sizeof(bool)); // 1 byte
            Console.WriteLine(sizeof(char)); // 2bytes
        }
    }
}
