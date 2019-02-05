<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleDataBoundControls.Default" %>

<%@ Register assembly="DataBoundControlLibrary" namespace="DataBoundControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DataBoundControl</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:MessageBoardControl ID="MessageBoardControl1" runat="server" />
    </div>
    </form>
</body>
</html>
