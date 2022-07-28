<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADUser.aspx.cs" Inherits="ADUser" %>

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
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Label ID="lblheading" runat="server" Text="Activate/DeActivate User"></asp:Label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="223px" Width="388px">
                <table class="style1">
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="lblLoginName" runat="server" Text="LoginName*" CssClass="Text"></asp:Label>
                        </td>
                        <td class="style2">
                            <br />
                            <asp:DropDownList ID="ddlLoginName" runat="server" 
                                DataSourceID="SqlDataSource1" DataTextField="LoginName" 
                                DataValueField="LoginName" 
                                onselectedindexchanged="ddlLoginName_SelectedIndexChanged" 
                                style="height: 22px" AutoPostBack="True" CssClass="Dropdownlist">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
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
                        <td>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" 
                                ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" 
                                SelectCommand="SELECT [LoginName] FROM [UserInfo]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" Text="Button" 
                                onclick="btnUpdate_Click" CssClass="Button" Width="162px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
