using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ControlsLibrary
{
    public class TestControl : Control
    {
        #region Свойства
        // Category - определяет категорию, к которой будет относиться данное свойство при редактировании элемента управления в окне ProeprtyWindow
        [Category("Параметры")]
        // Description - описание, которое будет отображаться в нижней части окна PropertyWindow если выделить данное свойство курсором
        [Description("Ширина элемента управления")]
        public int Width
        {
            get
            {
                object data = ViewState["Width"];
                if (data == null)
                {
                    return 100;
                }
                return (int)data;
            }
            set { ViewState["Width"] = value; }
        }

        [Category("Параметры")]
        [Description("Высота элемента управления")]
        public int Height
        {
            get
            {
                object data = ViewState["Height"];
                if (data == null)
                {
                    return 50;
                }
                return (int)data;
            }
            set { ViewState["Height"] = value; }
        }

        [Category("Настройки цвета")]
        [Description("Цвет фона")]
        public Color BackColor
        {
            get
            {
                object data = ViewState["BackColor"];
                if (data == null)
                {
                    return Color.White;
                }
                return (Color)data;
            }
            set { ViewState["BackColor"] = value; }
        }

        [Category("Настройки цвета")]
        [Description("Цвет шрифта")]
        public Color ForeColor
        {
            get
            {
                object data = ViewState["ForeColor"];
                if (data == null)
                {
                    return Color.Black;
                }
                return (Color)data;
            }
            set { ViewState["ForeColor"] = value; }
        }

        [Category("Настройки цвета")]
        [Description("Цвет рамки")]
        public Color BorderColor
        {
            get
            {
                object data = ViewState["BorderColor"];
                if (data == null)
                {
                    return Color.Black;
                }
                return (Color)data;
            }
            set { ViewState["BorderColor"] = value; }
        }
        #endregion

        protected override void Render(HtmlTextWriter writer)
        {
            // установка значений для атрибута style
            writer.AddStyleAttribute("padding", "20px");
            writer.AddStyleAttribute("width", this.Width + "px");
            writer.AddStyleAttribute("height", this.Height + "px");
            writer.AddStyleAttribute("color", this.ForeColor.Name);
            writer.AddStyleAttribute("background-color", this.BackColor.Name);
            writer.AddStyleAttribute("border", "1px solid " + this.BorderColor.Name);

            // создание элемента div с применением значений style заданных выше
            writer.RenderBeginTag("div");

            base.Render(writer);

            writer.Write("Hello ASP.NET Control");

            // создание закрывающего элемента div
            writer.RenderEndTag();
        }

    }
}
