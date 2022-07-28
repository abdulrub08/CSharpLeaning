<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default22.aspx.cs" Inherits="Default22" %>

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
        Salary
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:MaskedEditExtender ID="TextBox1_MaskedEditExtender" runat="server" 
            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
            CultureName="te-IN" CultureThousandsPlaceholder="" CultureTimePlaceholder="" 
            DisplayMoney="Left" Enabled="True" Mask="9999.99" MaskType="Number" 
            TargetControlID="TextBox1">
        </cc1:MaskedEditExtender>
    </p>
    </form>
</body>
</html>
