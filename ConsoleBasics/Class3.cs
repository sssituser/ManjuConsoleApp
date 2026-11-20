using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            Console.WriteLine($"Byte\tOccupies   {sizeof(byte)}    Byte Memory");
            Console.WriteLine($"SByte\tOccupies  {sizeof(sbyte)}    Byte Memory");
            Console.WriteLine($"bool\tOccupies   {sizeof(bool)}    Byte Memory");

            Console.WriteLine($"short\tOccupies  {sizeof(short)}    Bytes Memory");
            Console.WriteLine($"ushort\tOccupies {sizeof(ushort)}    Bytes Memory");
            Console.WriteLine($"char\tOccupies   {sizeof(char)}    Bytes Memory");

            Console.WriteLine($"int\tOccupies    {sizeof(int)}    Bytes Memory");
            Console.WriteLine($"uint\tOccupies   {sizeof(uint)}    Bytes Memory");
            Console.WriteLine($"float\tOccupies  {sizeof(float)}    Bytes Memory");
           
            Console.WriteLine($"long\tOccupies    {sizeof(long)}    Bytes Memory");
            Console.WriteLine($"double\tOccupies  {sizeof(double)}    Bytes Memory");
            Console.WriteLine($"decimal\tOccupies {sizeof(decimal)}    Bytes Memory");
          
        }
    }
}
