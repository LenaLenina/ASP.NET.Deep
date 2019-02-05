using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleTemplatedControlLibrary
{
    public class MessageBlock : WebControl
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string MessageBody { get; set; }

        // Эта ссылка будет хранить шаблон для заголовка сообщения.
        ITemplate _headerTemplate = null;

        // TemplateContainer - задает тип контейнера именования, в котором будет хранится установленный шаблон.
        // PersistenceMode - указывает, как осуществляется сохранение значения данного свойства в хост странице.
        [TemplateContainer(typeof(HeaderTemplateContainer))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ITemplate HeaderTemplate
        {
            get { return _headerTemplate; }
            set { _headerTemplate = value; }
        }

        // Эта ссылка будет хранить шаблон для тела сообщения.
        ITemplate _messageTemplate = null;

        [TemplateContainer(typeof(MessageTemplateContainer))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        // Шаблон сообщения, которое выводит элемент  управления.
        public ITemplate MessageTemplate
        {
            get { return _messageTemplate; }
            set { _messageTemplate = value; }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            // Если шаблон был установлен в хост странице.
            if (_headerTemplate != null)
            {
                // Инициализируем контейнер для данного шаблона. При вызове конструктора передаем указатель на текущий объект,
                // так как в HeaderTemplateContainer могут потребоваться данные из этого объекта.
                HeaderTemplateContainer template = new HeaderTemplateContainer(this);

                // Инициалищируем шаблон в указанном контейнере.
                HeaderTemplate.InstantiateIn(template);

                // Добавляем контейнер в дерево элементов управления.
                Controls.Add(template);
            }
            else
            {
                Label control = new Label();
                control.Text = Title + " [ " + Author + " ] ";
                Controls.Add(control);
            }
            if (_messageTemplate != null)
            {
                MessageTemplateContainer templateContainer = new MessageTemplateContainer(this);
                MessageTemplate.InstantiateIn(templateContainer);
                Controls.Add(templateContainer);
            }
            else
            {
                Label control = new Label();
                control.Text = "<br />" + MessageBody;
                Controls.Add(control);
            }

            // Для того что бы сработали все выражения привязок <%# ... %>, используемых в шаблоне, вызываем метод DataBind.
            DataBind();

            base.Render(writer);
        }

        // Тип контейнера обязательно должен реализовывать интерфейс INamingContainer.
        public class HeaderTemplateContainer : WebControl, INamingContainer
        {
            private MessageBlock _parent;

            public HeaderTemplateContainer(MessageBlock parent)
            {
                _parent = parent;
            }

            // В хост странице при задании разметки в элементе HeaderTemplate можно использовать привязку к следующим свойствам.
            public string Title { get { return _parent.Title; } }
            public string Author { get { return _parent.Author; } }
        }

        public class MessageTemplateContainer : WebControl, INamingContainer
        {
            private MessageBlock _parent;

            public MessageTemplateContainer(MessageBlock parent)
            {
                _parent = parent;
            }

            public string MessageBody { get { return _parent.MessageBody; } }
        }
    }
}
