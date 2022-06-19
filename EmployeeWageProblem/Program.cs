using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWage reliance = new EmpWage("Reliance", 20, 2, 10);
            reliance.computeEmpWage();
           
            EmpWage Dmart = new EmpWage("Dmart", 10, 3, 20);
            Dmart.computeEmpWage();
         
        }
    }
}
