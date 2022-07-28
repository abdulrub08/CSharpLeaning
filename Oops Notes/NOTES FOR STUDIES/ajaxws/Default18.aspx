<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default18.aspx.cs" Inherits="Default18" %>

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
    <p>
        Without Shadow Effect
    </p>
    <asp:Panel ID="Panel1" runat="server" BackColor="#666699" ForeColor="White" 
        Width="269px">
        <asp:Login ID="Login1" runat="server">
        </asp:Login>
    </asp:Panel>
    <p>
        With Shadow Effect</p>
    <asp:Panel ID="Panel2" runat="server" BackColor="#666699" ForeColor="White" 
        Width="269px">
        <asp:Login ID="Login2" runat="server">
        </asp:Login>
    </asp:Panel>
    <cc1:DropShadowExtender ID="Panel2_DropShadowExtender" runat="server" 
        Enabled="True" TargetControlID="Panel2" Radius="10" Width="10">
    </cc1:DropShadowExtender>
    </form>
</body>
</html>
