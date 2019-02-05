<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SqlDependencyOutputCache.Default" %>

<%-- Страница будет кэшироваться на 60 секунд но автоматически удалиться из кэша если будут внесены изменения в таблицу Products --%>
<%@ OutputCache Duration="60" VaryByParam="None" SqlDependency="Database:Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>SqlDependency</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--
                Для того, чтобы активировать кэширование для базы данных, необходимо запустить утилиту Aspnet_regsql.exe, которая находится в директории %windir%\Microsoft.NET\Framework\FrameworkVersion
                Утилиту следует запустить со следующими параметрами

                aspnet_regsql.exe -C "Data Source=(localDB)\v11.0;Database='Путь к безе';Integrated Security=True" -ed -et -t [Имя таблицы]

                [Имя таблицы] таблица, для которой будет включено кэширование.
            --%>

            <asp:Label ID="MessageLabel" runat="server" ForeColor="Red"></asp:Label>

            <br />
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="DatabaseSqlDataSource">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="DatabaseSqlDataSource" 
                runat="server" 
                ConnectionString="<%$ ConnectionStrings:Connection %>" 
                ProviderName="System.Data.SqlClient" 
                SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

