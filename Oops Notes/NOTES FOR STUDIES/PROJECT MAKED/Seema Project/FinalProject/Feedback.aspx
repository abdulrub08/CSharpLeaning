<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

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
            height: 121px;
        }
        .style4
        {
            height: 16px;
        }
        .style5
        {
            width: 182px;
        }
        .style6
        {
            width: 338px;
        }
        .style7
        {
            height: 16px;
            width: 338px;
        }
        .style8
        {
            width: 866px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="626px" Width="1041px">
            <table class="style1">
                <tr>
                    <td class="style2" colspan="4">
                    </td>
                </tr>
                <tr>
                    <td class="style8" rowspan="8">
                        &nbsp;</td>
                    <td class="Text" colspan="2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                    <td class="style5" rowspan="8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="Text">
                        Name*</td>
                    <td class="style6">
                        <asp:TextBox ID="txtName" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="Enter the Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Address*</td>
                    <td class="style6">
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtAddress" ErrorMessage="Enter the Address"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        MobileNo.</td>
                    <td class="style6">
                        <asp:TextBox ID="txtMobileNo" runat="server" CssClass="Textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        EmailID*</td>
                    <td class="style6">
                        <asp:TextBox ID="txtEmailID" runat="server" CssClass="Textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtEmailID" ErrorMessage="Enter the Email ID"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Description*</td>
                    <td class="style6">
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="Textbox" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtDescription" ErrorMessage="Enter the Description"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Out Of 10*</td>
                    <td class="style6">
                        <asp:DropDownList ID="ddlOutOf" runat="server" AutoPostBack="True" 
                            CssClass="Dropdownlist">
                            <asp:ListItem>-- Select Out Of 10 --</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlOutOf" ErrorMessage="Select any no. Out of 10"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                    </td>
                    <td class="style7">
                        <asp:Button ID="btnSubmit" runat="server" CssClass="Button" Text="Submit" 
                            onclick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
