<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stocktransfer.aspx.cs" Inherits="Stocktransfer" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Stock Transfer"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Log-out</asp:LinkButton>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
                    BorderStyle="Inset" Font-Bold="True" Font-Size="Large" Height="852px" 
                    Width="1269px" style="margin-right: 0px">
                    <table class="style1">
                        <tr>
                            <td align="center" rowspan="6">
                                <asp:Image ID="Image1" runat="server" Height="672px" 
                                    ImageUrl="~/saupload_inventory2.jpg" Width="450px" />
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Stock Transfer Date*<br />
                            </td>
                            <td>
                                <asp:TextBox ID="txtstdate" runat="server" Height="28px" Width="123px"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtstdate_CalendarExtender" runat="server" 
                                    Enabled="True" TargetControlID="txtstdate">
                                </cc1:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Stock&nbsp; Transfer No*<br />
                            </td>
                            <td>
                                <asp:TextBox ID="txtstno" runat="server" Height="28px" 
                                    ontextchanged="TextBox2_TextChanged" Width="123px"></asp:TextBox>
                                &nbsp;(Only Numeric)</td>
                        </tr>
                        <tr>
                            <td>
                                Remark<br />
                            </td>
                            <td>
                                <asp:TextBox ID="txtremark" runat="server" Height="28px" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Panel ID="Panel2" runat="server" BackColor="#99FFCC">
                                    <table class="style1">
                                        <tr>
                                            <td>
                                                Item Name*</td>
                                            <td>
                                                Batch No*</td>
                                            <td>
                                                Qty*</td>
                                            <td align="center" rowspan="2">
                                                <asp:Button ID="btnadditem" runat="server" BackColor="#CCFFCC" 
                                                    ForeColor="#CC0000" onclick="btnadditem_Click" Text="Add Item" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:DropDownList ID="ddlitemname" runat="server" AutoPostBack="True" 
                                                    DataSourceID="SqlDataSource1" DataTextField="itemname" DataValueField="id" 
                                                    ondatabound="join" onselectedindexchanged="ddlitemname_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString26 %>" 
                                                    SelectCommand="SELECT [itemname], [id] FROM [iteminfo]"></asp:SqlDataSource>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlbatchno" runat="server" AutoPostBack="True" 
                                                    ondatabound="join1" onselectedindexchanged="ddlbatchno_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtqty" runat="server" Height="26px" Width="80px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="GridView1" runat="server">
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center" colspan="2">
                                <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                                    Text="Submit" />
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
