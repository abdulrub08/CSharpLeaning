<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default12.aspx.cs" Inherits="Default12" %>

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
        Search Text
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" 
            DelimiterCharacters="" Enabled="True" ServiceMethod="GetCompletionList" 
            ServicePath="" TargetControlID="TextBox1" UseContextKey="True">
        </cc1:AutoCompleteExtender>
    </p>
    </form>
</body>
</html>
