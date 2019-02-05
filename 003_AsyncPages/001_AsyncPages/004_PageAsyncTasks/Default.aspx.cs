using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_PageAsyncTasks
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SlowTask slowTask1 = new SlowTask();
            SlowTask slowTask2 = new SlowTask();
            SlowTask slowTask3 = new SlowTask();

            // Последний параметр:
            // true - задачи выполняются параллельно.
            // false - задачи выполняются последовательно.
            PageAsyncTask task1 = new PageAsyncTask(slowTask1.OnBegin, slowTask1.OnEnd, slowTask1.OnTimeOut, null, false);
            PageAsyncTask task2 = new PageAsyncTask(slowTask2.OnBegin, slowTask2.OnEnd, slowTask2.OnTimeOut, null, false);
            PageAsyncTask task3 = new PageAsyncTask(slowTask3.OnBegin, slowTask3.OnEnd, slowTask3.OnTimeOut, null, false);

            RegisterAsyncTask(task1);
            RegisterAsyncTask(task2);
            RegisterAsyncTask(task3);

            // Запуск асинхронных операций на выполнение. 
            Page.ExecuteRegisteredAsyncTasks();

            OutputLabel.Text = slowTask1.GetData() + "<br />" + slowTask2.GetData() + "<br />" + slowTask3.GetData();
        }
    }
}