using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageAsyncTasks
{
    // Для того, что бы класс PageAsyncTask работал в 4.5 framework необходимо добавить следующий фрагмент кода в файл web.config

    // <appSettings>
    //       <add key="aspnet:UseTaskFriendlySynchronizationContext" value="false" />
    // </appSettings>

    public partial class Default : System.Web.UI.Page
    {
        private WebRequest _request = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("Thread = " + Thread.CurrentThread.ManagedThreadId.ToString(), "-> AddOnPreRenderCompleteAsync in Page_Load");

            // Асинхронная задача для данной страницы.
            PageAsyncTask task = new PageAsyncTask(
                OnBegin,   // Начало асинхронной операции.
                OnEnd,     // Завершение асинхронной операции.
                OnTimeOut, // Действие в случае если вышло время ожидания указанное в атрибуте AsyncTimeout директивы @ Page.
                null       // Значение для аргумента extraData метода OnBegin.
                );

            // Регистрация задачи. По умолчанию, вызов задачи происходит после события PreRender.
            RegisterAsyncTask(task);
        }

        private IAsyncResult OnBegin(object sender, EventArgs e, AsyncCallback cb, object extraData)
        {
            Trace.Write("Thread = " + Thread.CurrentThread.ManagedThreadId.ToString(), "-> BeginAsyncOperation");

            _request = WebRequest.Create("http://msdn.microsoft.com/");
            return _request.BeginGetResponse(cb, extraData); // Асинхронный запрос к удаленному ресурсу. 
        }

        private void OnEnd(IAsyncResult ar)
        {
            Trace.Write("Thread = " + Thread.CurrentThread.ManagedThreadId.ToString(), "-> EndAsyncOperation");

            string text;
            using (WebResponse response = _request.EndGetResponse(ar))
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    text = reader.ReadToEnd();
                }
            }

            Regex regex = new Regex("href=\"(\\S*)\"");
            MatchCollection collection = regex.Matches(text);

            StringBuilder builder = new StringBuilder();
            foreach (Match match in collection)
            {
                builder.Append(match.Groups[1]);
                builder.Append("<br />");
            }

            OutputLabel.Text += builder.ToString();
        }

        private void OnTimeOut(IAsyncResult ar)
        {
            OutputLabel.Text = "Превышено время ожидания ответа.";
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Trace.Write("Thread = " + Thread.CurrentThread.ManagedThreadId.ToString(), "-> PreRenderComplete");
        }
    }
}