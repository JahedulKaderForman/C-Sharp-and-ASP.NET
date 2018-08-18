using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppExamBitm.BLL;
using WebAppExamBitm.Model;

namespace WebAppExamBitm.UI
{
    public partial class CourseInfoUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButtonClick(object sender, EventArgs e)
        {
            Course courseinfo = new Course();
            courseinfo.Code = TextBoxCode.Text;
            courseinfo.CourseName=TextBoxCourseName.Text;
            courseinfo.Description= TextBoxDescription.Text;
         
            double credit =Convert.ToDouble(TextBoxCredit.Text);
            courseinfo.Credit = (float)credit;
            CourseInfoManger courseinfomanger = new CourseInfoManger();
            string message=courseinfomanger.SaveCourse(courseinfo);
            messageLabel.Text = message;

        }
    }
}