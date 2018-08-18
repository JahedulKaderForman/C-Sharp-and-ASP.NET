using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExamBitm.Model
{
    public class Course
    {
        public string Code { set; get; }
        public string CourseName { set; get; }
        public string Description { set; get; }

        public double Credit { set; get; }
    }
}