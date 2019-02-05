﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_UserControlDataBound
{
    public partial class UserControlDataBounded : System.Web.UI.UserControl
    {
        public object DataItem { get; set; }

        public string DataFirstNameField
        {
            set { ViewState["DataFirstNameField"] = value; }
            get
            {
                object data = ViewState["DataFirstNameField"];
                if (data != null)
                {
                    return data.ToString();
                }
                else return string.Empty;
            }
        }

        public string DataLastNameField
        {
            set { ViewState["DataLastNameField"] = value; }
            get
            {
                object data = ViewState["DataLastNameField"];
                if (data != null)
                {
                    return data.ToString();
                }
                else return string.Empty;
            }
        }

        public string DataMiddleNameField
        {
            set { ViewState["DataMiddleNameField"] = value; }
            get
            {
                object data = ViewState["DataMiddleNameField"];
                if (data != null)
                {
                    return data.ToString();
                }
                else return string.Empty;
            }
        }

        public void DataBind()
        {
            FirstNameLabel.Text = DataBinder.GetPropertyValue(DataItem, DataFirstNameField).ToString();
            LastNameLabel.Text = DataBinder.GetPropertyValue(DataItem, DataLastNameField).ToString();
            MiddleNameLabel.Text = DataBinder.GetPropertyValue(DataItem, DataMiddleNameField).ToString();
        }
    }
}