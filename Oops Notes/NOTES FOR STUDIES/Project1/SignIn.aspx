<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 466px;
        }
        .style2
        {
            width: 100%;
            height: 299px;
        }
        .style3
        {
        }
        .style4
        {
            width: 202px;
            height: 37px;
        }
        .style5
        {
            height: 37px;
        }
        .style6
        {
            width: 202px;
            height: 66px;
        }
        .style7
        {
            height: 66px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        
            <asp:Panel ID="Panel1" runat="server" Height="895px" Align="center">
            
                <table class="style1">
                    <tr>
                        <td align="center" valign="middle">
                            <div style="width: 650px; height: 300px;" id="mid">
                                
                                <asp:Panel ID="Panel2" runat="server" Height="300px" Width="650px" 
                                    BackColor="#CCCCCC">
                                    <table class="style2">
                                        <tr>
                                            <td class="style3" style="text-align: right">
                                                User Name :
                                            </td>
                                            <td style="text-align: left">
                                                <asp:TextBox ID="txtusername" runat="server" Width="194px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style3" style="text-align: right">
                                                Password :
                                            </td>
                                            <td style="text-align: left">
                                                <asp:TextBox ID="txtpswrd" runat="server" Width="194px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4" style="text-align: right">
                                                </td>
                                            <td style="text-align: left" class="style5">
                                                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Font-Size="Large" 
                                                    ForeColor="Red"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style6" style="text-align: right">
                                                </td>
                                            <td style="text-align: left" class="style7" valign="top">
                                                <asp:ImageButton ID="loginbtn" runat="server" 
                                                    ImageUrl="~/image/Login.png" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style3" style="text-align: center">
                                                <asp:LinkButton ID="LinkButton1" runat="server">Forgot Password</asp:LinkButton>
                                            </td>
                                            <td style="text-align: left" valign="baseline">
                                                Click Sign Up Button For Create a&nbsp; New Account
                                                <asp:ImageButton ID="signupbtn" runat="server" ImageAlign="Middle" 
                                                    ImageUrl="~/image/sign-up.png" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style3" colspan="2" style="text-align: center">
                                                <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.7" 
                                                    Radius="6" Rounded="True" TargetControlID="Panel2" TrackPosition="True" 
                                                    Width="7">
                                                </cc1:DropShadowExtender>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                
                            </div>
                        </td>
                    </tr>
                </table>
                
               
            </asp:Panel>
       
</asp:Content>

