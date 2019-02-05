<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleDataBoundControlsDataSourceId.Default" %>

<%@ Register assembly="DataBoundControlLibrary" namespace="DataBoundControlLibrary" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:MessageBoardControl ID="MessageBoardControl1" runat="server" 
                DataMessageField="MessageBody" 
                DataTitleField="MessageTitle"
                DataSourceID="TestSqlDataSource" />

            <asp:SqlDataSource ID="TestSqlDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT [MessageTitle], [MessageBody] FROM [Messages]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
