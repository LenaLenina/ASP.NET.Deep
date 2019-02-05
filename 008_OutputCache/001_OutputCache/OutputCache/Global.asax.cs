using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OutputCache
{
    public class Global : System.Web.HttpApplication
    {
        // Данный метод вызывается для того, чтобы получить ключ, который будет использоваться для кэширования результата текущего запроса.
        // На каждое значение возвращаемое данным методом будет создана запись в кэш, если кэш уже содержит запись по ключу то будет использоваться кэшированное значение.
        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom == "device")
            {
                // В качестве ключа для кэширования будет использоваться тип браузера.
                // В данном приложении ответ будет кэшироваться для каждого браузера отдельно.
                return context.Request.Browser.Type;
            }
            else
            {
                return null;
            }
        }
    }
}
