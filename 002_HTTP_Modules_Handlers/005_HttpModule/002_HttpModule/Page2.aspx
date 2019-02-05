<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="_002_HttpModule.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pafe 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Page 2
            <% System.Threading.Thread.Sleep(new Random().Next(5000)); %>
        </div>
    </form>
</body>
</html>
