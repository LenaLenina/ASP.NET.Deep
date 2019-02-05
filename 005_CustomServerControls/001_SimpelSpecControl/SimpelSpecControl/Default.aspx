<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpelSpecControl.WebForm1" %>

<%@ Register assembly="ControlLibrary" namespace="ControlLibrary" tagprefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Specialized Control</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:MyControl ID="MyControl1" runat="server">
        </cc1:MyControl>
    </div>
    </form>
</body>
</html>
