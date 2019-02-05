using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ControlLibrary
{
    public class MyPanel : Panel
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            base.RenderContents(writer);
            writer.Write("Пользовательский контент панели");
        }
    }
}
