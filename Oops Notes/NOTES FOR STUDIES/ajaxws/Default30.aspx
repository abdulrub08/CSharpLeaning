<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default30.aspx.cs" Inherits="Default30" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
&nbsp;</p>
    <div>
    
        User name
        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtuser" Display="None" 
            ErrorMessage="User name cant be blank"></asp:RequiredFieldValidator>
        <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
        </cc1:ValidatorCalloutExtender>
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" Text="Continue" />
    </form>
</body>
</html>
