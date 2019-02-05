using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MembershipProviderSample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void LogInButton_Click(object sender, EventArgs e)
        {
            // Проверка наличия пользователя с указанным логином и паролем в базе данных.
            bool isUserValid = Membership.ValidateUser(UserNameTextBox.Text, PasswordTextBox.Text);
            if (isUserValid)
            {
                // Добавление в cookies маркер и перенаправление на предыдущую страницу.
                FormsAuthentication.RedirectFromLoginPage(UserNameTextBox.Text, false);
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

    }
}