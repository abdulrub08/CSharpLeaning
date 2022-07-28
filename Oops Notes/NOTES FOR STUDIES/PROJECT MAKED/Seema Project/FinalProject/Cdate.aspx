<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cdate.aspx.cs" Inherits="Cdate" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 142px;
        }
        .style2
        {
            height: 29px;
            text-align: center;
        }
        .style3
        {
            width: 100%;
            height: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Panel ID="Panel1" runat="server" Height="107px" Width="440px">
                    <table class="style3">
                        <tr>
                            <td style="text-align: left">
                                <asp:Label ID="lblSelectDate" runat="server" Text="Select Date*" 
                                    CssClass="Text"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtSelectDate" runat="server" style="text-align: left"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtSelectDate_CalendarExtender" runat="server" 
                                    Enabled="True" PopupButtonID="Image1" TargetControlID="txtSelectDate"></cc1:CalendarExtender>
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Calendar_schedule.bmp" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                &nbsp;</td>
                            <td align="left">
                                <asp:Button ID="btnContinue" runat="server" onclick="btnContinue_Click" 
                                    Text="Continue" CssClass="Button" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left" colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
