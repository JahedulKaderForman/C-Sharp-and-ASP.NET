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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            
            int number = Convert.ToInt32(textBox.Text);
            listBox1.Items.Clear();
            for (int i = 1; i <=10; i++)
            {
                
                listBox1.Items.Add(i+"X"+number+"="+(number * i));
            }
        }
    }
}
