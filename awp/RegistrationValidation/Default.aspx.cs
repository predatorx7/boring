using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationValidation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = "Thank you";
            }
            else
            {
                Label1.Text = "The text must be exactly 8 characters Long!";
            }
        }
        void ServerValidation(object source, ServerValidateEventArgs e)
        {
            if (e.Value.Length == 8)
                e.IsValid = true;
            else
                e.IsValid = false;
        }
    }
}