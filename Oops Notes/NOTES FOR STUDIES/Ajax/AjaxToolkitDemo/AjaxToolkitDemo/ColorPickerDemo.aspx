<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColorPickerDemo.aspx.cs" Inherits="AjaxToolkitDemo.ColorPickerDemo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language =javascript >
        function colorChanged(sender) {
            sender.get_element().style.color =
       "#" + sender.get_selectedColor();
        }   
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
    </asp:ToolkitScriptManager>  
      
    <asp:ColorPickerExtender runat="server"   
    ID="ColorPickerExtender1"  
    TargetControlID="Color1"  
    OnClientColorSelectionChanged="colorChanged" />  
    </div>
    
    <asp:TextBox ID="Color1" runat="server"></asp:TextBox>
   
    
    </form>
</body>
</html>
