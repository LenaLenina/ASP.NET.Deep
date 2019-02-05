using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.IO;

namespace _2_CachingSamples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void AddButton_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("data.txt");
            Cache.Insert("MyData",              // ключ.
                File.ReadAllText(file),         // данные для кэширования.
                new CacheDependency(file));     // зависимость указывающая, что запись в кэше удаляется при изменении файла.
        }

        protected void ReadButton_Click(object sender, EventArgs e)
        {
            // Чтение данных из кэша.
            object data = Cache.Get("MyData");

            if (data != null)
            {
                string message = string.Format("Data: {0}, Type: {1}", data, data.GetType());
                MessageLabel.Text = message;
            }
            else
            {
                MessageLabel.Text = "Cache is empty.";
            }
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            // Удаление объекта из кэша.
            object data = Cache.Remove("MyData");
            if (data != null)
            {
                MessageLabel.Text = "Removed -- " + data.GetType().ToString();
            }
            else
            {
                MessageLabel.Text = "Cache is empty.";
            }
        }
    }
}