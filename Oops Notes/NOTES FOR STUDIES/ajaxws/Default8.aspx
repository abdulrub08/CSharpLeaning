<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript" >
        function onTimeout(data) {
        }
        function onError(data) {
        }
        function onSuccess(data) {
            document.getElementById("lblTime").innerHTML = data;
        }
        function GetServerTime() {
            WebService4ajax.GetServerTime(onSuccess, onError, onTimeout);
            setTimeout("GetServerTime()", 1000);
        }
    </script>
</head>
<body onload="GetServerTime()" >
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
        <asp:ServiceReference Path="~/WebService4ajax.asmx" />
        </Services>
        </asp:ScriptManager>
        <br />
    
    </div>
    <asp:Label ID="lblTime" runat="server" Font-Size="X-Large"></asp:Label>
    </form>
</body>
</html>
