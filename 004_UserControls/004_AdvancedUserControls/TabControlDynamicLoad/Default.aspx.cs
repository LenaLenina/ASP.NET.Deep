using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TabControl control = LoadControl("UserControls/TabControl.ascx") as TabControl;
        control.SelectedTabBackColor = Color.Gray;
        control.Tabs.Add("Products");
        control.Tabs.Add("Services");
        control.Tabs.Add("About");
        ControlPlaceHolder.Controls.Add(control);
    }
}

