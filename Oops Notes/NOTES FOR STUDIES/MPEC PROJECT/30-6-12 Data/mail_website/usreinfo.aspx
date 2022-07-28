<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usreinfo.aspx.cs" Inherits="usreinfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 101%;
            height: 96px;
        }
        .style2
        {
            height: 82px;
        }
        .style3
        {
            width: 100%;
        }
        .style4
        {
            width: 412px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2" colspan="2" style="font-family: Forte">
                    <h2 style="color: #CC9900; background-color: #33CCFF; font-family: 'Arial Black'; text-transform: inherit; height: 76px;">
                        Welcome to our organization.You are requested to fill up the follwing entries.</h2>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Panel ID="Panel1" runat="server" Height="443px">
                        <img alt="" src="register.jpg" style="height: 439px; width: 389px" />
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="pnlusrinfo" runat="server" BorderColor="#00FFCC" Height="439px" 
                        style="margin-left: 0px">
                        <table class="style3" 
                            style="font-size: large; font-family: 'Times New Roman', Times, serif; color: #808080">
                            <tr>
                                <td colspan="2">
                                    <h3 align="left">
                                        <asp:Label ID="lblmsg" runat="server" ForeColor="#FF5050"></asp:Label>
                                    </h3>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        User Name*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Employee id*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Password*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Confirm Parrword*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Designation*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Address</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Contact Number*</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcno" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                        Remark</h3>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtremark" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h3>
                                    </h3>
                                </td>
                                <td>
                                    <h3>
                                        <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                                            Text="Submit" />
                                    </h3>
                                </td>
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
