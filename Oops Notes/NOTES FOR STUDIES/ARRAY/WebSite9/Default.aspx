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
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCFF" BorderColor="#666633" 
            BorderStyle="Inset" Font-Size="Large" ForeColor="Maroon" Height="160px" 
            Width="309px">
            <table class="style1">
                <tr>
                    <td>
                        Login Name</td>
                    <td>
                        <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" 
                            ontextchanged="txtPwd_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogIn" runat="server" onclick="btnLogIn_Click" 
                            Text="Log-In" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
