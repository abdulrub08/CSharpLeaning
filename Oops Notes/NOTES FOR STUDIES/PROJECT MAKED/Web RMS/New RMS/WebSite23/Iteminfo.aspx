<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Iteminfo.aspx.cs" Inherits="Iteminfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Join(object sender, EventArgs e)
    {
        ddlcompanyname.Items.Insert(0,"-- Select the Company name --");

    }

    protected void Join1(object sender, EventArgs e)
    {
        ddlgroupname.Items.Insert(0,"-- Select a group name --");

    }

    protected void Join2(object sender, EventArgs e)
    {
        ddlunitname.Items.Insert(0,"-- Select a unit name --");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 2098px; height: 963px">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Item Information Form"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblid" runat="server"></asp:Label>
&nbsp;
        <asp:Label ID="lblmode" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Log-out</asp:LinkButton>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="639px">
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                        Width="915px" Height="48px">
                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show All Item"><ContentTemplate><asp:Panel 
                            ID="Panel5" runat="server" BackColor="#FFCCFF" 
                                BorderColor="#990033" BorderStyle="Inset" Height="891px" 
                            Width="2093px"><asp:GridView 
                                ID="GridView1" runat="server" AutoGenerateSelectButton="True" Height="267px" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" Width="395px"></asp:GridView></asp:Panel></ContentTemplate></cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Item"><ContentTemplate><asp:Panel ID="Panel2" runat="server" BackColor="#FFCCFF" 
                                BorderColor="#990033" BorderStyle="Inset" Height="1643px" Width="2099px"><table 
                                class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" runat="server" 
                                    ForeColor="#CC0000"></asp:Label></td><td align="center" rowspan="12"><asp:Image 
                                        ID="Image1" runat="server" Height="580px" ImageUrl="~/item1.gif" 
                                        Width="663px" />
                                </td></tr><tr><td>Item Name*</td><td><asp:TextBox ID="txtitemname" runat="server"></asp:TextBox></td></tr><tr><td>Company Name*</td><td><asp:DropDownList 
                                ID="ddlcompanyname" runat="server" 
                                                DataSourceID="SqlDataSource1" DataTextField="companyname" 
                                                DataValueField="companyname" 
                                                
                                OnSelectedIndexChanged="ddlcompanyname_SelectedIndexChanged" ondatabound="Join"><asp:ListItem>Select the Company Name</asp:ListItem></asp:DropDownList><asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:RMSConnectionString2 %>" 
                                                SelectCommand="SELECT [companyname] FROM [companyinfo]"></asp:SqlDataSource></td></tr><tr><td>Group Name*</td><td><asp:DropDownList ID="ddlgroupname" runat="server" 
                                                DataSourceID="SqlDataSource2" DataTextField="groupname" 
                                                DataValueField="groupname" ondatabound="Join1"></asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:RMSConnectionString3 %>" 
                                                SelectCommand="SELECT [groupname] FROM [groupinfo]"></asp:SqlDataSource></td></tr><tr><td>Unit Name*</td><td><asp:DropDownList ID="ddlunitname" runat="server" DataSourceID="SqlDataSource3" 
                                                DataTextField="unitname" DataValueField="unitname" 
                                        ondatabound="Join2"></asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:RMSConnectionString4 %>" 
                                                SelectCommand="SELECT [unitname] FROM [unitinfo]"></asp:SqlDataSource></td></tr><tr><td>Opening Stock*</td><td><asp:TextBox ID="txtopeningstock" runat="server"></asp:TextBox></td></tr><tr><td 
                                        colspan="2">Sale<br /><asp:Panel ID="Panel3" runat="server" 
                                        BackColor="#99FFCC" Height="60px" Width="812px"><table class="style1"><tr><td>Quantity*</td><td>Reorder Level*</td></tr><tr><td><asp:TextBox 
                                                ID="txtsquantity" runat="server"></asp:TextBox></td><td><asp:TextBox 
                                                    ID="txtsreorder" runat="server"></asp:TextBox></td></tr></table></asp:Panel></td></tr><tr><td 
                                    colspan="2">Main<br /><asp:Panel ID="Panel4" runat="server" 
                                    BackColor="#99FFCC" Height="48px" Width="808px"><table class="style1"><tr><td>Quantity*</td><td>Reorder Level*</td></tr><tr><td><asp:TextBox 
                                            ID="txtmquantity" runat="server"></asp:TextBox></td><td><asp:TextBox 
                                                ID="txtmreorder" runat="server"></asp:TextBox></td></tr></table></asp:Panel></td></tr><tr><td>Market Price</td><td><asp:TextBox ID="txtmrp" runat="server"></asp:TextBox></td></tr><tr><td>Sale Price</td><td><asp:TextBox ID="txtsaleprice" runat="server"></asp:TextBox></td></tr><tr><td>Remark</td><td><asp:TextBox ID="txtremark" runat="server" TextMode="MultiLine"></asp:TextBox></td></tr><tr><td 
                                    align="center" colspan="2"><asp:Button ID="btnsubmit" runat="server" 
                                    OnClick="btnsubmit_Click" Text="Submit" /></td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel>
                    </cc1:TabContainer>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
