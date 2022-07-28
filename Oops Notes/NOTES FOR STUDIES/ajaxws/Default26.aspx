<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default26.aspx.cs" Inherits="Default26" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:BulletedList ID="BulletedList1" runat="server">
        <asp:ListItem>ANAND</asp:ListItem>
        <asp:ListItem>ANIL</asp:ListItem>
        <asp:ListItem>ANITHA</asp:ListItem>
        <asp:ListItem>BINDU</asp:ListItem>
        <asp:ListItem>BHASKAR</asp:ListItem>
        <asp:ListItem>CHARU</asp:ListItem>
        <asp:ListItem>CHANDRU</asp:ListItem>
        <asp:ListItem>DINESH</asp:ListItem>
        <asp:ListItem>SEKHAR</asp:ListItem>
        <asp:ListItem>SRINIVAS</asp:ListItem>
        <asp:ListItem>VIJAY</asp:ListItem>
    </asp:BulletedList>
    <cc1:PagingBulletedListExtender ID="BulletedList1_PagingBulletedListExtender" 
        runat="server" Enabled="True" SelectIndexCssClass="" 
        TargetControlID="BulletedList1" UnselectIndexCssClass="">
    </cc1:PagingBulletedListExtender>
    </form>
</body>
</html>
