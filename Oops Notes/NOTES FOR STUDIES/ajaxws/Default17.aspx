<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default17.aspx.cs" Inherits="Default17" %>

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
        <br />
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Select a Service" Width="200px"></asp:Label>
    <cc1:DropDownExtender ID="Label1_DropDownExtender" runat="server" 
        DropDownControlID="PanelMenu" DynamicServicePath="" Enabled="True" 
        TargetControlID="Label1">
    </cc1:DropDownExtender>
    <asp:Panel ID="PanelMenu" runat="server" BackColor="#FFDB91" Height="82px" 
        Width="200px">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default12.aspx">Development</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default6.aspx">Services</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Default3.aspx">Marketing</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Default11.aspx">Training</asp:HyperLink>
    </asp:Panel>
    </form>
</body>
</html>
