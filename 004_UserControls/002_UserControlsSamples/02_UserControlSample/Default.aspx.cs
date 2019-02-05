using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsSamples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Calculator1_OnError(object sender, EventArgs e)
        {
            ErrorLabel.Text = "Ошибка на странице!";
        }
    }
}