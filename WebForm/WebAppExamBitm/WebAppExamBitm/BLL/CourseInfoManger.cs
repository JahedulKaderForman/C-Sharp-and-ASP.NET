using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppExamBitm.DAL;
using WebAppExamBitm.Model;

namespace WebAppExamBitm.BLL
{
    public class CourseInfoManger
    {
        public string SaveCourse(Course coursinfo)
        {
            CourseInfoGateWay courseinfoGateway = new CourseInfoGateWay();
            bool isExcited = courseinfoGateway.IsExited(coursinfo);

            if (coursinfo.Code.Length > 5)
            {
                return "Length is Greter Than 5";
            }

            else if (coursinfo.Credit < 0.5 || coursinfo.Credit > 5.0)
            {
                return "Credit Must be greter then 0.5 and less then 5.0";
            }
            else if (isExcited == true)
            {
                return "Course Code Alreay Excited";
            }
            else
            {

                int row = courseinfoGateway.SaveCourse(coursinfo);
                if (row > 0)
                {
                    return "Successfully Save";
                }
                else
                {
                    return "Failed Save";
                }
            }
        }
    }
}