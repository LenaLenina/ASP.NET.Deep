<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="CachingUserControls.Page2" %>

<%@ Register Src="~/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MyUserControl runat="server" id="MyUserControl" />
        </div>
    </form>
</body>
</html>
