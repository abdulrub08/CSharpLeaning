<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<asp:panel runat="server"></asp:panel>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BorderColor="#FF0066" ForeColor="#6666FF" 
            Height="243px">
            <table class="style1">
                <tr>
                    <td>
                        Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server" ontextchanged="txtname_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        password</td>
                    <td>
                        <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnlogin" runat="server" Text="login" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    
    </form>
</body>
</html>
