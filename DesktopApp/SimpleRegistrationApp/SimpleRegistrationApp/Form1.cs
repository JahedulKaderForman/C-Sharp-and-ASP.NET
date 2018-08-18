using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logInClick(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Forman" && textBoxpassword.Text=="12345")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Password Or username is wrong", "Warning", MessageBoxButtons.OKCancel);
            }
        }
    }
}
