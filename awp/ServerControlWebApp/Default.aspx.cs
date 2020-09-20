using System;
using System.Web.UI;

namespace ServerControlWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "You have selected : " + Fruits.SelectedItem.Text;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');",
           true);
        }
    }
}