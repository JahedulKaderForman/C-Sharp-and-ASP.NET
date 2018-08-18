using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameInArrayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();

        private void showAllClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string item in list)
            {
              
                listBox1.Items.Add(item);
            }
            textBoxCount.Text = list.Count.ToString();
            
        }

        private void SavebuttonClick(object sender, EventArgs e)
        {
            list.Add(textBoxInput.Text);
            textBoxInput.Text = "";
            listBox1.Items.Clear();
            textBoxCount.Text = "";

        }
    }
}
