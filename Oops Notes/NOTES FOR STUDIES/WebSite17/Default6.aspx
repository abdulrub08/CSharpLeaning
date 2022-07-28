<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="436px" Width="718px">
            <table class="style1">
                <tr>
                    <td align="center" rowspan="4" width="40%">
                        <asp:ListBox ID="lst1" runat="server" Height="270px" Width="165px">
                            <asp:ListItem>Kanpur</asp:ListItem>
                            <asp:ListItem>Lucknow</asp:ListItem>
                            <asp:ListItem>Udaypur</asp:ListItem>
                            <asp:ListItem>Agra</asp:ListItem>
                            <asp:ListItem>Mathura</asp:ListItem>
                            <asp:ListItem>Jabalpur</asp:ListItem>
                            <asp:ListItem>Bilhaur</asp:ListItem>
                            <asp:ListItem>Hamirpur</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td align="center">
                        <asp:Button ID="btn1" runat="server" onclick="btn1_Click" Text="&gt;" />
                    </td>
                    <td align="center" rowspan="4" width="40%">
                        <asp:ListBox ID="lst2" runat="server" Height="270px" Width="165px">
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btn2" runat="server" onclick="btn2_Click" Text="&lt;" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btn3" runat="server" onclick="btn3_Click" Text="&gt;&gt;" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btn4" runat="server" Text="&lt;&lt;" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td width="40%">
                        <br />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td width="40%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td width="40%">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td width="40%">
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
