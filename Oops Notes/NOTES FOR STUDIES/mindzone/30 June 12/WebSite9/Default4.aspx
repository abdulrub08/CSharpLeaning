<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="260px" Width="364px">
            <table class="style1">
                <tr>
                    <td>
                        Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        State</td>
                    <td>
                        <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlstate_SelectedIndexChanged">
                            <asp:ListItem>AP</asp:ListItem>
                            <asp:ListItem>MP</asp:ListItem>
                            <asp:ListItem>UP</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        City</td>
                    <td>
                        <asp:DropDownList ID="ddlcity" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                            Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td class="style2" colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
