using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine()); // num1 = 5

            Console.Write("Enter num2 : ");  // num2 = 2
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 > num2);// True
            Console.WriteLine(num1 >= num2); //
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine($"num1>num2 : {num1 > num2}");//
            Console.WriteLine($"num1>=num2 : {num1 >= num2}");//
            Console.WriteLine($"num1<num2 : {num1 < num2}");//
            Console.WriteLine($"num1<=num2 : {num1 <= num2}");//
            Console.WriteLine($"num1==num2 : {num1 == num2}");//
            Console.WriteLine($"num1!=num2 : {num1 != num2}");//
            Console.WriteLine($"num1>num2 : {num1>num2} num1>=num2 : {num1>=num2}  num1<=num2 {num1<num2}");
            Console.WriteLine($"{num1}>{num2} : {num1>num2} {num1}>={num2} : {num1>=num2}  {num1}<={num2} {num1<num2}");
        }
    }
}
