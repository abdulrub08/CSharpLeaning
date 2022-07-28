<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default27.aspx.cs" Inherits="Default27" %>

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
        Password
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:PasswordStrength ID="TextBox1_PasswordStrength" runat="server" 
            Enabled="True" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="2" 
            MinimumSymbolCharacters="2" MinimumUpperCaseCharacters="1" 
            PreferredPasswordLength="7" RequiresUpperAndLowerCaseCharacters="True" 
            TargetControlID="TextBox1">
        </cc1:PasswordStrength>
    </p>
    </form>
</body>
</html>
