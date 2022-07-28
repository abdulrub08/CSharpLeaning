<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Partyinfo.aspx.cs" Inherits="Partyinfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 99%;
            height: 355px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Party Information Form"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblid" runat="server" ForeColor="#CC0000"></asp:Label>
        <asp:Label ID="lblmode" runat="server" ForeColor="#CC0000"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Log-out</asp:LinkButton>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="650px" Width="784px">
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                        Height="402px" Width="692px" Font-Size="Large">
                        
                        
                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show All Party"><ContentTemplate><asp:Panel 
                            ID="Panel3" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
                            BorderStyle="Inset" Height="599px" Width="765px"><asp:GridView 
                            ID="GridView1" runat="server" AutoGenerateSelectButton="True" Height="266px" 
                            onselectedindexchanged="GridView1_SelectedIndexChanged" Width="326px"></asp:GridView></asp:Panel></ContentTemplate></cc1:TabPanel><cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Party"><ContentTemplate><asp:Panel 
                            ID="Panel2" runat="server" BackColor="#FFCCFF" 
                                BorderColor="#660033" BorderStyle="Inset" Font-Bold="True" Height="388px" 
                                Width="691px"><table class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" 
                                    runat="server" ForeColor="#CC0000"></asp:Label></td><td rowspan="12">&#160;</td></tr><tr><td>Party Name*</td><td><asp:TextBox 
                                    ID="txtpartyname" runat="server"></asp:TextBox></td></tr><tr><td>Address*</td><td><asp:TextBox 
                                        ID="txtaddress" runat="server"></asp:TextBox></td></tr><tr><td>City*</td><td><asp:TextBox 
                                        ID="txtcity" runat="server"></asp:TextBox></td></tr><tr><td>Pincode</td><td><asp:TextBox 
                                        ID="txtpincode" runat="server"></asp:TextBox><cc1:FilteredTextBoxExtender 
                                    ID="txtpincode_FilteredTextBoxExtender" runat="server" Enabled="True" 
                                    FilterType="Numbers" TargetControlID="txtpincode">
                                </cc1:FilteredTextBoxExtender>
                                &#160;(Only Numeric)</td></tr><tr><td>Contact No</td><td><asp:TextBox 
                                        ID="txtcontactno" runat="server"></asp:TextBox></td></tr><tr><td>Person Name*</td><td><asp:TextBox 
                                        ID="txtpersonname" runat="server"></asp:TextBox></td></tr><tr><td>Mobile No</td><td><asp:TextBox 
                                        ID="txtmobileno" runat="server"></asp:TextBox>&#160;(Only Numeric)</td></tr><tr><td>Tin No</td><td><asp:TextBox 
                                        ID="txttinno" runat="server"></asp:TextBox></td></tr><tr><td>Payment Type*</td><td><asp:DropDownList 
                                        ID="ddlpayment" runat="server"><asp:ListItem>Select the payment type</asp:ListItem><asp:ListItem>monthly</asp:ListItem><asp:ListItem>Quarterly</asp:ListItem><asp:ListItem>weekly</asp:ListItem></asp:DropDownList></td></tr><tr><td>Remark</td><td><asp:TextBox ID="txtremark" runat="server"></asp:TextBox></td></tr><tr><td 
                                    align="center" colspan="2"><asp:Button ID="btnsubmit" runat="server" 
                                Text="Submit" onclick="btnsubmit_Click1" /></td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel></cc1:TabContainer>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
