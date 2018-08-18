using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItemPriceViewState
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButtonClick(object sender, EventArgs e)
        {
            int item = Convert.ToInt32(TextBoxItem.Text);
            int unitPrice = Convert.ToInt32(TextBoxPrice.Text);
            int result = item * unitPrice;
            ViewState["TotalPrice"] = result.ToString();
            TextBoxItem.Text = "";
            TextBoxPrice.Text = "";
        }

        protected void showButtonClick(object sender, EventArgs e)
        {
            TotalPrice.Text = ViewState["TotalPrice"].ToString();
        }
    }
}