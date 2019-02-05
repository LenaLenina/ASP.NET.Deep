<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HyperLinkList.Default" %>

<%@ Register Assembly="HyperLinkListClassLibrary" Namespace="HyperLinkListClassLibrary" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HyperLinkList</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <cc1:HyperLinkList ID="HyperLinkList1" runat="server">
                <asp:ListItem Text="Google" Value="http://google.com" />
                <asp:ListItem Text="Yandex" Value="http://ya.ru" />
                <asp:ListItem Text="Yahoo" Value="http://yhoo.com" />
            </cc1:HyperLinkList>

        </div>
    </form>
</body>
</html>
