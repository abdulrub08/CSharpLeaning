<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConatctUs.aspx.cs" Inherits="ConatctUs" %>

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
            height: 124px;
        }
        .style3
        {
            width: 411px;
        }
        .style4
        {
            width: 268435488px;
        }
        .style6
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: normal;
            font-style: normal;
            color: #0c3e74;
            font-weight: bold;
            text-align: left;
            width: 255px;
        }
        .style7
        {
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="590px" Width="1062px">
            <table class="style1">
                <tr>
                    <td class="style2" colspan="4">
                    </td>
                </tr>
                <tr>
                    <td class="style3" rowspan="10">
                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                    <td rowspan="10" class="style4" width="250">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="Text">
                        Name*</td>
                    <td class="style7">
                        <asp:TextBox ID="txtName" runat="server" 
                CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="Enter the Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Address*</td>
                    <td class="style7">
                        <asp:TextBox ID="txtAddress" runat="server" 
                CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtAddress" ErrorMessage="Enter the Address"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Mobile No*</td>
                    <td class="style7">
                        <asp:TextBox ID="txtMobileNo" runat="server" 
                CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtMobileNo" ErrorMessage="Enter the MobileNo"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        EmailID*</td>
                    <td class="style7">
                        <asp:TextBox ID="txtEmailID" runat="server" 
                CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtEmailID" ErrorMessage="Enter the Email ID"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Description</td>
                    <td class="style7">
                        <asp:TextBox ID="txtDescription" runat="server" 
                CssClass="Textbox" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Contact Timing*</td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlCTFrom" ErrorMessage="Select Time From"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="ddCTTo" ErrorMessage="Select Time To"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        From:<asp:DropDownList ID="ddlCTFrom" runat="server" 
                AutoPostBack="True" CssClass="Dropdownlist">
                            <asp:ListItem>-- Select Time --</asp:ListItem>
                            <asp:ListItem>7:00</asp:ListItem>
                            <asp:ListItem>7:30</asp:ListItem>
                            <asp:ListItem>8:00</asp:ListItem>
                            <asp:ListItem>8:30</asp:ListItem>
                            <asp:ListItem>9:00</asp:ListItem>
                            <asp:ListItem>9:30</asp:ListItem>
                            <asp:ListItem>10:00</asp:ListItem>
                            <asp:ListItem>10:30</asp:ListItem>
                            <asp:ListItem>11:00</asp:ListItem>
                            <asp:ListItem>11:30</asp:ListItem>
                            <asp:ListItem>12:00</asp:ListItem>
                            <asp:ListItem>14:00</asp:ListItem>
                            <asp:ListItem>14:30</asp:ListItem>
                            <asp:ListItem>15:00</asp:ListItem>
                            <asp:ListItem>15:30</asp:ListItem>
                            <asp:ListItem>16:00</asp:ListItem>
                            <asp:ListItem>16:30</asp:ListItem>
                            <asp:ListItem>17:00</asp:ListItem>
                            <asp:ListItem>17:30</asp:ListItem>
                            <asp:ListItem>18:00</asp:ListItem>
                            <asp:ListItem>18:30</asp:ListItem>
                            <asp:ListItem>19:00</asp:ListItem>
                            <asp:ListItem>19:30</asp:ListItem>
                            <asp:ListItem>20:00</asp:ListItem>
                            <asp:ListItem>20:30</asp:ListItem>
                            <asp:ListItem>21:00</asp:ListItem>
                            <asp:ListItem>21:30</asp:ListItem>
                            <asp:ListItem>22:00</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="style6">
                        To:<asp:DropDownList ID="ddCTTo" runat="server" 
                AutoPostBack="True" CssClass="Dropdownlist">
                            <asp:ListItem>-- Select Time --</asp:ListItem>
                            <asp:ListItem>7:00</asp:ListItem>
                            <asp:ListItem>7:30</asp:ListItem>
                            <asp:ListItem>8:00</asp:ListItem>
                            <asp:ListItem>8:30</asp:ListItem>
                            <asp:ListItem>9:00</asp:ListItem>
                            <asp:ListItem>9:30</asp:ListItem>
                            <asp:ListItem>10:00</asp:ListItem>
                            <asp:ListItem>10:30</asp:ListItem>
                            <asp:ListItem>11:00</asp:ListItem>
                            <asp:ListItem>11:30</asp:ListItem>
                            <asp:ListItem>12:00</asp:ListItem>
                            <asp:ListItem>14:00</asp:ListItem>
                            <asp:ListItem>14:30</asp:ListItem>
                            <asp:ListItem>15:00</asp:ListItem>
                            <asp:ListItem>15:30</asp:ListItem>
                            <asp:ListItem>16:00</asp:ListItem>
                            <asp:ListItem>16:30</asp:ListItem>
                            <asp:ListItem>17:00</asp:ListItem>
                            <asp:ListItem>17:30</asp:ListItem>
                            <asp:ListItem>18:00</asp:ListItem>
                            <asp:ListItem>18:30</asp:ListItem>
                            <asp:ListItem>19:00</asp:ListItem>
                            <asp:ListItem>19:30</asp:ListItem>
                            <asp:ListItem>20:00</asp:ListItem>
                            <asp:ListItem>20:30</asp:ListItem>
                            <asp:ListItem>21:00</asp:ListItem>
                            <asp:ListItem>21:30</asp:ListItem>
                            <asp:ListItem>22:00</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style7">
                        <asp:Button ID="btnSubmit" runat="server" 
                CssClass="Button" Text="Submit" onclick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
