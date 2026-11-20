using System;


namespace ConsoleBasics
{
    internal class Class8
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter Father Name : ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Mother Name : ");
            string mname = Console.ReadLine();

            Console.WriteLine("Enter Your Location : ");
            string loc = Console.ReadLine();

            Console.WriteLine($"Name : {name}\tFather Name : {fname}\tMother Name : {mname}\tLocation : {loc}");
            
        }
    }
}
