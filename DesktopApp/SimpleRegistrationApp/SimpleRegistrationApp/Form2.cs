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
    public partial class Form2 : Form
    {
       
        string ID;
        string Name;
        string Roll;
        string gender;
        string division;
        string course;

        public Form2()
        {
            InitializeComponent();
            listViewInfo.View = View.Details;
            listViewInfo.FullRowSelect = true;

        }

        private void AddClick(object sender, EventArgs e)
        {
            ID = textBoxID.Text;
            Name = textBoxName.Text;
            Roll=textBoxRoll.Text;


            if (radioButtonFemale.Checked)
            {
                gender = radioButtonFemale.Text;
            }
            else
            {
                gender = radioButtonMale.Text;
            }

            
                division = comboBoxDivision.SelectedItem.ToString();
            
            if (checkBoxCsharp.Checked)
            {
                course += checkBoxCsharp.Text+" ";
            }
            else if (checkBoxJava.Checked)
            {
                course += checkBoxJava.Text + " ";
            }
            else
            {
                course += checkBoxpython.Text + " ";
            }



            if (ID!="" && Name!="" && Roll!="" && gender!="" && course!="" && division!="")
                 
            {
                

                ListViewItem list = new ListViewItem(ID);
                list.SubItems.Add(Name);
                list.SubItems.Add(Roll);
                list.SubItems.Add(gender);
                list.SubItems.Add(division);
                list.SubItems.Add(course);
                listViewInfo.Items.Add(list);



                MessageBox.Show("data is Added");
                
            }       
            else
            {

                MessageBox.Show("data is invalid");
            }

        }

        private void UpdateButton(object sender, EventArgs e)
        {
            listViewInfo.SelectedItems[0].SubItems[0].Text = textBoxID.Text;
            listViewInfo.SelectedItems[0].SubItems[1].Text = textBoxName.Text;
            listViewInfo.SelectedItems[0].SubItems[2].Text = textBoxRoll.Text;
        }

        private void Remove(object sender, EventArgs e)
        {

            listViewInfo.Items.RemoveAt(listViewInfo.SelectedIndices[0]);
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = listViewInfo.SelectedItems[0].SubItems[0].Text ;
            textBoxName.Text = listViewInfo.SelectedItems[0].SubItems[1].Text;
            textBoxRoll.Text = listViewInfo.SelectedItems[0].SubItems[2].Text;
        }

        private void ClearButton(object sender, EventArgs e)
        {
            listViewInfo.Items.Clear();
        }
    }
}
