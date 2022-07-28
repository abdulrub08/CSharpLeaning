<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rCompanywiseiteminfo.aspx.cs" Inherits="rCompanywiseIteminfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
                    BorderStyle="Solid" Font-Bold="True" Font-Size="Large" Height="190px" 
                    Width="1036px">
                    <table class="style1">
                        <tr>
                            <td>
                                Show All Company Items</td>
                            <td>
                                <asp:Button ID="btnprintall" runat="server" Text="Print All" 
                                    onclick="btnprintall_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Companywise Item Details</td>
                            <td>
                                <asp:DropDownList ID="ddlcompanyname" runat="server" AutoPostBack="True" 
                                    DataSourceID="SqlDataSource1" DataTextField="companyname" 
                                    DataValueField="companyname" ondatabound="join">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString23 %>" 
                                    SelectCommand="SELECT [companyname] FROM [iteminfo]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="btnsubmit" runat="server" Text="Print" 
                                    onclick="btnsubmit_Click" />
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
