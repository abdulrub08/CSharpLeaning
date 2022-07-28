<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sale.aspx.cs" Inherits="Sale" %>

<%@ Register assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI" tagprefix="asp" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 99%;
            height: 499px;
        }
        .style2
        {
            width: 179px;
        }
        .style3
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Sale"></asp:Label>
        <br />
        <asp:LinkButton ID="lkhome" runat="server" onclick="lkhome_Click">Home</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Log-out</asp:LinkButton>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
            BorderStyle="Inset" Font-Bold="True" Font-Size="Large" Height="643px" 
            Width="989px">
            <table class="style1">
                <tr>
                    <td align="center" class="style2" rowspan="11">
                        <asp:Image ID="Image1" runat="server" Height="482px" ImageUrl="~/sale1.jpg" 
                            Width="380px" />
                    </td>
                    <td colspan="3">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sale Type*</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:RadioButtonList ID="rbtnsaletype" runat="server" 
                            onselectedindexchanged="rbtnsaletype_SelectedIndexChanged">
                            <asp:ListItem>Cash</asp:ListItem>
                            <asp:ListItem>Card</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sale Date*</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtsaledate" runat="server"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtsaledate_CalendarExtender" runat="server" 
                            Enabled="True" TargetControlID="txtsaledate">
                        </cc1:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        Remark</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtremark" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        Item Details</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Panel ID="Panel2" runat="server" BackColor="#CCFFCC" Height="136px">
                            <table class="style3">
                                <tr>
                                    <td>
                                        Item Name*</td>
                                    <td>
                                        Batch No*</td>
                                    <td>
                                        Qty*</td>
                                    <td>
                                        Sale Price</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlitemname" runat="server" DataSourceID="SqlDataSource1" 
                                            DataTextField="itemname" DataValueField="id" 
                                            onselectedindexchanged="ddlitemname_SelectedIndexChanged" 
                                            AutoPostBack="True">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                            ConnectionString="<%$ ConnectionStrings:RMSConnectionString29 %>" 
                                            SelectCommand="SELECT [id], [itemname] FROM [iteminfo]"></asp:SqlDataSource>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlbatchno" runat="server" 
                                            onselectedindexchanged="ddlbatchno_SelectedIndexChanged" 
                                            AutoPostBack="True">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtqty" runat="server" ontextchanged="txtqty_TextChanged"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblsaleprice" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="4">
                                        <br />
                                        <asp:Button ID="btnadditem" runat="server" BackColor="#999999" Font-Bold="True" 
                                            Font-Size="Medium" ForeColor="#408080" onclick="btnadditem_Click" 
                                            Text="Add Item" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td rowspan="5">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>
                        Amount*</td>
                    <td>
                        <asp:TextBox ID="txtamount" runat="server">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Tax*</td>
                    <td>
                        <asp:TextBox ID="txttax" runat="server">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Discount*</td>
                    <td>
                        <asp:TextBox ID="txtdiscount" runat="server">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Total Amount</td>
                    <td>
                        <asp:TextBox ID="txttoamt" runat="server">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" 
                            onclick="btnsubmit_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
