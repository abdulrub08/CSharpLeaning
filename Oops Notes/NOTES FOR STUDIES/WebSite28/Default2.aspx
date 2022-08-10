<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 53%;
        }
        .style3
        {
        }
        .style4
        {
            width: 42px;
        }
        .style5
        {
            width: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#669900" BorderColor="#FF9900" 
            BorderStyle="Double" Height="700px" Width="1300px">
            <table class="style1">
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td rowspan="15">
                        <asp:ListBox ID="lstdetail" runat="server" Height="474px" Width="323px">
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        RollNumber*</td>
                    <td class="style4">
                        <asp:TextBox ID="txtrollnumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        StudentName*</td>
                    <td class="style4">
                        <asp:TextBox ID="txtstudentname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Gender*</td>
                    <td class="style4">
                        <asp:RadioButton ID="rbtmale" runat="server" 
                            oncheckedchanged="rbtmale_CheckedChanged" Text="Male" 
                            AutoPostBack="True" />
                        <br />
                        <asp:RadioButton ID="rbtfemale" runat="server" 
                            oncheckedchanged="rbtfemale_CheckedChanged" Text="Female" 
                            AutoPostBack="True" />
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Address*</td>
                    <td class="style4">
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Class*</td>
                    <td class="style4">
                        <asp:DropDownList ID="ddlclass" runat="server">
                            <asp:ListItem>--Select a class--</asp:ListItem>
                            <asp:ListItem>10th</asp:ListItem>
                            <asp:ListItem>12th</asp:ListItem>
                            <asp:ListItem>graduation</asp:ListItem>
                            <asp:ListItem>post graduation</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Father&#39;s Name</td>
                    <td class="style4">
                        <asp:TextBox ID="txtfathername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Cast*</td>
                    <td class="style4">
                        <asp:DropDownList ID="ddlcast" runat="server">
                            <asp:ListItem>--Select a cast</asp:ListItem>
                            <asp:ListItem>s.c</asp:ListItem>
                            <asp:ListItem>s.t</asp:ListItem>
                            <asp:ListItem>o.b.c</asp:ListItem>
                            <asp:ListItem>gen</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Old School Name</td>
                    <td class="style4">
                        <asp:TextBox ID="txtoldschoolname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Hobbies*</td>
                    <td class="style4">
                        <asp:RadioButtonList ID="rbtlhobbies" runat="server" RepeatColumns="3">
                            <asp:ListItem>music</asp:ListItem>
                            <asp:ListItem>movie</asp:ListItem>
                            <asp:ListItem>cricket</asp:ListItem>
                            <asp:ListItem>hockey</asp:ListItem>
                            <asp:ListItem>books</asp:ListItem>
                            <asp:ListItem>dansing</asp:ListItem>
                            <asp:ListItem>singing</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Optional Subject*</td>
                    <td class="style4">
                        <asp:DropDownList ID="ddloptionalsubject" runat="server">
                            <asp:ListItem>select subject</asp:ListItem>
                            <asp:ListItem>computer</asp:ListItem>
                            <asp:ListItem>dancing</asp:ListItem>
                            <asp:ListItem>singing</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        <asp:Button ID="btnnew" runat="server" Text="New" onclick="btnnew_Click" />
                    </td>
                    <td class="style4">
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" 
                            onclick="btnsubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="style3" colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td align="center" class="style4">
                        &nbsp;</td>
                    <td align="center">
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
