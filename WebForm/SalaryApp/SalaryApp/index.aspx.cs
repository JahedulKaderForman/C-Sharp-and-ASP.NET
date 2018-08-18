using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButtonClick(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.basicSalary = Double.Parse(TextBoxBasic.Text);
            salary.medicalAllowancePercentage = Double.Parse(TextBoxMedical.Text);
            salary.houseRentAllowancePercentage = Double.Parse(TextBoxHouse.Text);
            double total = salary.CalculatSalary();
            showSalary.Text = total.ToString();



        }
    }
}