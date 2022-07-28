<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorInfo.aspx.cs" Inherits="DoctorInfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 305px;
        }
        .style2
        {
            width: 72px;
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Label ID="lblheading" runat="server" Text="Doctor Info"></asp:Label>
    <br />
    <asp:Label ID="lblid" runat="server"></asp:Label>
    <asp:Label ID="lblmode" runat="server"></asp:Label>
    <br />
&nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="432px" Width="817px">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                    Height="402px" Width="817px">
                    
                    
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="show All Doctors"><ContentTemplate><asp:Panel 
                        ID="Panel3" runat="server" Height="374px" Width="624px"><asp:GridView 
                        ID="GridView1" runat="server" AutoGenerateSelectButton="True" 
        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
        CellPadding="4" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        GridLines="Horizontal"><FooterStyle 
                            BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" 
                            Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" 
                            ForeColor="White" HorizontalAlign="Center" /><RowStyle 
                            ForeColor="#333333" BackColor="White" /><SelectedRowStyle BackColor="#339966" 
                            Font-Bold="True" ForeColor="White" /></asp:GridView></asp:Panel></ContentTemplate></cc1:TabPanel><cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Doctor"><ContentTemplate><asp:Panel ID="Panel2" runat="server" Height="383px"><table class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" runat="server"></asp:Label></td><td 
                        class="style2" rowspan="10"><asp:Image ID="Image1" runat="server" 
                        Height="320px" ImageUrl="~/images (2).jpg" Width="351px" /></td></tr><tr><td 
                        class="Text">Doctor Name*</td><td><asp:TextBox ID="txtDoctorName" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">Speciality*</td><td><asp:TextBox ID="txtSpeciality" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">IPD Fee*</td><td><asp:TextBox ID="txtIPDFee" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">Address*</td><td><asp:TextBox ID="txtAddress" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">email-id</td><td><asp:TextBox ID="txtemailid" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">Contact No*</td><td><asp:TextBox ID="txtContactNo" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">Mobile No</td><td><asp:TextBox ID="txtMobileNo" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td 
                        class="Text">Remark</td><td><asp:TextBox ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td></td><td>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                                                onclick="btnSubmit_Click" /></td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel></cc1:TabContainer>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
