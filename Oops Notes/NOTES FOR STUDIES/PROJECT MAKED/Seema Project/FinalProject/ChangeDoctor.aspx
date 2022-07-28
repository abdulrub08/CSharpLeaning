<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeDoctor.aspx.cs" Inherits="ChangeDoctor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 172px;
        }
        .style2
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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="723px">
                    <table class="style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Registration No.*</td>
                            <td>
                                <asp:DropDownList ID="ddlRegNo" runat="server" AutoPostBack="True" 
                                    CssClass="Dropdownlist" onselectedindexchanged="ddlRegNo_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                    GridLines="Horizontal" onselectedindexchanged="GridView1_SelectedIndexChanged">
                                    <FooterStyle BackColor="White" ForeColor="#333333" />
                                    <RowStyle BackColor="White" ForeColor="#333333" />
                                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnChangeDoctor" runat="server" CssClass="Button" Height="25px" 
                                    onclick="btnChangeDoctor_Click" Text="Change Doctor" Width="108px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Panel ID="Panel2" runat="server" Height="356px">
                                    <table class="style1">
                                        <tr>
                                            <td class="Text">
                                                Doctor Name*</td>
                                            <td>
                                                <asp:DropDownList ID="ddlDoctorName" runat="server" AutoPostBack="True" 
                                                    CssClass="Dropdownlist" 
                                                    onselectedindexchanged="ddlDoctorName_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:DetailsView ID="DetailsView1" runat="server" BackColor="White" 
                                                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                    GridLines="Horizontal" Height="50px" Width="125px">
                                                    <FooterStyle BackColor="White" ForeColor="#333333" />
                                                    <RowStyle BackColor="White" ForeColor="#333333" />
                                                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                                    <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                </asp:DetailsView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                            </td>
                                            <td class="style2">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Text">
                                                IPD Charges</td>
                                            <td>
                                                <asp:Label ID="lblIPDFee" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
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
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
