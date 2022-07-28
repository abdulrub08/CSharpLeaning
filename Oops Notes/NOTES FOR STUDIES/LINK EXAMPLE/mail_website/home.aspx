<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2">
    <tr>
        <td align="center" style="color: #6600FF">
            &nbsp;</td>
        <td align="right" style="color: #6600FF">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/changepwd.aspx">Change Password</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td align="center" style="color: #6600FF">
            <h2>
                <asp:LinkButton ID="LNKMAIL" runat="server" PostBackUrl="~/homemail.aspx">MAIL</asp:LinkButton>
            </h2>
        </td>
        <td align="center" style="color: #6600FF">
            <h2>
                <asp:LinkButton ID="LNKMAIL0" runat="server" PostBackUrl="~/Default.aspx">CHAT</asp:LinkButton>
            </h2>
        </td>
    </tr>
</table>
</asp:Content>

