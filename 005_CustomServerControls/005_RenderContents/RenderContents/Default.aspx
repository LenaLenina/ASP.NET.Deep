<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RenderContents.Default" %>

<%@ Register assembly="ControlLibrary" namespace="ControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Panel</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:MyPanel ID="MyPanel1" runat="server" BackColor="Green" ForeColor="White" Font-Bold="true">
            <asp:Label runat="server">Test</asp:Label>
        </cc1:MyPanel>
    
    </div>
    </form>
</body>
</html>
