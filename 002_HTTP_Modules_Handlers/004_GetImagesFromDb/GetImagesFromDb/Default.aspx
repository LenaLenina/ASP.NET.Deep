<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetImagesFromDb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img src="ImageHandler.ashx?image=1" alt="Image" />
            <img src="ImageHandler.ashx?image=2" alt="Image" />
            <img src="ImageHandler.ashx?image=3" alt="Image" />
        </div>
    </form>
</body>
</html>
