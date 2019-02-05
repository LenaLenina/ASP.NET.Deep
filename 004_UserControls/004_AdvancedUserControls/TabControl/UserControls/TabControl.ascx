<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TabControl.ascx.cs" Inherits="TabControl" %>
<!--Повторяет определенный шаблон HTML для каждого элемента в коллекции-->
<asp:Repeater runat="server" ID="TabControlStrip" OnItemCommand="ItemCommand">
    <HeaderTemplate>
        <table cellpadding="0" cellspacing="0" border="0">
            <tr>
    </HeaderTemplate>
    <ItemTemplate>
        <td>
            <asp:Button runat="server"
                ID="TabItem"
                Text="<%# Container.DataItem %>"
                BackColor="<%# GetBackColor(Container) %>"
                BorderStyle="None" />
        </td>
    </ItemTemplate>
    <FooterTemplate>
        </tr></table>
    </FooterTemplate>
</asp:Repeater>
<asp:Panel runat="server" ID="TabItemContainer" BackColor="Gray" Width="100%" Height="10px">
</asp:Panel>
