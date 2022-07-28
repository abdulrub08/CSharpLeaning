<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            text-align: center;
        }
        .style4
        {
            width: 194px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Panel ID="Panel1" runat="server" Height="637px">
    
    <div style="float:left; width:409px; height: 572px; margin-left:100px; margin-top:30px; background-image: url('image/sideback.png'); background-repeat: no-repeat;"></div>
        <div style="border: thin groove #659ABA; position:absolute; top: 213px; left: 518px; height: 570px; width: 573px; background-color: #FFFFE1;">
            <table class="style1">
                <tr>
                    <td align="right" class="style4">
                        First Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                        <asp:Label ID="lblfname" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Last Name</td>
                    <td>
                        <asp:TextBox ID="txtlstname" runat="server"></asp:TextBox>
                        <asp:Label ID="lbllstname" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Email-ID</td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                        <asp:Label ID="lblemail" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Password</td>
                    <td>
                        <asp:TextBox ID="txtpswrd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Confirm Password</td>
                    <td>
                        <asp:TextBox ID="txtcnfrmpsd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                            RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Date of Birth</td>
                    <td>
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                        <asp:ImageButton ID="calender" runat="server" Height="20px" 
                            ImageUrl="~/image/calendr2.png" />
                        <asp:Label ID="lbldateofbirth" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        State</td>
                    <td>
                        <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" 
                            AppendDataBoundItems="True" 
                            onselectedindexchanged="ddlstate_SelectedIndexChanged">
                            <asp:ListItem>----Select State----</asp:ListItem>
                            <asp:ListItem>Andman &amp; Nicobar Islands</asp:ListItem>
                                        <asp:ListItem>Andhra Pradesh</asp:ListItem>
                                        <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                                        <asp:ListItem>Assam</asp:ListItem>
                                        <asp:ListItem>Bihar</asp:ListItem>
                                        <asp:ListItem>Chandigarh</asp:ListItem>
                                        <asp:ListItem>Chhattisgarh</asp:ListItem>
                                        <asp:ListItem>Dadra &amp; Nagar Haveli</asp:ListItem>
                                        <asp:ListItem>Daman &amp; Diu</asp:ListItem>
                                        <asp:ListItem>Delhi</asp:ListItem>
                                        <asp:ListItem>Goa</asp:ListItem>
                                        <asp:ListItem>Gujarat</asp:ListItem>
                                        <asp:ListItem>Haryana</asp:ListItem>
                                        <asp:ListItem>Himanchal Pradesh</asp:ListItem>
                                        <asp:ListItem>Jammu &amp; Kashmir</asp:ListItem>
                                        <asp:ListItem>Jharkhand</asp:ListItem>
                                        <asp:ListItem>Karnataka</asp:ListItem>
                                        <asp:ListItem>Kerala</asp:ListItem>
                                        <asp:ListItem>Lakshadweep</asp:ListItem>
                                        <asp:ListItem>Madhya Pradesh</asp:ListItem>
                                        <asp:ListItem>Maharastra</asp:ListItem>
                                        <asp:ListItem>Manipur</asp:ListItem>
                                        <asp:ListItem>Meghalya</asp:ListItem>
                                        <asp:ListItem>Mizoram</asp:ListItem>
                                        <asp:ListItem>Nagaland</asp:ListItem>
                                        <asp:ListItem>Orissa</asp:ListItem>
                                        <asp:ListItem>Puducherry</asp:ListItem>
                                        <asp:ListItem>Punjab</asp:ListItem>
                                        <asp:ListItem>Rajasthan</asp:ListItem>
                                        <asp:ListItem>Sikkim</asp:ListItem>
                                        <asp:ListItem>Tamil Nadu</asp:ListItem>
                                        <asp:ListItem>Tripura</asp:ListItem>
                                        <asp:ListItem>Uttarakhand</asp:ListItem>
                                        <asp:ListItem>Uttar Pradesh</asp:ListItem>
                                        <asp:ListItem>West Bengal</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        City</td>
                    <td>
                        <asp:DropDownList ID="ddlcity" runat="server">
                        <asp:ListItem>----City----</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr><td align="right" class="style4">Mobile No.</td><td>
                    <asp:TextBox ID="txtmobileno" runat="server"></asp:TextBox>
                    <asp:Label ID="lblmbileno" runat="server" ForeColor="Red"></asp:Label>
                    </td></tr>
                <tr>
                    <td align="right" class="style4">
                        Zip Code</td>
                    <td>
                        <asp:TextBox ID="txtzipcode" runat="server"></asp:TextBox>
                        <asp:Label ID="lblzipcode" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Security Question</td>
                    <td>
                        <asp:DropDownList ID="ddlquestion" runat="server" AutoPostBack="True">
                            <asp:ListItem>What is your pet Name</asp:ListItem>
                            <asp:ListItem>What is Your First Mobile Number</asp:ListItem>
                            <asp:ListItem>Whose Your Favorite Teacher</asp:ListItem>
                            <asp:ListItem>Whose Your Ideal Persone</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblanswer" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Answer
                    </td>
                    <td>
                        <asp:TextBox ID="txtanswer" runat="server" Width="357px" 
                            AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Designation</td>
                    <td>
                        <asp:TextBox ID="txtdesignation" runat="server" Width="145px"></asp:TextBox>
                        <asp:Label ID="lbldesignation" runat="server" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3" colspan="2">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style2" colspan="2">
                        <asp:CheckBox ID="chkagree" runat="server" Text="I Agree to The Service" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        &nbsp;</td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" 
                            ImageUrl="~/image/register.png" onclick="ImageButton2_Click" />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        &nbsp;</td>
                    <td>
                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" 
                            PopupButtonID="calender" TargetControlID="txtdate">
                        </cc1:CalendarExtender>
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    
    
</asp:Content>

