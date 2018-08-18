using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonNameViewstate
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
           
            if (ViewState["personVs"] == null)
            {
                List<Person> personlist = new List<Person>();
                Person aperson = new Person();
                aperson.firstName = TextBoxFirstName.Text;
                aperson.middleName = TextBoxMiddle.Text;
                aperson.lastName = TextBoxLastName.Text;
                personlist.Add(aperson);
                ViewState["personVs"] = personlist;
                TextBoxFirstName.Text = "";
                TextBoxMiddle.Text = "";
                TextBoxLastName.Text = "";


            }
            else
            {
                List<Person> persons = (List<Person>)ViewState["personVs"];
                Person aperson = new Person();
                aperson.firstName = TextBoxFirstName.Text;
                aperson.middleName = TextBoxMiddle.Text;
                aperson.lastName = TextBoxLastName.Text;
                persons.Add(aperson);
                ViewState["personVs"] = persons;
                TextBoxFirstName.Text = "";
                TextBoxMiddle.Text = "";
                TextBoxLastName.Text = "";

            }

        }

        protected void showButtonClick(object sender, EventArgs e)
        {
            List<Person> persons = (List<Person>)ViewState["personVs"];
            ListBoxshow.Items.Clear();
            foreach(Person item in persons)
            {
                ListBoxshow.Items.Add(item.firstName);
                ListBoxshow.Items.Add(item.middleName);
                ListBoxshow.Items.Add(item.lastName);
                
                 

            }
        }
    }
}