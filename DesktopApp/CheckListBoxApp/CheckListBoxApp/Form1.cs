using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Here we add the check list for selecting
            checkedListBox.Items.Add("Dhaka");
            checkedListBox.Items.Add("Chittagong");
            checkedListBox.Items.Add("Khulna");
            checkedListBox.Items.Add("Brisal");
            checkedListBox.Items.Add("Cox's Bazar");

        }
        private void AddButtonList(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            //Iterate for adding item which is checked
            foreach (string s in checkedListBox.CheckedItems)
            {
                listBox.Items.Add(s);
            }

        }
    }
}
