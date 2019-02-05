using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_UserControlSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Calculator1_OnError(object sender, ErrorEventArgs e)
        {
            ErrorLabel.Text = "Ошибка на странице! " + e.ErrorMessage;
        }
    }
}