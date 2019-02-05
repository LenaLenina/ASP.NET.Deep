<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="CachingUserControls.Page1" %>

<%@ Register Src="~/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MyUserControl runat="server" id="MyUserControl" />
        </div>
    </form>
</body>
</html>
