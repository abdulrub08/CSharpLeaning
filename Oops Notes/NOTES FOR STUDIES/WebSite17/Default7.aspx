<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="371px" Width="475px">
            <table class="style1">
                <tr>
                    <td>
                        Name</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" 
                            oncheckedchanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server" Width="51px">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Hocky</asp:ListItem>
                            <asp:ListItem>Bolybol</asp:ListItem>
                            <asp:ListItem>Chees</asp:ListItem>
                            <asp:ListItem>Polo</asp:ListItem>
                            <asp:ListItem>Molo</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
