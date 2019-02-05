using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_UserControlDataBound
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Person p = new Person();
            p.A = "Иван";
            p.B = "Иванов";
            p.C = "Иванович";
            UserControlDataBounded1.DataItem = p;
            UserControlDataBounded1.DataBind();
        }
    }
}