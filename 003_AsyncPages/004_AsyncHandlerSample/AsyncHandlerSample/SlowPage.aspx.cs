using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncHandlerSample
{
    public partial class SlowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Write("SlowResponse Thread Id " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}