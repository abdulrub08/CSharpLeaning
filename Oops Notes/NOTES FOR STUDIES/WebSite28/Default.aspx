<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="262px" Width="351px">
            <table class="style1">
                <tr>
                    <td>
                        Name *</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender *</td>
                    <td>
                        <asp:RadioButton ID="rbtMale" runat="server" AutoPostBack="True" 
                            oncheckedchanged="rbtMale_CheckedChanged" Text="Male" />
                        <br />
                        <asp:RadioButton ID="rbtFeMale" runat="server" AutoPostBack="True" 
                            oncheckedchanged="rbtFeMale_CheckedChanged" Text="FeMale" />
                    </td>
                </tr>
                <tr>
                    <td>
                        City *</td>
                    <td>
                        <asp:DropDownList ID="ddlcity" runat="server">
                            <asp:ListItem>--Select a city--</asp:ListItem>
                            <asp:ListItem>Kanpur</asp:ListItem>
                            <asp:ListItem>Agra</asp:ListItem>
                            <asp:ListItem>Tirupati</asp:ListItem>
                            <asp:ListItem>Hyderabad</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Qualification</td>
                    <td>
                        <asp:RadioButtonList ID="rbtlQualification" runat="server" 
                            RepeatDirection="Horizontal">
                            <asp:ListItem>10th</asp:ListItem>
                            <asp:ListItem>12th</asp:ListItem>
                            <asp:ListItem>Graduate</asp:ListItem>
                            <asp:ListItem>PG</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                            Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
