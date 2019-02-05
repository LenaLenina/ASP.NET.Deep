﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AXDFileSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Использование AXD файлов</title>
    <style>
        strong {
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="/Images/">Images/</a>
            <br />
            <a href="/Images/view.axd">Images/<strong>view.axd</strong></a>
            <br />
            <a href="/Images/Subfolder/view.axd">Images/Subfolder/<strong>view.axd</strong></a>
        </div>
    </form>
</body>
</html>
