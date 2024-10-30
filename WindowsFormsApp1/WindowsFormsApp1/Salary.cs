using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Salary
    {

        // Calculate No Pay for an Employee
        public static decimal NoPay(decimal monthSalary, int noofleaves, decimal range, int GivenLeaves)
        {
            if (GivenLeaves < noofleaves)
            {
                decimal nopayValue = (monthSalary / range) * (noofleaves - GivenLeaves);
                return nopayValue;
            }
            else
            {
                decimal nopay = 0;
                return nopay;
            }
        }

        // Calculate Base Pay for an Employee
        public decimal BasePay(decimal monthSalary, decimal allowances, decimal overtimeRate, int OvertimeHours)
        {
          // Calculation logic for Base Pay
          decimal BasePay = monthSalary + allowances + (overtimeRate * OvertimeHours);
          return BasePay;
        }

         // Calculate Gross Pay for an Employee
         public decimal GrossPay(decimal basePay, decimal noPayValue, decimal governmentTaxRate)
         {
           // Calculation logic for Gross Pay
           decimal GrossPay = basePay - (noPayValue + basePay * governmentTaxRate);
           return GrossPay;
         }

    }
}
