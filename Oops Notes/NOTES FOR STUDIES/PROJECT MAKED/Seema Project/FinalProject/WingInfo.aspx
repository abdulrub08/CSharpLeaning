<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WingInfo.aspx.cs" Inherits="WingInfo" %>

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
        .style2
        {
            height: 25px;
        }
        .style3
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Label ID="lblheading" runat="server" Text="Wing Info"></asp:Label>
    <br />
    <asp:Label ID="lblid" runat="server"></asp:Label>
    <asp:Label ID="lblmode" runat="server"></asp:Label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="340px" Width="448px">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                    Height="309px" Width="443px">
                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show Wing Info"><ContentTemplate><asp:GridView 
                        ID="GridView1" runat="server" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" 
                        BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal"><FooterStyle 
                        BackColor="White" ForeColor="#333333" /><RowStyle BackColor="White" 
                        ForeColor="#333333" /><PagerStyle BackColor="#336666" ForeColor="White" 
                        HorizontalAlign="Center" /><SelectedRowStyle BackColor="#339966" 
                        Font-Bold="True" ForeColor="White" /><HeaderStyle BackColor="#336666" 
                        Font-Bold="True" ForeColor="White" /></asp:GridView></ContentTemplate></cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Wing"><ContentTemplate><table class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" runat="server"></asp:Label></td></tr><tr><td 
                        class="Text">Wing Name*</td><td class="style3"><asp:TextBox 
                        ID="txtWingName" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                            class="Text">Floor No*</td><td class="style2"><asp:DropDownList 
                            ID="ddlFloorNo" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlFloorNo_SelectedIndexChanged" 
                            CssClass="Dropdownlist"></asp:DropDownList><br /></td></tr><tr><td 
                            class="Text">Description*</td><td><asp:TextBox 
                            ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                            class="Text">Remark</td><td><asp:TextBox 
                            ID="txtRemark" runat="server" TextMode="MultiLine" CssClass="Textbox"></asp:TextBox></td></tr><tr><td>&#160;</td><td><asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                                            Text="Submit" /></td></tr></table></ContentTemplate></cc1:TabPanel>
                </cc1:TabContainer>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
