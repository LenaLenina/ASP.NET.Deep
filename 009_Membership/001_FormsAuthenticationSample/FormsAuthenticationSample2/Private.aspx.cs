using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticationSample2
{
    public partial class Private : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                // FormsIdentity - представляет пользователя аутентифицированного через FormsAuthentication.
                // Page.User - информация о пользователе, который делает данный запрос.
                FormsIdentity identity = User.Identity as FormsIdentity;

                if (identity != null)
                {
                    FormsAuthenticationTicket ticket = identity.Ticket;
                    string customData = ticket.UserData;
                    LabelMessage.Text = customData;
                }
            }
            else
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}