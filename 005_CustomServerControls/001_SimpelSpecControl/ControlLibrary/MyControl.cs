using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace ControlLibrary
{
    public class MyControl : Control
    {
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.Render(writer);
            
            writer.Write("Hello I'm Specialized Control!");
        }
    }
}
