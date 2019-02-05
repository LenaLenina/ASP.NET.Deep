<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DesignSupport.Default" %>

<%@ Register assembly="ControlsLibrary" namespace="ControlsLibrary" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Design Support</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:TestControl ID="TestControl1" runat="server">
        </cc1:TestControl>
    
    </div>
    </form>
</body>
</html>
