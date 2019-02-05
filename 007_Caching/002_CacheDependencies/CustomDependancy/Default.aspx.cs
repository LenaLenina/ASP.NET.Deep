using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomDependancy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object data = Cache["XmlFile"];
            MessageLabel.Text = "Data from cache -- " + (data != null ? data.ToString() : "No data in cache.");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("file.xml");
            // Путь к данным в XML документе.
            string xPathExpression = "TestData/Person/FirstName";
            // Создание объекта пользовательской зависимости.
            XmlDataCacheDependency dependency = new XmlDataCacheDependency(file, xPathExpression, 1);
            Cache.Insert("XmlFile", dependency.CurrentValue, dependency);
        }
    }
}