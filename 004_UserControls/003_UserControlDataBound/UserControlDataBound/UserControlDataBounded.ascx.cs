using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDataBound
{
    public partial class UserControlDataBounded : System.Web.UI.UserControl
    {
        public Person DataItem { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FirstNameLabel.Text = DataItem.FirstName;
            LastNameLabel.Text = DataItem.LastName;
            MiddleNameLabel.Text = DataItem.MiddleName;
        }
    }
}