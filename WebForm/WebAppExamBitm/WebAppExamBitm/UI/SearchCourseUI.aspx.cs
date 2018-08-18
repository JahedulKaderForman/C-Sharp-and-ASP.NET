using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppExamBitm.BLL;

namespace WebAppExamBitm.UI
{
    public partial class SearchCourseUI : System.Web.UI.Page
    {
        SearchManger searchmanger = new SearchManger();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadCategory();
            } 
        }
        public void LoadCategory()
        {
            GridViewCourse.DataSource = searchmanger.getAllCourse();
            GridViewCourse.DataBind();
        }

        protected void SearchButtonClick(object sender, EventArgs e)
        {
            if (searchByCode.Checked)
            {
               
              string code=  TextBoxSearch.Text;

              GridViewCourse.DataSource = searchmanger.SearchByCode(code);
              GridViewCourse.DataBind();
            }
            else if (SearchByName.Checked)
            {
                
                string CourseName = TextBoxSearch.Text;
                GridViewCourse.DataSource = searchmanger.SearchByCode(CourseName);
                GridViewCourse.DataBind();
            }
        }
       
    }
}