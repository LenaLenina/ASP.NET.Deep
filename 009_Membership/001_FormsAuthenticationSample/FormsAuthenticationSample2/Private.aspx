<%@ Page Title="Private Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Private.aspx.cs" Inherits="FormsAuthenticationSample2.Private" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Private Information</h2>
    <asp:Label Id="LabelMessage" runat="server" />
</asp:Content>
