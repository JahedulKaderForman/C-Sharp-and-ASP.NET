using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citizanEmploymentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void addButton(object sender, EventArgs e)

        {

            ListViewItem item = new ListViewItem(comboBox.SelectedItem.ToString());
            if (radioButtonDoctorr.Checked)
            {
                item.SubItems.Add(radioButtonDoctorr.Text);
            }
            else if (radioButtonTeacher.Checked)
            {
                item.SubItems.Add(radioButtonTeacher.Text);
            }
            else
            {
                item.SubItems.Add(radioButtonStudent.Text);
            }
            listView1.Items.Add(item);

        }
    }
}
