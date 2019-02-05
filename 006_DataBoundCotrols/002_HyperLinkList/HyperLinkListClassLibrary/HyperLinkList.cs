using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HyperLinkListClassLibrary
{
    public class HyperLinkList : ListControl
    {
        // Элемент управления, который будет повторяться при формировании списка.
        private HyperLink _repeatControl;
        private HyperLink RepeateControl
        {
            get
            {
                if (_repeatControl == null)
                {
                    _repeatControl = new HyperLink();
                }
                return _repeatControl;
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                HyperLink control = RepeateControl;

                // Присвоение ссылке стилей контрола HyperLinkList.
                control.ApplyStyle(this.ControlStyle);

                // Items - элементы которые добавлены в список через дизайнер или через код.
                control.NavigateUrl = Items[i].Value;
                control.Text = Items[i].Text;

                // Вывод ссылки в HtmlTextWriter
                control.RenderControl(writer);

                writer.Write("<br />");
            }
        }
    }
}
