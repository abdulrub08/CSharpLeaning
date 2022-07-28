<%@ Page Language="C#" AutoEventWireup="true" CodeFile="purchaseinfo.aspx.cs" Inherits="purchageinfo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void ddlpartyname_DataBound(object sender, EventArgs e)
    {

    }

    protected void join(object sender, EventArgs e)
    {
        ddlpartyname.Items.Insert(0,"-- Select the party name --");
    }

    protected void ddlitemname_DataBound(object sender, EventArgs e)
    {
        ddlitemname.Items.Insert(0,"-- Select The item name --");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 93%;
            height: 568px;
        }
        .style2
        {
            width: 100%;
            height: 144px;
        }
        .style3
        {
            height: 206px;
        }
        .style4
        {
            width: 97%;
            height: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Purchase Information Form"></asp:Label>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
                    BorderStyle="Inset" Height="1844px" Font-Bold="True" Font-Size="Large" 
                    Width="1267px">
                    <table class="style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Purchase Type*</td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RadioButtonList ID="rdbtnpurchasetype" runat="server">
                                    <asp:ListItem>Cash</asp:ListItem>
                                    <asp:ListItem>Credit</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Purchase Date*</td>
                            <td>
                                <asp:TextBox ID="txtpurdate" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtpurdate_CalendarExtender" runat="server" 
                                    Enabled="True" TargetControlID="txtpurdate">
                                </cc1:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Purchase Bill No*</td>
                            <td>
                                <asp:TextBox ID="txtpurbillno" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Party Name*</td>
                            <td>
                                <asp:DropDownList ID="ddlpartyname" runat="server" AutoPostBack="True" 
                                    DataSourceID="SqlDataSource1" DataTextField="partyname" 
                                    DataValueField="partyname" ondatabound="join">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString5 %>" 
                                    SelectCommand="SELECT [partyname] FROM [partyinfo]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Remark</td>
                            <td>
                                <asp:TextBox ID="txtremark" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3" colspan="2">
                                Item Details<br />
                                <asp:Panel ID="Panel2" runat="server" BackColor="#CCFFCC" Height="146px" 
                                    Width="1250px">
                                    <table class="style2">
                                        <tr>
                                            <td>
                                                Item Name*</td>
                                            <td>
                                                Batch No*</td>
                                            <td>
                                                Mfg Date</td>
                                            <td>
                                                Exp Date</td>
                                            <td>
                                                Qty*</td>
                                            <td>
                                                Purchase Price*</td>
                                            <td>
                                                Sale Price*</td>
                                            <td>
                                                Mrp*</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:DropDownList ID="ddlitemname" runat="server" AutoPostBack="True" 
                                                    DataSourceID="SqlDataSource2" DataTextField="itemname" 
                                                    DataValueField="itemname" ondatabound="ddlitemname_DataBound">
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString6 %>" 
                                                    SelectCommand="SELECT [itemname] FROM [iteminfo]"></asp:SqlDataSource>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtbatchno" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtmfgdate" runat="server" Width="90px"></asp:TextBox>
                                                <cc1:CalendarExtender ID="txtmfgdate_CalendarExtender" runat="server" 
                                                    Enabled="True" TargetControlID="txtmfgdate">
                                                </cc1:CalendarExtender>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtexpdate" runat="server" Width="90px"></asp:TextBox>
                                                <cc1:CalendarExtender ID="txtexpdate_CalendarExtender" runat="server" 
                                                    Enabled="True" TargetControlID="txtexpdate">
                                                </cc1:CalendarExtender>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtqty" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtpurprice" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtsaleprice" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtmrp" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="8">
                                                <br />
                                                <asp:Button ID="btnadditem" runat="server" BackColor="#CCFFFF" 
                                                    BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="Maroon" 
                                                    onclick="btnadditem_Click" Text="Add Item" />
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="8">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="8">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                <asp:GridView ID="GridView1" runat="server" 
                                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                                </asp:GridView>
                            </td>
                            <td class="style3">
                                <asp:Panel ID="Panel3" runat="server" BackColor="#CCFFCC" Height="154px" 
                                    Width="550px">
                                    <table class="style4">
                                        <tr>
                                            <td>
                                                Total Purchase Amount</td>
                                            <td>
                                                <asp:Label ID="lbltopuramount" runat="server" ForeColor="#CC0000">0</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Tax</td>
                                            <td>
                                                <asp:TextBox ID="txttax" runat="server">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Discount</td>
                                            <td>
                                                <asp:TextBox ID="txtdiscount" runat="server" Height="19px">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Grand Total</td>
                                            <td>
                                                <asp:TextBox ID="txtgrandtotal" runat="server">0</asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="style3" colspan="2">
                                <asp:Button ID="btnsubmit" runat="server" Text="Submit" 
                                    onclick="btnsubmit_Click" />
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
