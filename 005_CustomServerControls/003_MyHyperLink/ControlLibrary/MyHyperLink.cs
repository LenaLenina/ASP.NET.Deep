using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ControlLibrary
{
    public class MyHyperLink : HyperLink
    {
        // Замещаем свойство NavigateUrl из базового класса HyperLink
        public new string NavigateUrl
        {
            get
            {
                return base.NavigateUrl;
            }
            set
            {
                base.NavigateUrl = value + "?test=value";
            }
        }
    }
}
