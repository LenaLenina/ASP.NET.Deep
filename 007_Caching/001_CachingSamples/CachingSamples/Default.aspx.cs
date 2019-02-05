using System;

namespace CachingSamples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void AddButton_Click(object sender, EventArgs e)
        {
            // Запись значения в кэш.
            Cache["MyData"] = DateTime.Now;
        }

        protected void ReadButton_Click(object sender, EventArgs e)
        {
            // Чтение данных из кэша.
            object data = Cache["MyData"];
            
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