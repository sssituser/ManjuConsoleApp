using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // class lib

namespace ConsoleBasics   // application
{
    internal class Class6 // class declartion
    {
        static void Main (string[] args) /// main method
        {
            int EmployeeID = 111;
            string EmployeeName = "Chandu"; // Initilization
            int EmployeeSalary = 50000;



            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Employee Name : {EmployeeName}");
            Console.WriteLine($"Employee Salary : {EmployeeSalary}");
            
        }
    }
}
