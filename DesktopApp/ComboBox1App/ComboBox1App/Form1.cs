using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton(object sender, EventArgs e)
        {
            
            if (comboBox.SelectedItem.ToString() == "IIUC")
            {
                labelText.Text = "Internation Islamic University Chittagong - " + comboBox.SelectedItem.ToString();
                labelText.ForeColor = Color.Green;
                
            }
            else if (comboBox.SelectedItem.ToString() == "KEUT")
            {
                labelText.Text = "Khulna University";
            }
            else if (comboBox.SelectedItem.ToString() == "CUET")
            {
                labelText.Text = "Chittagong Engineering University";
            }
            else if (comboBox.SelectedItem.ToString() == "DU")
            {
                labelText.Text = "Dhaka University";
            }
            else if (comboBox.SelectedItem.ToString() == "CU")
            {
                labelText.Text = "Chittagong University";
            }
           
        }
    }
}
