<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rUnitwiseiteminfo.aspx.cs" Inherits="rUnitwiseiteminfo" %>

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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#990033" 
                    BorderStyle="Solid" Font-Bold="True" Font-Size="Large" Height="153px" 
                    Width="1044px">
                    <table class="style1">
                        <tr>
                            <td>
                                Show All Unit Items</td>
                            <td>
                                <asp:Button ID="btnprintall" runat="server" Text="Print All" 
                                    onclick="btnprintall_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Unitwise Item Details</td>
                            <td>
                                <asp:DropDownList ID="ddlunitname" runat="server" AutoPostBack="True" 
                                    DataSourceID="SqlDataSource1" DataTextField="unitname" 
                                    DataValueField="unitname">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString22 %>" 
                                    SelectCommand="SELECT [unitname] FROM [iteminfo]"></asp:SqlDataSource>
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
