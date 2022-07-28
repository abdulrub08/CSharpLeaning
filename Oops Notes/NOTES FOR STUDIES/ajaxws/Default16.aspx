<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default16.aspx.cs" Inherits="Default16" %>

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
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFCC66" Height="73px" 
        Width="252px">
        <b>Click me &amp; Drag me...</b>
    </asp:Panel>
    <cc1:DragPanelExtender ID="Panel1_DragPanelExtender" runat="server" 
        DragHandleID="Panel1" Enabled="True" TargetControlID="Panel1">
    </cc1:DragPanelExtender>
    </form>
</body>
</html>
