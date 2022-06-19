using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHr;
        private int NumberOfWorkingDays;
        private int MaxHoursPerMonth;
        

        public EmpWage(string company, int empRatePerHr, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.NumberOfWorkingDays = numberOfWorkingDays;
            this.MaxHoursPerMonth = maxHoursPerMonth;

        }

        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            while (totalEmpHours <= this.MaxHoursPerMonth && totalWorkingDays <= this.NumberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHours += empHrs;
               
                totalEmpWage = totalEmpHours * this.empRatePerHr;

            }
           
            Console.WriteLine("Total Emp Wage for Company " + company + "is " + totalEmpWage);

            
        }

       
    }
}