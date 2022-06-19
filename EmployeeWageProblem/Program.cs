using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWage reliance = new EmpWage("Reliance", 20, 2, 10);
            reliance.computeEmpWage();

            EmpWage Dmart = new EmpWage("Dmart", 10, 4, 20);
            Dmart.computeEmpWage();
        }
    }
}
