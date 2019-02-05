<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DesignSupport.Default" %>

<%@ Register Assembly="ControlsLibrary" Namespace="ControlsLibrary" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Design Support</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:TestControl ID="TestControl1" runat="server" Text="Hello World!"></cc1:TestControl>
        </div>
    </form>

</body>
</html>
