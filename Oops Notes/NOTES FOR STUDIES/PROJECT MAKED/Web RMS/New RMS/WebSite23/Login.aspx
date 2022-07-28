<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 97%;
            height: 177px;
        }
        .style2
        {
            width: 356px;
        }
        .style3
        {
            width: 335px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 752px">
    
        <br />
        <br />
        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Login Form"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#993333" 
            BorderStyle="Solid" Height="391px" Width="898px" Font-Bold="True" 
            Font-Size="Large">
            <table class="style1" frame="border">
                <tr>
                    <td class="style3" align="center" rowspan="5">
                        <asp:Image ID="Image1" runat="server" Height="349px" ImageAlign="Bottom" 
                            ImageUrl="~/login1.jpg" Width="315px" />
                    </td>
                    <td class="style3">
                        <br />
                        Login Name* :<br />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="txtloginname" runat="server" Height="45px" Width="228px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <br />
                        Password*&nbsp;&nbsp;&nbsp;&nbsp; :<br />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="txtpassword" runat="server" Height="50px" TextMode="Password" 
                            Width="224px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="3">
                        <asp:Button ID="btnlogin" runat="server" Font-Bold="True" Font-Size="Medium" 
                            ForeColor="#003300" Height="44px" onclick="btnlogin_Click" Text="Log-In" 
                            Width="102px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" style="color: #800000">
                        New User ---</td>
                    <td align="left" colspan="2">
                        <asp:Button ID="btnsignup" runat="server" Font-Bold="True" Font-Size="Medium" 
                            ForeColor="#003300" Height="39px" onclick="btnsignup_Click" Text="SignUp" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
