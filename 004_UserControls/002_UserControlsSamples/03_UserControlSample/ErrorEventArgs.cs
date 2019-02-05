using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03_UserControlSample
{
    public class ErrorEventArgs : EventArgs
    {
        public string ErrorMessage { get; set; }

        public ErrorEventArgs(string errorMessge)
        {
            this.ErrorMessage = errorMessge;
        }
    }
}