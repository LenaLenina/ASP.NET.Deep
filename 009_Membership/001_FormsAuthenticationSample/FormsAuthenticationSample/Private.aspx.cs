using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticationSample
{
    public partial class Private : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // При отсутствии маркера запрос считается не аутентифицированным.
            if (!Request.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}