<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyHyperLink.Default" %>

<%@ Register assembly="ControlLibrary" namespace="ControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom HyperLink</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:MyHyperLink ID="MyHyperLink1" runat="server" NavigateUrl="SomePage.aspx" Text="Click Me!">
        </cc1:MyHyperLink>
    
    </div>
    </form>
</body>
</html>
