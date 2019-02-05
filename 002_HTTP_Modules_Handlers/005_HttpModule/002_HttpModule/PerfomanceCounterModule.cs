using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace _002_HttpModule
{
    public class PerfomanceCounterModule : IHttpModule
    {
        private Stopwatch sw;

        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
            context.EndRequest += context_EndRequest;
        }
        
        void context_BeginRequest(object sender, EventArgs e)
        {
            sw = Stopwatch.StartNew();
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            sw.Stop();
            HttpApplication app = (HttpApplication)sender;
            app.Response.Write(@"----------------------------------------------------------------------<br/>
            Время потраченное на обработку запроса " + sw.Elapsed);
        }
    }
}