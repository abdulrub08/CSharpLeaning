<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default14.aspx.cs" Inherits="Default14" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 99%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Panel ID="PanelHeader" runat="server" Height="25px" Width="275px">
        <table class="style1" style="background-color: #FF9900; color: #FFFFFF;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td align="right">
                    <asp:Image ID="Image1" runat="server" Height="17px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelContent" runat="server" Height="159px" Width="274px">
        <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333" Height="146px" Width="266px">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
    </asp:Panel>
    <cc1:CollapsiblePanelExtender ID="PanelContent_CollapsiblePanelExtender" 
        runat="server" CollapseControlID="PanelHeader" 
        CollapsedImage="expand_large.bmp" CollapsedText="Show Login" Enabled="True" 
        ExpandControlID="PanelHeader" ExpandedImage="collapse_large.bmp" 
        ExpandedText="Hide Login" ImageControlID="Image1" 
        TargetControlID="PanelContent" TextLabelID="Label1">
    </cc1:CollapsiblePanelExtender>
    </form>
</body>
</html>
