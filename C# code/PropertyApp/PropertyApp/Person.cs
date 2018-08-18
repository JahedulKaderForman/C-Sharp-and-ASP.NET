using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public string LastName { get; set; }


        public string Firstname
        {
            
            get
            {
                return firstName;
            }
            set
            {
                if(value.Length>1)
                firstName = value;
            }
        }

        public string Middlename
        {
            set
            {
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }

        public string Lastname
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }



        //public void setFistName(string firstName)
        //{
        //    this.firstName = firstName;
        //}
        //public string getFirstName()
        //{
        //    return firstName;
        //}

        //public void setMiddleName(string middleName)
        //{
        //    this.middleName = middleName;
        //}
        //public string getMiddleName()
        //{
        //    return middleName;
        //}

        //public void setLastName(string lastName)
        //{
        //    this.lastName = lastName;
        //}
        //public string getLastName()
        //{
        //    return lastName;
        //}


        public string getFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}
