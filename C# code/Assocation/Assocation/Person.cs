using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assocation
{
    class Person
    {
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string lastName { set; get; }
        public Address address { get; set; }
        public Person()
        {
            address = new Address();
        }
    }
}
