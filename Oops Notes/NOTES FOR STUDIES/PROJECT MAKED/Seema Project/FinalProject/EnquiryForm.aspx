<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnquiryForm.aspx.cs" Inherits="EnquiryForm" %>

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
            height: 159px;
        }
        .style3
        {
            width: 469px;
        }
        .style4
        {
            width: 204px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="640px" Width="1085px">
            <table class="style1">
                <tr>
                    <td class="style2" colspan="4">
                    </td>
                </tr>
                <tr>
                    <td class="style3" rowspan="8">
                        &nbsp;</td>
                    <td class="Text" colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                    <td class="style4" rowspan="8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="Text">
                        Name*</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="Enter the Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Address*</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtAddress" ErrorMessage="Enter the Address"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Mobile No*</td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtMobileNo" ErrorMessage="Enter the MobileNo"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Email ID*</td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtEmailID" ErrorMessage="Enter the Email ID"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Subject*</td>
                    <td>
                        <asp:TextBox ID="txtSubject" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtSubject" ErrorMessage="Enter the Subject"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Enquiry About*</td>
                    <td>
                        <asp:TextBox ID="txtEnquiryAbout" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="txtEnquiryAbout" ErrorMessage="Enter the Enquiry About"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" CssClass="Button" 
                            onclick="btnSubmit_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
