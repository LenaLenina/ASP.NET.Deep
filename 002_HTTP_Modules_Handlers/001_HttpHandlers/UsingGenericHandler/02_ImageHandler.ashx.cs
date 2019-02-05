using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsingGenericHandler
{
    /// <summary>
    /// Summary description for _02_ImageHandler
    /// </summary>
    public class _02_ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string path = context.Server.MapPath("logo.jpg");
            context.Response.ContentType = "image/jpg";
            context.Response.WriteFile(path);
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