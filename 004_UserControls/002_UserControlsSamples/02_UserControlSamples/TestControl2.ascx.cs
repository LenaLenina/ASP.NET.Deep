using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_UserControlSamples
{
    public partial class TestControl2 : System.Web.UI.UserControl
    {
        private const string TextKey = "text_val";

        public string Text
        {
            set { ViewState[TextKey] = value; }
            get
            {
                object data = ViewState[TextKey];
                if (data == null) 
                { 
                    return string.Empty; 
                }
                else
                {
                    return data.ToString();
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            OutputLiteral.Text = Text;
        }
    }
}