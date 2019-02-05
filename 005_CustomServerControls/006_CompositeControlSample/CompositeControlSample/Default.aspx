<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CompositeControlSample.Default" %>

<%@ Register assembly="ControlLibrary" namespace="ControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CompositeControl Sample</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:MyCompositeControl ID="MyCompositeControl1" runat="server" />
    </div>
    </form>
</body>
</html>

