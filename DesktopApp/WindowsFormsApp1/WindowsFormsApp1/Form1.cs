using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButtinClick(object sender, EventArgs e)
        {
            list.Add(Convert.ToInt32(textBoxInput.Text));
            textBoxInput.Text = "";

        }

        private void showAllButton(object sender, EventArgs e)
        {
            listBoxNumber.Items.Clear();
            list.Sort();
            int result = 0;
            foreach (int item in list)
            {
                listBoxNumber.Items.Add(item);
                result += item;
            }
            textBoxSum.Text = result.ToString();

        }
    }
}
