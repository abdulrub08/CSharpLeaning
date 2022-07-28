<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VContactUs.aspx.cs" Inherits="VContactUs" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: normal;
            font-style: normal;
            color: #0c3e74;
            font-weight: bold;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="373px" Width="517px">
            <table class="style1">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="Text">
                        From Date:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtFromDate" runat="server" CssClass="Textbox"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtFromDate_CalendarExtender" runat="server" 
                            Enabled="True" TargetControlID="txtFromDate">
                        </cc1:CalendarExtender>
                    </td>
                    <td class="style4">
                        To Date:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtToDate" runat="server" CssClass="Textbox"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtToDate_CalendarExtender" runat="server" 
                            Enabled="True" TargetControlID="txtToDate">
                        </cc1:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnShow" runat="server" CssClass="Button" 
                            onclick="btnShow_Click" Text="Show" />
                    </td>
                    <td>
                        <asp:Button ID="btnPrint" runat="server" CssClass="Button" 
                            onclick="btnPrint_Click" Text="Print" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                            GridLines="Horizontal">
                            <FooterStyle BackColor="White" ForeColor="#333333" />
                            <RowStyle BackColor="White" ForeColor="#333333" />
                            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
