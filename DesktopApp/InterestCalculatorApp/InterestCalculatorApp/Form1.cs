using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class Form1 : Form
    {
        double interest;
        double year;
        double balance;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButtonClick(object sender, EventArgs e)
        {

            balance = Double.Parse(textBoxBalance.Text);
            year = Double.Parse(textBoxYear.Text);

            if (comboBoxBank.SelectedItem.ToString()== "BRAC")
            {

                interest = (balance * (6/100.0) * year);
            }
            else if(comboBoxBank.SelectedItem.ToString() == "DBBL")
            {
                interest = (balance * (7/100.0) * year);
            }
            else if (comboBoxBank.SelectedItem.ToString() == "HSBC")
            {
                interest =  (balance * (8/100.0) * year);
            }
            showBalance.Text = interest.ToString()+" tk";
        }
        private double Interest(double r, double n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += (1 + r);
            }
            return result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
