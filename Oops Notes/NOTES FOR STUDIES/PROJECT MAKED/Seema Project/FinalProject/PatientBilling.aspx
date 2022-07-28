<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientBilling.aspx.cs" Inherits="PatientBilling" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 596px;
        }
        .style3
        {
            height: 372px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="636px">
                    <table class="style1">
                        <tr>
                            <td class="Text" colspan="2" style="text-align: center">
                                Registration No.:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddlRegNo" runat="server" AutoPostBack="True" 
                                    CssClass="Dropdownlist" 
                                    onselectedindexchanged="ddlRegNo_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                                <asp:Label ID="lblmsg1" runat="server" CssClass="msg"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center">
                                <asp:Button ID="btnGenerateTemporaryBill" runat="server" CssClass="Button" 
                                    Height="26px" Text="Generate Temporary Bill" Width="196px" 
                                    onclick="btnGenerateTemporaryBill_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style3" colspan="2">
                                <asp:Panel ID="Panel2" runat="server" Height="394px">
                                    <cc1:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="3" 
                                        Height="365px" Width="816px">
                                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Bed Details"><ContentTemplate><asp:GridView ID="GridView1" runat="server" BackColor="White" 
                                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                    GridLines="Horizontal"><FooterStyle BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /><SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /></asp:GridView><br /><br /><br /><asp:Label ID="lblTotalBedCharges" runat="server" CssClass="Text" 
                                                    Text="Total Bed Charges:"></asp:Label>&#160;&#160; <asp:Label ID="lblTBCharges" runat="server"></asp:Label></ContentTemplate></cc1:TabPanel>
                                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Doctor Details"><ContentTemplate><asp:GridView ID="GridView2" runat="server" BackColor="White" 
                                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                    GridLines="Horizontal"><FooterStyle BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /><SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /></asp:GridView><br /><br /><br /><asp:Label ID="lblTotalDoctorCharges" runat="server" CssClass="Text" 
                                                    Text="Total Doctor Charges:"></asp:Label>&#160;&#160;&#160;&#160;&#160; <asp:Label ID="lblTDCharges" runat="server"></asp:Label></ContentTemplate></cc1:TabPanel>
                                        <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Expense Details"><ContentTemplate><asp:GridView ID="GridView3" runat="server" BackColor="White" 
                                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                    GridLines="Horizontal"><FooterStyle BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /><SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /></asp:GridView><br /><asp:Label ID="lblTotalExpenseCharges" runat="server" CssClass="Text" 
                                                    Text="Total Expense Charges:"></asp:Label>&#160;&#160;&#160; <asp:Label ID="lblTECharges" runat="server"></asp:Label><br /><br /><br /><br /><br /></ContentTemplate></cc1:TabPanel>
                                        <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="Payment Details"><ContentTemplate><asp:GridView ID="GridView4" runat="server" BackColor="White" 
                                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                    GridLines="Horizontal" onselectedindexchanged="GridView4_SelectedIndexChanged"><FooterStyle BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /><SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /></asp:GridView><br /><br /><br /><asp:Label ID="lblTotalHospitalCharges" runat="server" CssClass="Text" 
                                                    Text="Total Hospital Charges:"></asp:Label>&#160;&#160;&#160; <asp:Label ID="lblTHCharges" runat="server">0</asp:Label><br /><asp:Label ID="lblTotalAdvancePayment" runat="server" CssClass="Text" 
                                                    Text="Total Advance Payment:"></asp:Label>&#160;&#160; <asp:Label ID="lblTAPayment" runat="server">0</asp:Label><br /><asp:Label ID="lblTotalDueAmount" runat="server" CssClass="Text" 
                                                    Text="Total Due Amount:"></asp:Label>&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; <asp:Label ID="lblTDAmount" runat="server">0</asp:Label><br /><asp:Label ID="lblTotalRefundAmount" runat="server" CssClass="Text" 
                                                    Text="Toal Refund Amount:"></asp:Label>&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; <asp:Label ID="lblTRAmount" runat="server">0</asp:Label><br /><br /><br /><br /><br /><br /><br /></ContentTemplate></cc1:TabPanel>
                                    </cc1:TabContainer>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center">
                                <asp:Button ID="btnGenerateFinalBill" runat="server" CssClass="Button" 
                                    Height="26px" onclick="btnGenerateFinalBill_Click" Text="Generate Final Bill" 
                                    Width="196px" Visible="False" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
