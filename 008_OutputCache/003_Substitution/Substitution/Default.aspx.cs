using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Substitution
{
    public partial class Default : System.Web.UI.Page
    {
        public static string GetDate(HttpContext context)
        {
            string date = DateTime.Now.ToLongTimeString();
            string message = string.Format("<h2>Эта часть страницы обновляется регулярно. Последнее обновление {0}</h2>", date);

            return message;
        }
    }
}
