using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticationSample
{
    public partial class Login : System.Web.UI.Page
    {

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = string.Empty;

            if (LoginTextBox.Text == "admin" &&
                PasswordTextBox.Text == "12345")
            {
                FormsAuthentication.RedirectFromLoginPage(LoginTextBox.Text, true);
            }
            else
            {
                MessageLabel.Text = "Логин или пароль введены не правильно";
            }
        }
    }
}