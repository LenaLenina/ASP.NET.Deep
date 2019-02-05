using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.UI;

public partial class TabControl : System.Web.UI.UserControl
{
    #region Properties
    // Для сохранения данных между запросами, значения свойств записываются в ViewState

    // Коллекция с названиями всех вкладок TabControl
    private List<string> _tabs = new List<string>();
    public List<string> Tabs
    {
        get { return _tabs; }
        set { _tabs = value; }
    }

    // Фон вкладки.
    public Color BackColor
    {
        get
        {
            object backColor = ViewState["BackColor"];
            if (backColor == null)
            {
                return Color.Silver; // Цвет по умолчанию
            }
            return (Color)backColor;
        }
        set
        {
            ViewState["BackColor"] = value;
        }
    }

    // Цвет текста вкладки.
    public Color ForeColor
    {
        get
        {
            object foreColor = ViewState["ForeColor"];
            if (foreColor == null)
            {
                return Color.Black;
            }
            return (Color)foreColor;
        }
        set
        {
            ViewState["ForeColor"] = value;
        }
    }

    // Фон выделенной вкладки.
    public Color SelectedTabBackColor
    {
        get
        {
            object backColor = ViewState["SelectedTabBackColor"];
            if (backColor == null)
            {
                return Color.Silver;
            }
            return (Color)backColor;
        }
        set
        {
            ViewState["SelectedTabBackColor"] = value;
        }
    }

    // Порядковый номер выбранной вкладки.
    public int CurrentTabIndex
    {
        get
        {
            object currentTab = ViewState["CurrentTabIndex"];
            if (currentTab == null)
            {
                return 0;
            }
            return (int)currentTab;
        }
    } 
    #endregion

    #region Private & Protected Methods
    // Метод для привязки данных к контролу.
    private void BindData()
    {
        TabControlStrip.DataSource = _tabs; // _tabs - список названий вкладок, инициализируется через свойство Tabs
        TabControlStrip.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    // Обработчик события нажатие по кнопке в контроле Repeater.
    protected void ItemCommand(object sender, RepeaterCommandEventArgs e)
    {
        SelectTab(e.Item.ItemIndex);
    }

    // Метод для определения цвета вкладки. Вызывается из разметки при построении таблицы с помощью Repeater
    protected Color GetBackColor(object data)
    {
        RepeaterItem item = (RepeaterItem)data;
        if (item.ItemIndex == CurrentTabIndex)
        {
            return SelectedTabBackColor;
        }
        return BackColor;
    }
    #endregion

    #region Public Methods
    // Метод для программной установки активной вкладки.
    public void SelectTab(int tabIndex)
    {
        if (tabIndex < 0 || tabIndex > _tabs.Count)
        {
            tabIndex = 0;
        }
        ViewState["CurrentTabIndex"] = tabIndex;
        BindData();

        // Инициация события SelectionChanged
        SelectionChangedEventArgs e = new SelectionChangedEventArgs();
        e.Position = tabIndex;
        OnSelectionChanged(e);
    } 
    #endregion

    #region Events
    // Событие срабатывающее при изменении выбранной вкладки.
    // Для того, что бы деларативно указать обработчик на странице для этого события, нужно использовать атрибут 
    // On[ИмяСвойства] для данного контрола это OnSelectionChanged
    public event EventHandler<SelectionChangedEventArgs> SelectionChanged;

    protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
    {
        if (SelectionChanged != null)
            SelectionChanged(this, e);
    } 
    #endregion
}