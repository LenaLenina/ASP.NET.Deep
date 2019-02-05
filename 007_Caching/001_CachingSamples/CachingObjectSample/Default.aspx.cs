using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingObjectSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h2>Customers</h2>");
            List<string> customers = MyCache.Customers;
            foreach (string customer in customers)
            {
                Response.Write(customer + "<br />");
            }

            Response.Write("<hr />");
            Response.Write("<h2>Countries</h2>");

            List<string> countries = MyCache.Countries;
            foreach (string country in countries)
            {
                Response.Write(country + "<br />");
            }
        }
    }
}