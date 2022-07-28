<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RFinalBill.aspx.cs" Inherits="RFinalBill" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 94px;
        }
        .style3
        {
            width: 338px;
        }
        .style4
        {
            width: 323px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="551px" Width="1126px">
            <table class="style1">
                <tr>
                    <td class="style2" colspan="4">
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Registration No</td>
                    <td>
                        <asp:TextBox ID="txtRegNo" runat="server" CssClass="Textbox"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearch" runat="server" CssClass="Button" 
                            onclick="btnSearch_Click" Text="Search" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td colspan="2" style="text-align: center">
                        <asp:DetailsView ID="DetailsView1" runat="server" BackColor="White" 
                            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                            GridLines="Horizontal" Height="50px" Width="289px">
                            <FooterStyle BackColor="White" ForeColor="#333333" />
                            <RowStyle BackColor="White" ForeColor="#333333" />
                            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        </asp:DetailsView>
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Bed Details</td>
                    <td>
                        <asp:Button ID="btnPrintBedDetails" runat="server" CssClass="Button" 
                            Height="25px" onclick="btnPrintBedDetails_Click" Text="Print Bed Details" 
                            Width="171px" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Doctor Details</td>
                    <td>
                        <asp:Button ID="btnPrintDoctorDetails" runat="server" CssClass="Button" 
                            Height="26px" Text="Print Doctor Details" Width="171px" 
                            onclick="btnPrintDoctorDetails_Click" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Expense Details</td>
                    <td>
                        <asp:Button ID="btnPrintExpenseDetails" runat="server" CssClass="Button" 
                            Height="26px" Text="Print Expense Details" Width="171px" 
                            onclick="btnPrintExpenseDetails_Click" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Payment Details</td>
                    <td>
                        <asp:Button ID="btnPrintPaymentDetails" runat="server" CssClass="Button" 
                            Height="26px" Text="Print Payment Details" Width="171px" 
                            onclick="btnPrintPaymentDetails_Click" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="Text">
                        Discharge Slip</td>
                    <td>
                        <asp:Button ID="btnPrintDischargeSlip" runat="server" CssClass="Button" 
                            Height="26px" Text="Print Discharge Slip" Width="171px" 
                            onclick="btnPrintDischargeSlip_Click" />
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
