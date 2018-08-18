using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createAccount(object sender, EventArgs e)
        {
            Acccount account = new Acccount();
            account.AccountNumber = TextBoxAccountNo.Text;
            account.CustomerName = TextBoxName.Text;
            ViewState["accountVs"] = account;
            TextBoxAccountNo.Enabled = false;
            TextBoxName.Enabled = false;
            CreatButton.Enabled = false;

        }

        protected void DepositeButton(object sender, EventArgs e)
        {
            Acccount account =(Acccount) ViewState["accountVs"];
            showBalance.Text=account.deposit(Double.Parse(TextBoxAmount.Text));
            ViewState["accountVs"] = account;
        }

        protected void withdrawButton(object sender, EventArgs e)
        {
            Acccount account = (Acccount)ViewState["accountVs"];
            showBalance.Text=account.wirthdraw(Double.Parse(TextBoxAmount.Text));
            ViewState["accountVs"] = account;
        }

        protected void reportButton(object sender, EventArgs e)
        {
            Acccount account = (Acccount)ViewState["accountVs"];
            showBalance.Text=account.report();
            ViewState["accountVs"] = account;
        }
    }
}