<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript" >
        function GetServerTime() {
            var prm;
            prm = Sys.WebForms.PageRequestManager.getInstance();
            prm._doPostBack('UpdatePanel1', '');
            setTimeout("GetServerTime()", 1000);
        }
   </script>    
</head>
<body onload="GetServerTime()">
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" onload="UpdatePanel1_Load">
            <ContentTemplate>
                <asp:Label ID="lblServerTime" runat="server" Font-Size="X-Large"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
