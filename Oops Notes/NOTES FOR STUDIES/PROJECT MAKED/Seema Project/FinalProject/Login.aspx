<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 227px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <asp:Panel ID="Panel1" runat="server" Height="274px" Width="400px" 
            BackColor="#99CCFF" BorderColor="#0066FF" BorderStyle="Ridge">
            <table class="style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblheading" runat="server" Text="Login"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLoginName" runat="server" Text="Login Name*" CssClass="Text"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLoginName" runat="server" CssClass="Textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password*" CssClass="Text"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="Textbox" 
                            TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Log-in" 
                            onclick="btnLogin_Click" CssClass="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                            <ProgressTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Csearch_00.gif" />
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSignup" runat="server" CssClass="Button" 
                            onclick="btnSignup_Click" Text="Sign-up" />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                            PostBackUrl="~/ForgotPassword.aspx">Forgot Your Password?</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
