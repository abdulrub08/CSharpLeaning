<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

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
        <asp:Label ID="lblheading" runat="server" Text="Registration"></asp:Label>
        <br />
        <asp:Label ID="lblid" runat="server"></asp:Label>
        <asp:Label ID="lblmode" runat="server"></asp:Label>
    
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="854px" Width="824px">
                <table class="style1">
                    <tr>
                        <td colspan="4">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Patient Type</td>
                        <td>
                            <asp:DropDownList ID="ddlPatientType" runat="server" AutoPostBack="True" 
                                CssClass="Dropdownlist">
                                <asp:ListItem>Select Patient Type</asp:ListItem>
                                <asp:ListItem>Normal</asp:ListItem>
                                <asp:ListItem>Corporate</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Tittle*</td>
                        <td>
                            <asp:DropDownList ID="ddlTittle" runat="server" AutoPostBack="True" 
                                CssClass="Dropdownlist" Height="19px" Width="126px">
                                <asp:ListItem>Select Tittle</asp:ListItem>
                                <asp:ListItem>Master</asp:ListItem>
                                <asp:ListItem>Dr</asp:ListItem>
                                <asp:ListItem>Er</asp:ListItem>
                                <asp:ListItem>Mr</asp:ListItem>
                                <asp:ListItem>Ms</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Blood Group</td>
                        <td>
                            <asp:DropDownList ID="ddlBloodGroup" runat="server" AutoPostBack="True" 
                                CssClass="Dropdownlist" Height="19px" Width="137px">
                                <asp:ListItem>Select Blood Group</asp:ListItem>
                                <asp:ListItem>A+</asp:ListItem>
                                <asp:ListItem>A-</asp:ListItem>
                                <asp:ListItem>B+</asp:ListItem>
                                <asp:ListItem>B-</asp:ListItem>
                                <asp:ListItem>O+</asp:ListItem>
                                <asp:ListItem>O-</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            First Name*</td>
                        <td class="Text">
                            Middle Name</td>
                        <td class="Text">
                            Last Name*</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtMiddleName" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLastName" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkAlcoholic" runat="server" AutoPostBack="True" 
                                CssClass="Text" Text="Alcoholic" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:CheckBox ID="chkBloodSugar" runat="server" AutoPostBack="True" 
                                CssClass="Text" Text="Blood Sugar" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text">
                            DOB*</td>
                        <td>
                            <asp:TextBox ID="txtDOB" runat="server" CssClass="Textbox"></asp:TextBox>
                            <cc1:CalendarExtender ID="txtDOB_CalendarExtender" runat="server" 
                                Enabled="True" TargetControlID="txtDOB">
                            </cc1:CalendarExtender>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:CheckBox ID="chkSmoking" runat="server" AutoPostBack="True" 
                                CssClass="Text" Text="Smoking" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Address*</td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text">
                            City</td>
                        <td>
                            <asp:TextBox ID="txtCity" runat="server" CssClass="Textbox" Height="25px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Blood Pressure</td>
                        <td>
                            <asp:TextBox ID="txtBloodPressure" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Pincode</td>
                        <td>
                            <asp:TextBox ID="txtPincode" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Weight</td>
                        <td>
                            <asp:TextBox ID="txtWeight" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Contact No</td>
                        <td>
                            <asp:TextBox ID="txtContactNo" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Height</td>
                        <td>
                            <asp:TextBox ID="txtHeight" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            EmailID</td>
                        <td>
                            <asp:TextBox ID="txtEmailID" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Description</td>
                        <td>
                            <asp:TextBox ID="txtDescription" runat="server" CssClass="Textbox" 
                                TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Occupation*</td>
                        <td>
                            <asp:DropDownList ID="ddlOccupation" runat="server" AutoPostBack="True" 
                                CssClass="Dropdownlist" Height="22px" Width="125px">
                                <asp:ListItem>Select Occupation</asp:ListItem>
                                <asp:ListItem>Newly Born</asp:ListItem>
                                <asp:ListItem>Student</asp:ListItem>
                                <asp:ListItem>Self-Employee</asp:ListItem>
                                <asp:ListItem>Bussiness Man</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="Text">
                            Remark</td>
                        <td>
                            <asp:TextBox ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text">
                            Father&#39;s Name</td>
                        <td>
                            <asp:TextBox ID="txtFathersName" runat="server" CssClass="Textbox"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="Text" colspan="5">
                            <asp:Panel ID="Panel2" runat="server" Height="355px">
                                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                                    Width="813px">
                                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Add Doctor"><ContentTemplate><asp:Panel ID="Panel3" runat="server" Height="319px"><table class="style1"><tr><td>Doctor Name*</td><td><asp:DropDownList ID="ddlDoctorsName" runat="server" AutoPostBack="True" 
                                                                CssClass="Dropdownlist" Height="17px" 
                                                                onselectedindexchanged="ddlDoctorsName_SelectedIndexChanged" Width="112px"></asp:DropDownList></td></tr><tr><td colspan="2"><asp:DetailsView ID="DetailsView1" runat="server" BackColor="White" 
                                                                BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                                GridLines="Horizontal" Height="50px" Width="125px"><EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" /><FooterStyle BackColor="White" ForeColor="#333333" /><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#333333" /></asp:DetailsView></td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add Bed"><HeaderTemplate>Add Bed</HeaderTemplate><ContentTemplate><asp:Panel ID="Panel4" runat="server" Height="319px"><table class="style1"><tr><td class="Text">Floor No*</td><td><asp:RadioButtonList ID="rbtlFloorNo" runat="server" AutoPostBack="True" 
                                                                onselectedindexchanged="rbtlFloorNo_SelectedIndexChanged" 
                                                                RepeatDirection="Horizontal"></asp:RadioButtonList></td></tr><tr><td class="Text">Wing Name*</td><td><asp:RadioButtonList ID="rbtlWingName" runat="server" AutoPostBack="True" 
                                                                onselectedindexchanged="rbtlWingName_SelectedIndexChanged" 
                                                                RepeatDirection="Horizontal"></asp:RadioButtonList></td></tr><tr><td class="Text">Ward No*</td><td><asp:RadioButtonList ID="rbtlWardNo" runat="server" AutoPostBack="True" 
                                                                onselectedindexchanged="rbtlWardNo_SelectedIndexChanged" 
                                                                RepeatDirection="Horizontal"></asp:RadioButtonList></td></tr><tr><td class="Text">Room No*</td><td><asp:RadioButtonList ID="rbtlRoomNo" runat="server" AutoPostBack="True" 
                                                                onselectedindexchanged="rbtlRoomNo_SelectedIndexChanged" 
                                                                RepeatDirection="Horizontal"></asp:RadioButtonList></td></tr><tr><td class="Text">Bed No*</td><td><asp:RadioButtonList ID="rbtlBedNo" runat="server" AutoPostBack="True" 
                                                                onselectedindexchanged="rbtlBedNo_SelectedIndexChanged" 
                                                                RepeatDirection="Horizontal"></asp:RadioButtonList></td></tr><tr><td>&#160;</td><td>&#160;</td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Add Payment"><ContentTemplate><asp:Panel ID="Panel5" runat="server" Height="318px"><table class="style1"><tr><td class="Text">Payment Type*</td><td><asp:RadioButtonList ID="rbtlPaymentType" runat="server" AutoPostBack="True" 
                                                                RepeatDirection="Horizontal"><asp:ListItem>Cash</asp:ListItem><asp:ListItem>Cheque</asp:ListItem></asp:RadioButtonList></td></tr><tr><td class="Text">Amount</td><td><asp:TextBox ID="txtAmount" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td>&#160;</td><td>&#160;</td></tr></table></asp:Panel></ContentTemplate></cc1:TabPanel>
                                </cc1:TabContainer>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="Text" colspan="5">
                            <p style="text-align: center">
                                <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                                    style="text-align: center" Text="Submit" />
                            </p>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
