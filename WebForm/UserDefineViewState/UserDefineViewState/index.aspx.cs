using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefineViewState
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = TextBoxName.Text;
            student.RegNo = TextBoxRegNo.Text;
            student.email = TextBoxEmail.Text;
            ViewState["Student"] = student;
            TextBoxName.Text = "";
            TextBoxRegNo.Text = "";
            TextBoxEmail.Text = "";

        }

        protected void showButtonClick(object sender, EventArgs e)
        {
            Student student1 = (Student)ViewState["Student"];
            LabelName.Text = student1.Name;
            LabelEmail.Text = student1.email;
            LabelRegNo.Text = student1.RegNo;


        }

       
    }
}