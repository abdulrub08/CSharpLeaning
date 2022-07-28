<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body bgcolor="White">
    <form id="form1" runat="server">
    <div style="background-color: #FFFFFF">
    
        <table class="style1">
            <tr>
                <td>
                    RollNumber*</td>
                <td>
                    <asp:TextBox ID="txtRollno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Name*</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Gender*</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Male" />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Female" />
                </td>
            </tr>
            <tr>
                <td>
                    Address*</td>
                <td>
                    <asp:TextBox ID="txtadd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Class*</td>
                <td>
                    <asp:DropDownList ID="ddlclass" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Father&#39;s Name</td>
                <td>
                    <asp:TextBox ID="txtfathername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Cast*</td>
                <td>
                    <asp:DropDownList ID="ddlcast" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Old&nbsp; School Name</td>
                <td>
                    <asp:TextBox ID="txtoldschoolname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Hobbies*</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="3">
                        <asp:ListItem>Cricket</asp:ListItem>
                        <asp:ListItem>Music</asp:ListItem>
                        <asp:ListItem>Movie</asp:ListItem>
                        <asp:ListItem>Books</asp:ListItem>
                        <asp:ListItem>Hockey</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td>
                    Optional Subject*</td>
                <td>
                    <asp:DropDownList ID="ddloptionalsubject" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnnew" runat="server" Height="30px" Text="New" Width="60px" />
                </td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Height="30px" Text="Submit" 
                        Width="60px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
