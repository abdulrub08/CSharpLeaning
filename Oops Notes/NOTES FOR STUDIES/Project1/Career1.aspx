<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Career1.aspx.cs" Inherits="Career1" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 489px;
            width: 644px;
        }
        .style2
        {
            width: 138px;
        }
        .style3
        {
            width: 140px;
        }
        .style4
        {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server" Height="897px">
    <center style="height: 897px">
    
        <asp:Image ID="Image1" runat="server" Height="57px" 
            ImageUrl="~/image/career.png" Width="356px" />
        <br />
        <asp:Panel ID="Panel3" runat="server" BackColor="#FFFFCC" Height="510px" 
            Width="650px">
        <table class="style1">
            
            <tr>
                <td class="style4" style="text-align: right" align="right">
                    &nbsp;Enter Your Name :</td>
                <td class="style2" style="text-align: left">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Missing Your Name" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td style="text-align: right" align="right" class="style4">
                    Enter Your Sir Name :</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Missing Your Sir Name" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right" align="right" class="style4">
                    Education :</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="Missing Education" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right" align="right" class="style4">
                    Sex :</td>
                <td style="text-align: left">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="text-align: right" class="style4" align="right">
                    Job Profile : </td>
                <td style="text-align: left" class="style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    
                </td>
            </tr>
            
            
            
            
            
            
            <tr>
                <td style="text-align: right" align="right" class="style4">
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Attache File</asp:LinkButton>
                </td>
                <td style="text-align: left">
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="22px" />
                    <asp:Button ID="Button1" runat="server" Height="22px" Text="Upload" 
                        Width="58px" onclick="Button1_Click1" />
                </td>
            </tr>
            <tr><td colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FC0000"></asp:Label>
                <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
                </td></tr>
            
            <tr>
                <td style="text-align: right" class="style4">
                    &nbsp;</td>
                <td style="text-align: left">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" 
                        ImageUrl="~/SubmitButton_teaser - Copy.jpg" onclick="ImageButton1_Click" />
                </td>
            </tr>
            
            <tr>
                <td colspan="2" style="text-align: left">
                    <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.7" 
                        Radius="6" Rounded="True" TargetControlID="Panel3" TrackPosition="True" 
                        Width="7">
                    </cc1:DropShadowExtender>
                </td>
            </tr>
            
        </table>
        </asp:Panel>
        
    
    
        
    </center>
    
    </asp:Panel>
</asp:Content>

