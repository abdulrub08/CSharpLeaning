<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="autoCompleteDemo.aspx.cs" Inherits="AjaxToolkitDemo.autoCompleteDemo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
    </asp:ToolkitScriptManager>  
      
    <asp:TextBox ID="txtMovie" runat="server"></asp:TextBox>  
      
    <asp:AutoCompleteExtender   
        ID="AutoCompleteExtender1"   
        TargetControlID="txtMovie"   
        runat="server" UseContextKey="True" />  
    </div>
    </form>
</body>
</html>
