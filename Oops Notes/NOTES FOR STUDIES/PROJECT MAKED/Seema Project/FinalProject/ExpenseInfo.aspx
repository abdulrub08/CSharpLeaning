<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpenseInfo.aspx.cs" Inherits="ExpenseInfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 242px;
        }
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            font-style: normal;
            color: #0c3e74;
            height: 25px;
            text-align: center;
        }
        .style3
        {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Label ID="lblheading" runat="server" Text="Expense Info"></asp:Label>
        <br />
        <asp:Label ID="lblid" runat="server"></asp:Label>
        <asp:Label ID="lblmode" runat="server"></asp:Label>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="332px" Width="493px">
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                        Height="302px" Width="475px">
                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show All Expense Info"><ContentTemplate><asp:GridView ID="GridView1" runat="server" 
                                AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" 
                                BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged"><FooterStyle 
                                BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /><SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /></asp:GridView></ContentTemplate></cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Expense Info"><ContentTemplate><asp:Panel ID="Panel2" runat="server" Height="269px"><table 
                                class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" runat="server"></asp:Label></td></tr><tr><td 
                                class="Text">Expense Name*</td><td><asp:TextBox ID="txtExpenseName" 
                                    runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                                    class="Text">Description*</td><td><asp:TextBox ID="txtDescription" 
                                        runat="server" CssClass="Textbox" TextMode="MultiLine"></asp:TextBox></td></tr><tr><td 
                                    class="Text">Charges*</td><td><asp:TextBox ID="txtCharges" runat="server" 
                                        CssClass="Textbox"></asp:TextBox></td></tr><tr><td class="Text">Remark</td><td><asp:TextBox 
                                    ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                                    class="style2">Tax Charges</td><td class="style3">
                                    <asp:TextBox ID="txttaxchrg" runat="server" CssClass="Textbox"></asp:TextBox>
                                </td></tr><tr><td class="Text">Discount</td><td>
                                <asp:TextBox ID="txtdiscount" runat="server" CssClass="Textbox"></asp:TextBox>
                                </td></tr>
                            <tr>
                                <td class="Text">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnsbmt" runat="server" onclick="btnsbmt_Click" Text="Submit" />
                                </td>
                            </tr>
                            </table></asp:Panel></ContentTemplate></cc1:TabPanel>
                    </cc1:TabContainer>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
