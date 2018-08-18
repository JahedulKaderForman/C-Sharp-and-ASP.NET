using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string fatherName;
        string motherName;
        string address;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            textBoxFirstName.Text = "";
            lastName = textBoxLastName.Text;
            textBoxLastName.Text = "";
            fatherName = textBoxFather.Text;
            textBoxFather.Text = "";
            motherName = textBoxMotherName.Text;
            textBoxMotherName.Text = "";
            address = textBoxAddress.Text;
            textBoxAddress.Text = "";

        }

        private void showInfoClick(object sender, EventArgs e)
        {
           textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
            textBoxFather.Text = fatherName;
            textBoxMotherName.Text = motherName;
            textBoxAddress.Text = address;
        }

        private void nameButtonClick(object sender, EventArgs e)
        {
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
            textBoxFather.Text = "";
            textBoxMotherName.Text = "";
            textBoxAddress.Text = "";
        }

        private void parentNameClick(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = lastName;
            textBoxFather.Text = fatherName;
            textBoxMotherName.Text = "";
            textBoxAddress.Text = "";
        }

        private void addressClick(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxFather.Text = "";
            textBoxMotherName.Text = "";
            textBoxAddress.Text = address;
        }
    }
}
