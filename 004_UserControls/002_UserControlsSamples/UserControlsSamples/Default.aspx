<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControlsSamples.Default" %>

<%@ Register Src="Calculator.ascx" TagName="Calculator" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserControl Properties</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--Открытые свойства класса контрола можно инициализировать с помощью атрибутов в aspx
        разметке--%>
        <uc1:Calculator ID="Calculator1" runat="server" Height="200" Width="500" />
    </div>
    </form>
</body>
</html>
