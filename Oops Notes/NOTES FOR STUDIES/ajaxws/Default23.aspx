<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default23.aspx.cs" Inherits="Default23" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 99%;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Change Photo</asp:LinkButton>
    <cc1:ModalPopupExtender ID="LinkButton1_ModalPopupExtender" runat="server" 
        CancelControlID="btnClose" Drag="True" DynamicServicePath="" Enabled="True" 
        OkControlID="btnUpload" PopupControlID="PanelContent" 
        TargetControlID="LinkButton1">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="PanelContent" runat="server" Width="398px">
        <table class="style1" cellpadding="0" cellspacing="0" 
            style="border-style: solid; border-color: #000000;">
            <tr bgcolor="#316AC5" style="color: #FFFFFF">
                <td>
                    Upload Photo</td>
                <td align="right">
                    <asp:Button ID="btnClose" runat="server" BackColor="Red" BorderColor="White" 
                        BorderStyle="Solid" Font-Bold="True" ForeColor="White" Text="X" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    File name
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnUpload" runat="server" BackColor="#D9F8FF" Text="Upload" 
                        onclick="btnUpload_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
