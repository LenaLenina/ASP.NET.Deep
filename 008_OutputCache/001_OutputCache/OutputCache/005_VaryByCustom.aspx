<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="005_VaryByCustom.aspx.cs" Inherits="OutputCache._005_varyByCustom" %>

<%--Используя параметр VaryByCustom можно определить пользовательский ключ, по которому будет происходить кэширование.
    При использовании данного параметра необходимо добаить в класс Global.asax метод GetVaryByCustomString(HttpContext context, string custom)--%>

<%@ OutputCache Duration="60" VaryByCustom="device" VaryByParam="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Эта страница попала в кэш в
            <%= DateTime.Now.ToLongTimeString() %></h1>
        </div>
    </form>
</body>
</html>
