using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ControlsLibrary
{
    // Обработчик на данное событие будет создан при двойном клике.
    [DefaultEvent("Click")]
    // Данное свойство будет выделено при открытии окна Properties
    [DefaultProperty("Text")]
    // Разметка, которая добавиться при переносе элемента из Tollbox
    [ToolboxData("<{0}:TestControl runat=\"server\" Text=\"Hello World!\"></{0}:TestControl>")]
    public class TestControl : Control, IPostBackEventHandler
    {
        #region Свойства
        // DefaultValue - данный атрибут не задает значения свойству. Атрибут нужен для того, что бы Visual Studio сравнивала
        // значение, которое было установлено в окне Properies со значением атрибута и если они отличаться, выводила значение в окне
        // полужирным шрифтом, указывая, что оно теперь не равно значению по умолчанию.
        [DefaultValue("Empty")]
        [Themeable(false)]
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

        [Browsable(false)]
        public int Foo { get; set; }
        #endregion

        #region Событие
        public void RaisePostBackEvent(string eventArgument)
        {
            OnClick(new EventArgs());
        }

        private EventHandler _event = null;
        public event EventHandler Click
        {
            add { _event += value; }
            remove { _event -= value; }
        }

        protected virtual void OnClick(EventArgs args)
        {
            EventHandler handler = _event;
            if (handler != null)
            {
                handler.Invoke(this, args);
            }
        }
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

            // добавление атрибута onclick c вызовом функции __doPostBack. Если функции нет на странице она создается.
            writer.AddAttribute(HtmlTextWriterAttribute.Onclick, Page.ClientScript.GetPostBackEventReference(this, String.Empty));

            // создание элемента div с применением значений style заданных выше
            writer.RenderBeginTag("div");

            base.Render(writer);

            writer.Write(Text);

            // создание закрывающего элемента div
            writer.RenderEndTag();
        }
    }
}

