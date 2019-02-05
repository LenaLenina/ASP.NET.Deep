using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleDataBoundControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TestDataSource> source = new List<TestDataSource>();

                TestDataSource item = new TestDataSource();
                item.A = "Тестовый заголовок сообщения";
                item.B = "Текст сообщения. ABCDEFGHIJKLMNOPQRSTUVWXYZ. 1234567890";
                source.Add(item);

                MessageBoardControl1.DataTitleField = "A";
                MessageBoardControl1.DataMessageField = "B";
                MessageBoardControl1.DataSource = source;
                MessageBoardControl1.DataBind(); 
            }
        }
    }

    class TestDataSource
    {
        public string A { get; set; }
        public string B { get; set; }
    }
}