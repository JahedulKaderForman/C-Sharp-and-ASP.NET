using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppExamBitm.DAL;
using WebAppExamBitm.Model;

namespace WebAppExamBitm.BLL
{
    public class SearchManger
    {
        SearchGateWay searchgateway = new SearchGateWay();
        public List<Course> getAllCourse()
        {
            return searchgateway.GetAllCourse();
        }

        public List<Course> SearchByCode(string code)
        {
            return searchgateway.SearchByCode(code);
        }
        public List<Course> SearchByCourseName(string coursename)
        {
            return searchgateway.SearchByName(coursename);
        }
    }
}