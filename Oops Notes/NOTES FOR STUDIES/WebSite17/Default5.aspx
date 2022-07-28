<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 333px;
        }
        .style2
        {
            width: 38px;
        }
        .style3
        {
            width: 38px;
            height: 53px;
        }
        .style4
        {
            width: 60px;
        }
    </style>
</head>
<body style="height: 482px">
    <form id="form1" runat="server">
    <div style="height: 481px">
    
        <asp:Panel ID="Panel1" runat="server" Height="408px">
            <table class="style1">
                <tr>
                    <td bgcolor="#669900" rowspan="4" class="style4" width="33%">
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
                    <td bgcolor="#3399FF" class="style2" width="33%">
                        <asp:Button ID="btn1" runat="server" Height="40px" Text="&gt;" Width="40px" 
                            BackColor="#669900" />
                    </td>
                    <td bgcolor="#669900" rowspan="4" style="background-color: #808000" width="33%">
                        <asp:ListBox ID="lst2" runat="server" Height="270px" Width="165px">
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#3399FF" class="style2">
                        <asp:Button ID="btn2" runat="server" Height="40px" Text="&lt;" Width="40px" 
                            BackColor="#669900" />
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#3399FF" class="style2">
                        <asp:Button ID="btn3" runat="server" Height="40px" Text="&gt;&gt;" 
                            Width="40px" BackColor="#669900" />
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#3399FF" class="style3">
                        <asp:Button ID="btn4" runat="server" Height="40px" Text="&lt;&lt;" 
                            Width="40px" BackColor="#669900" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
