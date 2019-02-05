using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

namespace _3_AbsoluteExpirationTime
{
    public partial class Default : System.Web.UI.Page
    {
        protected void AddButton_Click(object sender, EventArgs e)
        {
            Cache.Insert("MyData",              // ключ.
                DateTime.Now,                   // данные для кэширования.
                null,                           // зависимость не указана.
                DateTime.Now.AddSeconds(5),     // запись должна быть удалена через 5 секунд.
                Cache.NoSlidingExpiration);     // время скользящего устаревания не указано.
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