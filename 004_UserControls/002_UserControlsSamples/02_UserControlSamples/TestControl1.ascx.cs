using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_UserControlSamples
{
    public partial class TestControl1 : System.Web.UI.UserControl
    {
        public string Text { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            OutputLiteral.Text = Text;
        }
    }
}