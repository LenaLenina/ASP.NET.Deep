using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlSamples
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void TestButton_Click(object sender, EventArgs e)
        {
            TestTextBox.Text = "Hello User Control!";
        }
    }
}