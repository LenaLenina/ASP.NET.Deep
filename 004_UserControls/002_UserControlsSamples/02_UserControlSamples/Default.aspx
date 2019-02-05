<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_UserControlSamples.Default" %>

<%@ Register src="TestControl1.ascx" tagname="TestControl1" tagprefix="uc1" %>
<%@ Register src="TestControl2.ascx" tagname="TestControl2" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserControl Properties and ViewState</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:TestControl1 ID="Control1" runat="server" />
        <uc2:TestControl2 ID="Control2" runat="server" />
    
        <asp:Button Text="Reload" runat="server" />
    </div>
    </form>
</body>
</html>
