<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calculator.ascx.cs"
    Inherits="UserControlsSamples.Calculator" %>
<asp:Panel ID="CalculatorPanel" runat="server" BorderColor="Black" BorderWidth="1px" BorderStyle="Dashed" style="padding:10px; float:left;">
    <asp:TextBox runat="server" ID="Summand1TextBox" />
    +
    <asp:TextBox runat="server" ID="Summand2TextBox" />
    =
    <asp:Label ID="ResultLabel" runat="server" />
    <br />
    <asp:Button ID="GetSumButton" Text="Получить сумму" runat="server" OnClick="GetSumButton_Click" />
</asp:Panel>
