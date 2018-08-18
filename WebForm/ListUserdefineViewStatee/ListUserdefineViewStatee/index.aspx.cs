using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListUserdefineViewStatee
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
           
            if (ViewState["studentList"] == null)
            {
                List<Student> studentList = new List<Student>();
                Student student = new Student();
                student.Name = TextBoxName.Text;
                student.RegNo = TextBoxRegNo.Text;
                student.email = TextBoxEmail.Text;
                studentList.Add(student);
                ViewState["studentList"] = studentList;
                TextBoxName.Text = "";
                TextBoxRegNo.Text = "";
                TextBoxEmail.Text = "";
            }
            else
            {
                List<Student> studentList2 = (List<Student>)ViewState["studentList"];
                Student student = new Student();
                student.Name = TextBoxName.Text;
                student.RegNo = TextBoxRegNo.Text;
                student.email = TextBoxEmail.Text;
                studentList2.Add(student);
                ViewState["studentList"] = studentList2;
                TextBoxName.Text = "";
                TextBoxRegNo.Text = "";
                TextBoxEmail.Text = "";

            }
           
           
            

        }

        protected void showButtonClick(object sender, EventArgs e)
        {
            ListBoxshow.Items.Clear();
            List<Student> studentList2 = (List<Student>)ViewState["studentList"];
            foreach (Student item in studentList2)
            {
                ListBoxshow.Items.Add(item.Name);
                ListBoxshow.Items.Add(item.RegNo);
                ListBoxshow.Items.Add(item.email);
                
            }


        }
    }
}