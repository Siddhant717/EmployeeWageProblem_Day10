using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empwageBuilder = new EmpWageBuilderArray();
            empwageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empwageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empwageBuilder.computeEmpWage();
        }
    }
}
