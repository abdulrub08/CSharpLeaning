<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default13.aspx.cs" Inherits="Default13" %>

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
        From Date
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
            Enabled="True" TargetControlID="TextBox1">
        </cc1:CalendarExtender>
    </p>
    <p>
        To Date
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
            Enabled="True" PopupButtonID="ImageButton1" TargetControlID="TextBox2">
        </cc1:CalendarExtender>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="25px" 
            ImageUrl="~/Calendar_schedule.bmp" Width="26px" 
            onclick="ImageButton1_Click" />
    </p>
    <asp:ImageButton ID="ImageButton2" runat="server" />
    </form>
</body>
</html>
