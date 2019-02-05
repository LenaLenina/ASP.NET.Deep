using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MembershipProviderSample
{
    public partial class Register : System.Web.UI.Page
    {
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    // Создание нового пользователя
                    Membership.CreateUser(UserNameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);
                }
                catch (Exception ex)
                {
                    LabelMessage.Text = ex.Message;
                    LabelMessage.ForeColor = Color.Red;
                    return;
                }

                LabelMessage.Text = "Пользователь успешно зарегистрирован.";
                RegisterButton.Enabled = false;
            }
        }
    }
}
