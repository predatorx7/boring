using System;

namespace UserCtrlDemo
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtSave_Click(object sender, EventArgs e)
        {
            {
                Label1.Text = "Your Name is " + txtName.Text;
                Label2.Text = "Your age is " + TextBox1.Text;
                Label3.Text = "You are from " + txtcity.Text;
            }
        }
        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void txtcity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}