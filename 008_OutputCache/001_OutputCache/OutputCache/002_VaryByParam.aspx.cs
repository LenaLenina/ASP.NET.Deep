using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OutputCache
{
    public partial class _002_VaryByParam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parameter = Request.QueryString["ID"];
            string datetime = DateTime.Now.ToLongTimeString();

            string result = string.Format("Страница была помещена в кэш в {0} значение параметра Id = {1}", datetime, parameter);

            MessageLabel.Text = result;
        }
    }
}