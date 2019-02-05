﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebControlPostBack.Default" %>

<%@ Register assembly="ControlLibrary" namespace="ControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Specialized Control with PostBack</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:ClickablePanel ID="ClickablePanel1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" style="padding:10px;"
        OnClick="ClickablePanel1_Click">
            Hello world
        </cc1:ClickablePanel>

        <asp:Label ID="OutputLabel" runat="server" />
        
    </div>
    </form>
</body>
</html>
