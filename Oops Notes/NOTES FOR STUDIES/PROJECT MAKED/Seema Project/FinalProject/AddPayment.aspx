<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddPayment.aspx.cs" Inherits="AddPayment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="497px" Width="621px">
                    <table class="style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Registration No.*</td>
                            <td>
                                <asp:DropDownList ID="ddlRegNo" runat="server" AutoPostBack="True" 
                                    CssClass="Dropdownlist" 
                                    onselectedindexchanged="ddlRegNo_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnShow" runat="server" CssClass="Button" Text="Show" 
                                    onclick="btnShow_Click" />
                            </td>
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
                        <tr>
                            <td class="Text">
                                Amount*</td>
                            <td>
                                <asp:TextBox ID="txtAmount" runat="server" CssClass="Textbox">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Tax*</td>
                            <td>
                                <asp:TextBox ID="txtTax" runat="server" CssClass="Textbox">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Discount*</td>
                            <td>
                                <asp:TextBox ID="txtDiscount" runat="server" CssClass="Textbox">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Total Amount*</td>
                            <td>
                                <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="Textbox">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Description</td>
                            <td>
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnSubmit" runat="server" CssClass="Button" Text="Submit" 
                                    onclick="btnSubmit_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                <asp:Button ID="btnCFUpdate" runat="server" CssClass="Button" Height="26px" 
                                    onclick="btnCFUpdate_Click" Text="Click For Update" Width="127px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
