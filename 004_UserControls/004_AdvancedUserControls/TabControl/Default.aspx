<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TabControl Sample</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Элемент управления зарегистрирован в файле web.config-->
        <test:TabControl runat="server" ID="TabControlTest" 
            OnSelectionChanged="TabControl_OnSelectionChanged"
            SelectedTabBackColor="Orange" />
        <asp:Label runat="server" ID="LabelMsg" />
    </div>
    </form>
</body>
</html>
