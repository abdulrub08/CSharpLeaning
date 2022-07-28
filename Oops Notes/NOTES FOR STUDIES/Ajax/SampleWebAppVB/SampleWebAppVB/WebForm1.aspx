<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="SampleWebAppVB.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            Ajax Sample App</h1>
        <p>
            Date and Time is
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="#FF6600"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Refresh" />
        </p>
    
    </div>
    <p>
        &nbsp;</p>
    <h2>
        Ajax Component</h2>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Date and Time is
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="#9933FF"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Refresh" />
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
