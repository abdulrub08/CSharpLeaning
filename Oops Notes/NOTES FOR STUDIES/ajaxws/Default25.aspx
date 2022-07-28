<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default25.aspx.cs" Inherits="Default25" %>

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
        Enter your comments</p>
    <p>
        <asp:TextBox ID="txtmsg" runat="server" Height="93px" TextMode="MultiLine" 
            Width="353px"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Send" 
        style="height: 26px" />
    <p>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </p>
    <cc1:NoBot ID="NoBot1" runat="server" CutoffMaximumInstances="1" 
        ongeneratechallengeandresponse="NoBot1_GenerateChallengeAndResponse" 
        ResponseMinimumDelaySeconds="1" />
    </form>
</body>
</html>
