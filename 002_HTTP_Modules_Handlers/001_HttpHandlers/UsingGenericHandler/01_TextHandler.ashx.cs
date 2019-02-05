using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsingGenericHandler
{
    /// <summary>
    /// Summary description for _01_TextHandler
    /// </summary>
    public class _01_TextHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            // Определение типа ответа 
            context.Response.ContentType = "text/plain";
            // Формирование ответа
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}