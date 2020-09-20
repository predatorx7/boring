using System;
using System.Web.UI;

namespace ViewStateDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = " Hi, This the View State Demo";
                if (ViewState["name"] == null)
                {
                    ViewState["name"] = str;
                }
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ViewState["name"].ToString();
        }
    }
}