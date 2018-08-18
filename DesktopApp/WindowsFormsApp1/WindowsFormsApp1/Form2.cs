using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Hashtable hash = new Hashtable();
        public Form2()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            hash.Add(textBoxInfoID.Text, textBoxDetails.Text);
            textBoxInfoID.Text = "";
            textBoxDetails.Text = "";

        }

        private void FindButtonClick(object sender, EventArgs e)
        {
            string id = textBoxSearchID.Text;
            textBoxSearchID.Text = "";
            textBoxSearchDetails.Text = hash[id].ToString();
        }
    }
}
