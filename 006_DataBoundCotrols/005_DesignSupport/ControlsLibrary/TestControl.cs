using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ControlsLibrary
{
    public class TestControl : Control
    {
        #region Свойства
        // DefaultValue - данный атрибут не задает значения свойству. Атрибут нужен для того, что бы Visual Studio сравнивала
        // значение, которое было установлено в окне Properies со значением атрибута и если они отличаться, выводила значение в окне
        // полужирным шрифтом, указывая, что оно теперь не равно значению по умолчанию.
        [DefaultValue("Empty")]
        // Themeable - свойство не может использоваться в темах и скин файлах
        [Themeable(false)]
        // Bindable - определяет может ли свойство использоваться для привязки данных 
        [Bindable(false)]
        public string Text
        {
            get
            {
                object data = ViewState["text"];
                if (data == null)
                {
                    return "Empty";
                }
                return data.ToString();
            }
            set { ViewState["text"] = value; }
        }

        // Browsable - свойство не будет отображаться в окне Property Window
        [Browsable(false)]
        public int Foo { get; set; }
        #endregion

        protected override void Render(HtmlTextWriter writer)
        {
            // установка значений для атрибута style
            writer.AddStyleAttribute("padding", "20px");
            writer.AddStyleAttribute("width", "200px");
            writer.AddStyleAttribute("height", "50px");
            writer.AddStyleAttribute("color", "black");
            writer.AddStyleAttribute("background-color", "white");
            writer.AddStyleAttribute("border", "1px solid gray");

            // создание элемента div с применением значений style заданных выше
            writer.RenderBeginTag("div");

            base.Render(writer);

            writer.Write(Text);

            // создание закрывающего элемента div
            writer.RenderEndTag();
        }
    }
}

