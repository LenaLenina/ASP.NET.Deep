<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_UserControlCreating.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--Контрол зарегистрирован в файле web.config и может быть создан на любой странице данного приложения--%>
        <test:WebUserControl runat="server" ID="WebUserControl1"></test:WebUserControl>
    </div>
    </form>
</body>
</html>
