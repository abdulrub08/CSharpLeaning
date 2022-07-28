<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
</script>
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
    
        <asp:Panel ID="Panel1" runat="server" Height="270px" Width="374px">
            <table class="style1">
                <tr>
                    <td>
                        Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hobbies<br />
                        <asp:CheckBox ID="chkSelectAll" runat="server" AutoPostBack="True" 
                            oncheckedchanged="chkSelectAll_CheckedChanged" Text="Select All" />
                    </td>
                    <td>
                        <asp:CheckBoxList ID="chklhobbies" runat="server" RepeatColumns="3">
                            <asp:ListItem>Music</asp:ListItem>
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Movies</asp:ListItem>
                            <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Browsing</asp:ListItem>
                            <asp:ListItem>Riding</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                            onclick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
