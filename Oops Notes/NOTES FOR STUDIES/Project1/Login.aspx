<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel ID="Panel13" runat="server" Height="370px" 
        style="background-color:Transparent" Width="1314px">
        
            
                            <asp:Panel ID="Panel15" runat="server" Height="370px" Width="1314px">
                            <center>
        <h3> Enter the information<br /></h3>
                                Login Name :&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Missing User Name!" Display="None"></asp:RequiredFieldValidator><cc1:ValidatorCalloutExtender
                ID="ValidatorCalloutExtender1" runat="server" TargetControlID="RequiredFieldValidator2">
            </cc1:ValidatorCalloutExtender>
        <br /><br />&nbsp;&nbsp;&nbsp; Password :&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rong Password ! " Display="None" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" 
                ImageUrl="~/image/Login.png" Width="111px" />
                                <br />
                                <asp:LinkButton ID="LinkButton1" runat="server">Click Here To forget Password</asp:LinkButton>
        </center>
                            </asp:Panel>
                       
        
        </asp:Panel>
    <cc1:AlwaysVisibleControlExtender ID="AlwaysVisibleControlExtender1" 
        runat="server" HorizontalSide="Center" TargetControlID="Panel13" 
        VerticalSide="Middle">
    </cc1:AlwaysVisibleControlExtender>
    </form>
</body>
</html>
