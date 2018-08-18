using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_RadioButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void updateLabelDhaka(object sender, EventArgs e)
        {
            if (checkBoxDhakha.Checked == true)
            {
                cityList.Items.Add(checkBoxDhakha.Text);
            }
            else
            {
                cityList.Items.Clear();
            }
        }

        private void updatelabelChittagong(object sender, EventArgs e)
        {
            if (checkBoxChittagong.Checked == true)
            {
                cityList.Items.Add(checkBoxChittagong.Text);
            }
            else
            {
                cityList.Items.Remove(checkBoxChittagong.Text);
            }

        }

        private void updateLabelCoxbazar(object sender, EventArgs e)
        {
            if (checkBoxCoxBazar.Checked == true)
            {
                cityList.Items.Add(checkBoxCoxBazar.Text);
            }
            else
            {
                cityList.Items.Remove(checkBoxCoxBazar.Text);
            }
        }

        private void colorSubmit(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                panelColor.BackColor = Color.Red;
            }
            else if (radioButtonGreen.Checked)
            {
                panelColor.BackColor = Color.Green;
            }
        }
    }
}
