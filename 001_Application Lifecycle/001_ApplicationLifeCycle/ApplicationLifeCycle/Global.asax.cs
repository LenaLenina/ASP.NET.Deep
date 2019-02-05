﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationLifeCycle
{
    public class Global : System.Web.HttpApplication
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Обработчики событий приложения.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Вызывается при старте веб приложения.
        void Application_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Start");
        }

        // Вызывается при завершении приложения. 
        // Приложение завершается, если к нему, в течении 20 минут (по умолчанию), не было ни одного запроса.
        void Application_End(object sender, EventArgs e)
        {
            Debug.WriteLine("End");
        }

        // В приложении возникло исключение, которое не обработали
        void Application_Error(object sender, EventArgs e)
        {
            Debug.WriteLine("Error");
            // Получение исключения, которое произошло на странице.
            Exception ex = Server.GetLastError().GetBaseException();
        }

        // Срабатывает, когда начинается новая сессия.
        void Session_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Session_Start");
        }

        // Срабатывает при завершении сессии.
        // Этот метод будет вызываться только если в web.config, в секции sessionState, атрибут mode установлен, как InProc
        // InProc - это значение по умолчанию, означает, что данные сеанса будут храниться в текущем рабочем процессе.
        void Session_End(object sender, EventArgs e)
        {
            Debug.WriteLine("Session_End");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Обработчики событий запроса. (В хронологическом порядке.)
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Вызывается при каждом запросе.
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("BeginRequest");
        }

        // Срабатывает после аутентификации пользователя, выполняющего запрос. (аутентификация - определение принадлежности к ресурсу, поиск учетной записи)
        void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("AuthenticateRequest");
        }

        // Срабатывает после авторизации пользователя, выполняющего запрос. (авторизация - определение наличия прав доступа)
        void Application_AuthorizeRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("AuthorizeRequest");
        }

        // Модули отвечающие за кэширование, извлекают ранее обработанный запрос, минуя вызов обработчика события.
        void Application_ResolveRequestCache(object sender, EventArgs e)
        {
            Debug.WriteLine("ResolveRequestCache");
        }

        // Срабатывает после получения состояния сессии (Session state) для текущего запроса.
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            Debug.WriteLine("AcquireRequestState");
        }

        // Срабатывает до того как начнется вызов обработчика.
        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            Debug.WriteLine("PreRequestHandlerExecute");
        }

        // ВЫЗОВ ОБРАБОТЧИКА.

        // Срабатывает после завершения обработчика события.
        protected void Application_PostRequestHandlerExecute(object sender, EventArgs e)
        {
            Debug.WriteLine("PostRequestHandlerExecute");
        }

        // Вызывается тогда, когда информация сеанса сериализуется из коллекции Session, чтобы стать доступной в следующем запросе
        protected void Application_ReleaseRequestState(object sender, EventArgs e)
        {
            Debug.WriteLine("ReleaseRequestState");
        }

        // Вызывается перед добавлением информации в кэш выходных данных, если он был разрешен
        protected void Application_UpdateRequestCache(object sender, EventArgs e)
        {
            Debug.WriteLine("UpdateRequestCache");
        }

        // Последнее событие, которое происходит при обработке запроса.
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("EndRequest");
        }
    }
}
