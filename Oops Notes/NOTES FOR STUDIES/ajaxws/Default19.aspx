<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default19.aspx.cs" Inherits="Default19" %>

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
        Only Numbers
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:FilteredTextBoxExtender ID="TextBox1_FilteredTextBoxExtender" 
            runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox1">
        </cc1:FilteredTextBoxExtender>
    </p>
    <p>
        Only Upper Case Charecters
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <cc1:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" 
            runat="server" Enabled="True" FilterType="UppercaseLetters" 
            TargetControlID="TextBox2">
        </cc1:FilteredTextBoxExtender>
    </p>
    <p>
        Valid Charecters
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <cc1:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox3" ValidChars="+-/*">
        </cc1:FilteredTextBoxExtender>
    </p>
    <p>
        Invalid Charecters
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <cc1:FilteredTextBoxExtender ID="TextBox4_FilteredTextBoxExtender" 
            runat="server" Enabled="True" FilterMode="InvalidChars" InvalidChars="+-/*=" 
            TargetControlID="TextBox4">
        </cc1:FilteredTextBoxExtender>
    </p>
    </form>
</body>
</html>
