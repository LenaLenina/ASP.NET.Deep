﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsSamples
{
    public partial class Calculator : System.Web.UI.UserControl
    {
        // Свойства котрола можно инициализировать через атрибуты в разметке
        public int Height
        {
            get { return (int)CalculatorPanel.Height.Value; }
            set { CalculatorPanel.Height = value; }
        }

        public int Width
        {
            get { return (int)CalculatorPanel.Width.Value; }
            set { CalculatorPanel.Width = value; }
        }

        protected void GetSumButton_Click(object sender, EventArgs e)
        {
            int summand1 = Convert.ToInt32(Summand1TextBox.Text);
            int summand2 = Convert.ToInt32(Summand2TextBox.Text);
            ResultLabel.Text = (summand1 + summand2).ToString();
        }
    }
}