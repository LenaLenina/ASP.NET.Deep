using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TabControlTest.Tabs.Add("Home");
        TabControlTest.Tabs.Add("Services");
        TabControlTest.Tabs.Add("Products");
        TabControlTest.Tabs.Add("Contact");
        TabControlTest.Tabs.Add("About");
    }

    protected void TabControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        LabelMsg.Text = "Selected tab position " + e.Position;
    }
}