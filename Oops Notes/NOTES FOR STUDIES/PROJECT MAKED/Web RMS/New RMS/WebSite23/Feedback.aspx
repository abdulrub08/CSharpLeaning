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
        .style3
        {
            width: 618px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
            BorderStyle="Inset" Font-Bold="True" Font-Size="Large" Height="470px" 
            Width="1191px">
            <table class="style1">
                <tr>
                    <td align="center" rowspan="9">
                        <asp:Image ID="Image1" runat="server" Height="361px" ImageUrl="~/feedback1.jpg" 
                            Width="206px" />
                    </td>
                    <td align="center" colspan="2">
                        <asp:Label ID="lblheading" runat="server" Text="Feedback"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Name*</td>
                    <td class="style3">
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtname" ErrorMessage="Enter the name :"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Address*</td>
                    <td class="style3">
                        <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                        &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtaddress" ErrorMessage="Enter the Address :"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Mobile No</td>
                    <td class="style3">
                        <asp:TextBox ID="txtmobileno" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        Email Id*</td>
                    <td class="style3">
                        <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtemailid" ErrorMessage="Enter the Email Id :"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Description*</td>
                    <td class="style3">
                        <asp:TextBox ID="txtdescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtdescription" ErrorMessage="Enter the Description :"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Feedback*</td>
                    <td class="style3">
                        <asp:DropDownList ID="ddlfeedback" runat="server">
                            <asp:ListItem>Select your feedback</asp:ListItem>
                            <asp:ListItem>Excellent</asp:ListItem>
                            <asp:ListItem>Very Good</asp:ListItem>
                            <asp:ListItem>Good</asp:ListItem>
                            <asp:ListItem>Average</asp:ListItem>
                            <asp:ListItem>Poor</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlfeedback" ErrorMessage="Give Your feedback"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                            Text="Submit" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
