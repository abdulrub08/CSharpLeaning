<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
            font-family: "Times New Roman", Times, serif;
        }
        .style3
        {
            width: 310px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    <asp:Panel ID="Panel1" runat="server" Height="394px" Width="320px">
                        <asp:Image ID="Image1" runat="server" Height="267px" ImageUrl="~/login.jpg" 
                            Width="317px" />
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Height="457px" Width="656px">
                        <table class="style1">
                            <tr>
                                <td class="style2" colspan="2">
                                    <h2 style="font-family: 'Arial Black'">
                                        Welcome to our login page.Please login to enter.</h2>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <h3>
                                        Employee ID</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <h3>
                                        Password</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnlogin" runat="server" onclick="btnlogin_Click" 
                                        Text="Log-in" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <h3>
                                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                                    </h3>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        <asp:LinkButton ID="lnksignup" runat="server" PostBackUrl="~/usreinfo.aspx" 
                                            style="font-family: 'Times New Roman', Times, serif">SIGN-UP</asp:LinkButton>
                                    </h3>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
