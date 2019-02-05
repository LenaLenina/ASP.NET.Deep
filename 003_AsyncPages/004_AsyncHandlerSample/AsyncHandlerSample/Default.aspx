<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsyncHandlerSample.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Использование асинхронного обработчика</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="SimpleAsyncHandler.ashx">Async Handler</a>
            <br />
            <a href="FastPage.aspx">FastPage.aspx</a>
            <br />
            <a href="SlowPage.aspx">SlowPage.aspx</a>
            <br />
        </div>
    </form>
</body>
</html>
