<%@ Page Language="C#" AutoEventWireup="true" CodeFile="citystate.aspx.cs" Inherits="citystate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" AutoPostBack="True" 
                        BorderStyle="Solid" ForeColor="#FF3399"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    country</td>
                <td>
                    <asp:DropDownList ID="ddlcountry" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlcountry_SelectedIndexChanged">
                        <asp:ListItem>india</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>pakistan</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    state</td>
                <td>
                    <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlstate_SelectedIndexChanged" > 
                       
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlcity_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                        Text="submit" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
