﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlPostBack
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ClickablePanel1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = DateTime.Now.ToString();
        }
    }
}