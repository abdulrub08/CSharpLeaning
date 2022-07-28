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
    
        <asp:Panel ID="Panel1" runat="server" Height="258px" Width="273px">
            <table class="style1">
                <tr>
                    <td>
                        First No.</td>
                    <td>
                        <asp:TextBox ID="txtfirstno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Second No.</td>
                    <td>
                        <asp:TextBox ID="txtsecondno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnadd" runat="server" onclick="btnadd_Click" Text="Add" />
                        &nbsp;<asp:Button ID="btnmulitply" runat="server" onclick="btnmulitply_Click" 
                            Text="Mulitply" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#990033"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
