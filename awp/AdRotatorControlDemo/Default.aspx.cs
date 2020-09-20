using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdRotatorControlDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {
            Label1.Text = e.AdProperties["ImageUrl"].ToString();
            Label1.Visible = false;
            AdRotator1.Visible = true;
        }
    }
}