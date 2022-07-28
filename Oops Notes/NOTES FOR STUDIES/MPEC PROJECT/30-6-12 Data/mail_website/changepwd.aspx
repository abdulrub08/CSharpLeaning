<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepwd.aspx.cs" Inherits="changepwd" %>

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
            width: 108px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2" rowspan="7">
                    <asp:Image ID="Image1" runat="server" Height="221px" ImageUrl="~/chngepwd.jpg" 
                        Width="368px" />
                </td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/login.aspx">Logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <h2 style="font-family: 'Times New Roman', Times, serif">
                        Please enter the following fields to change yoyr password</h2>
                </td>
            </tr>
            <tr>
                <td>
                    Old Password</td>
                <td>
                    <asp:TextBox ID="txtoldpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    New Password</td>
                <td>
                    <asp:TextBox ID="txtnewpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox>
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
                <td colspan="2">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
