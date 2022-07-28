<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        &quot;Your Account Has Been Successfully Created To Activate It Please Contact To 
        Administrator&quot;</h1>
    <div>
    
    </div>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Login.aspx">Login 
    Page</asp:LinkButton>
    </form>
</body>
</html>
