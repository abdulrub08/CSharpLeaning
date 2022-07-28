<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contactus.aspx.cs" Inherits="Contactus" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" href="stylesheet.css" />
<style type="text/css">

    .style2
    {
        width: 100%;
        height: 876px;
    }
    .style3
    {
        font-size: xx-large;
    }
    .style5
    {
        text-align: center;
    }
    .style6
    {
        width: 100%;
    }
    .style8
    {
        width: 162px;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Panel ID="Panel1" runat="server" Height="879px" Width="1238px">
    <div id="content">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <div class="box">
        <h1 class="style3">
            Contact Me</h1>
            <hr style="border: thin solid #333333; height: 6px" />
            <h3>
                If you like that you see and require my service then please fill out the form 
                below and i will respond to you email as soon as possible ....</h3>
                <br />
        
                <div id="contact" style="height: 498px; width: 762px" style="margin-left:19px;">
                    <asp:Panel ID="Panel4" runat="server" style="" BackColor="White" 
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px">
                    <table class="style6">
                        <tr>
                            <td align="center" style="text-align: right" class="style8">
                                Name :
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtname" runat="server" Width="210px"></asp:TextBox>
                                <asp:Label ID="lblname" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" style="text-align: right" class="style8">
                                Email :</td>
                            <td>
                                <asp:TextBox ID="txtemail" runat="server" Width="208px"></asp:TextBox>
                                <asp:Label ID="lblemail" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style8">
                                </td>
                            <td>
                                </td>
                        </tr>
                        <tr>
                            <td align="center" style="text-align: right" class="style8">
                                Mobile Number :</td>
                            <td>
                                <asp:TextBox ID="txtmblno" runat="server" Width="208px"></asp:TextBox>
                                <asp:Label ID="lblmobile" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center" align="center" colspan="2">
                                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="text-align: right" valign="top" class="style8">
                                Comment :
                            </td>
                            <td>
                                <asp:TextBox ID="txtcmmnt" runat="server" Height="355px" TextMode="MultiLine" 
                                    Width="603px" Wrap="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="text-align: right" valign="top" class="style8">
                                &nbsp;</td>
                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="36px" 
                                    ImageUrl="~/image/Submit.png" Width="178px" onclick="ImageButton1_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="style8" style="text-align: right" valign="top">
                                &nbsp;</td>
                            <td>
                                <cc1:DropShadowExtender ID="DropShadowExtender3" runat="server" Opacity="0.7" 
                                    Radius="6" Rounded="True" TargetControlID="Panel4" TrackPosition="True" 
                                    Width="7">
                                </cc1:DropShadowExtender>
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                    
        </div>
        </div>
     </ContentTemplate>
       </asp:UpdatePanel> 
    </div>
    <div id="sidebar">
        <table class="style2">
            <tr>
                <td>
                    <div style="height: 700px; background-color: #800000;">
                        &nbsp;
                        <asp:Image ID="imgesfont" runat="server" Height="64px" 
                            ImageUrl="~/image/Contact-Details.png" Width="221px" />
                            <div id="sidebar1" >
                                <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/image/mid.jpg" 
                                    Height="253px" 
                                    style="font-size: x-large; font-weight: 700; text-align: center">
                                    <div class="style5">
                                        <br />
                                        <span class="style3">Birt Timmermans<br />
                                        kruiestroat road 1847690D<br />
                                        Cherry Hill, NJ 08034</span><br />
                                    </div>
                                    <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.7" 
                                        Rounded="True" TargetControlID="Panel2" TrackPosition="True" Radius="6" 
                                        Width="7">
                                    </cc1:DropShadowExtender>
                                </asp:Panel>
                        </div>
                            <div ID="sidebar2">
                                <asp:Panel ID="Panel3" runat="server" BackImageUrl="~/image/mid.jpg" 
                                    Height="255px" 
                                    style="text-align: center; font-size: x-large; font-weight: 700">
                                    <br />
                                    Telephone<br />
                                    mobile: + 32 42 52 63 74<br />
                                    home: + 32 11 39 13 40<br />
                                    website &amp; Email<br />
                                    <a href="http://www.Companyname.com">www.Companyname.com</a><br />
                                    Info@Cname.com<cc1:DropShadowExtender ID="DropShadowExtender2" runat="server" Opacity="0.7" 
                                        Rounded="True" TargetControlID="Panel3" TrackPosition="True" Radius="6" 
                                        Width="7">
                                    </cc1:DropShadowExtender>
                                </asp:Panel>
                        </div>
                    </div></td>
            </tr>
        </table>
        </div>
    </asp:Panel>
   
    
</asp:Content>

