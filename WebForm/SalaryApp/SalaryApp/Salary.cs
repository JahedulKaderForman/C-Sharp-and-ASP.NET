using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryApp
{
    public class Salary
    {
        public double basicSalary;
        public double medicalAllowancePercentage;
        public double houseRentAllowancePercentage;

        public double CalculatSalary()
        {
            double medicalSalary = basicSalary * (medicalAllowancePercentage / 100);
            double houseeSalary = basicSalary * (houseRentAllowancePercentage / 100);
            double total= basicSalary + medicalSalary + houseeSalary;

            return total;
        }

    }
}