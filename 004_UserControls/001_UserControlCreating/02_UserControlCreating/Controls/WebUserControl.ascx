<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl.ascx.cs" Inherits="UserControlSamples.WebUserControl1" %>

<asp:TextBox ID="TestTextBox" runat="server"></asp:TextBox>
<asp:Button Text="Click Me" runat="server" ID="TestButton" 
    onclick="TestButton_Click" />