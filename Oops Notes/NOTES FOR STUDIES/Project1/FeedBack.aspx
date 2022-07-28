<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="FeedBack" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 668px;
        }
        .style2
        {}
        .style3
        {
            height: 13px;
        }
        .style4
        {
            color: #666666;
        }
        .style5
        {
            text-align: right;
        }
        .style6
        {
            text-align: right;
        }
        .style7
        {
            text-align: right;
            height: 342px;
            width: 186px;
        }
        .style8
        {
            height: 342px;
        }
        .style9
        {
            text-align: right;
            width: 186px;
        }
        .style10
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>

    <asp:Panel ID="Panel1" runat="server" Height="898px">
        <table class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="Image1" runat="server" Height="83px" 
                        ImageUrl="~/image/Feedback.png" Width="325px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <h1 style="text-align: center">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; How Did We Today ?</h1>
                </td>
            </tr>
            <tr>
                <td style="text-align: right" colspan="2">
                    <div Align="center" 
                        style="background-color: #C0C0C0; height: 29px; font-weight: 700; font-size: x-large;">
                        Please use this form to provide feedback about our services</div></td>
            </tr>
            <tr>
            <td style="text-align: right" colspan="2"><div Align="center">
                <asp:Panel ID="Panel2" runat="server" Width="807px" BorderColor="#666666" 
                    BorderStyle="Outset" BorderWidth="2px" Height="671px">
                    <table class="style1">
                        <tr>
                            <td class="style9" style="text-align: right">
                                Your Name</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtname" runat="server" Width="277px"></asp:TextBox>
                                <asp:Label ID="lblname" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9" style="text-align: right">
                                Your Email-Id</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtemail" runat="server" Width="277px"></asp:TextBox>
                                <asp:Label ID="lblemail" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9" style="text-align: right" valign="top">
                                Date of Visite</td>
                            <td style="text-align: left; vertical-align:top;" align="left" valign="top">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                 
                                    <table class="style10">
                                        <tr>
                                            <td align="left" valign="middle">
                                                <asp:TextBox ID="txtdate" runat="server" Width="172px" Height="29px"></asp:TextBox>
                                    
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" 
                                    ImageUrl="~/image/calendar-blue.png" Width="45px" ImageAlign="Top" />
                                                <asp:Label ID="lbldate" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" 
                                        TargetControlID="txtdate" Format="MMMM d, yyyy" PopupButtonID="ImageButton1">
                                    </cc1:CalendarExtender></td>
                                        </tr>
                                    </table>
                                 
                                </ContentTemplate>
                                </asp:UpdatePanel>
                               
                            </td>
                        </tr>
                        <tr>
                            <td class="style3" colspan="2" style="text-align: center">
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" colspan="2" 
                                style="text-align: center; font-size: x-large; font-weight: 700">
                                Would you discribe your feedback as (<span class="style4">Tick where Appropriate</span>)</td>
                        </tr>
                        <tr>
                            <td class="style5" colspan="2">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                <asp:Panel ID="Panel3" runat="server" Height="35px" style="text-align: center">
                                    <asp:RadioButtonList ID="rdbcmmnttype" runat="server" AutoPostBack="True" 
                                        Height="33px" RepeatDirection="Horizontal" 
                                        style="font-weight: 700; font-size: large" Width="735px">
                                        <asp:ListItem>Complaint</asp:ListItem>
                                        <asp:ListItem>Compliment</asp:ListItem>
                                        <asp:ListItem>Comment</asp:ListItem>
                                        <asp:ListItem>Suggestion</asp:ListItem>
                                    </asp:RadioButtonList>
                                </asp:Panel>
                                </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr><td colspan="2" style="vertical-align:baseline; align:center;" 
                                align="center">
                            <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                            </td></tr>
                        <tr>
                            <td align="right" class="style7" style="text-align: right" valign="top">
                                Your FeedBack</td>
                            <td style="text-align: left" class="style8" valign="top">
                                <asp:TextBox ID="txtfeedback" runat="server" Height="339px" TextMode="MultiLine" 
                                    Width="546px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style9" style="text-align: right" valign="top">
                                &nbsp;</td>
                            <td style="text-align: left">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="31px" 
                                    ImageUrl="~/image/send.png" Width="151px" onclick="ImageButton2_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style6" colspan="2" style="text-align: left" 
                                valign="top">
                                PleasPut Completed forms into the SSID Suggestion Box or hand it SSID Front 
                                Desk&nbsp; Counter Thank You for Feedback.</td>
                        </tr>
                    </table>
                </asp:Panel>
                </div></td>
                
            </tr>
            
            
        </table>
    </asp:Panel>

</div>
</asp:Content>