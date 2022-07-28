<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
    
    </div>
    <asp:Panel ID="Panel1" runat="server" GroupingText="UpdatePanel Content">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <table class="style1">
                    <tr>
                        <td>
                            <asp:Label ID="lblUpdatePanel" runat="server" Font-Size="X-Large"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button in UpdatePanel" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" />
            </Triggers>            
        </asp:UpdatePanel>
    </asp:Panel>
    <p>
        <asp:Label ID="lblPage" runat="server" Font-Size="X-Large"></asp:Label>
    </p>
    <asp:Button ID="Button2" runat="server" Text="Button in Page" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" 
        Text="Button Registered with UpdatePanel" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" 
        Text="Button Registered with ScriptManager" />
    </form>
</body>
</html>
