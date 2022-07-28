<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="UserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">

        .style1
        {
            width: 100%;
            height: 272px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 620px">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Label ID="lblheading" runat="server" Font-Bold="True" Font-Italic="False" 
            Font-Names="Arial" Font-Underline="True" Text="UserInfo"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" BackColor="#99CCFF" BorderColor="#6600FF" 
                    BorderStyle="Ridge" Height="480px" Width="562px">
                    <table class="style1">
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                <asp:Label ID="lblUserName" runat="server" Text="User Name*"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblLoginName" runat="server" CssClass="Text" Text="Login Name*"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtLoginName" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnCheckAvailability" runat="server" CssClass="Button" 
                                    Height="26px" onclick="btnCheckAvailability_Click" Text="Check Availability" 
                                    Width="129px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblPassword" runat="server" CssClass="Text" Text="Password*"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblConfirmPassword" runat="server" CssClass="Text" 
                                    Text="Confirm Password*"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblAddress" runat="server" CssClass="Text" Text="Address*"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtAddress" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblContactNo" runat="server" CssClass="Text" Text="Contact No.*"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtContactNo" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Mobile No *</td>
                            <td colspan="2">
                                <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRemark" runat="server" CssClass="Text" Text="Remark"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="2">
                                <img alt="" src="Captcha.aspx" style="height: 51px; width: 180px" /></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="2">
                                <asp:TextBox ID="txtCaptcha" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                                    style="height: 26px" Text="Submit" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
