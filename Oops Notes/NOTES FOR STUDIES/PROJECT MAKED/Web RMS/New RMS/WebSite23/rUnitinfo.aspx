﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rUnitinfo.aspx.cs" Inherits="rUnitinfo" %>

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
                    BorderStyle="Inset" Font-Bold="True" Font-Size="Large" Height="147px">
                    <table class="style1">
                        <tr>
                            <td>
                                Print All Unit Details</td>
                            <td>
                                <asp:Button ID="btnprintall" runat="server" BackColor="Silver" Font-Bold="True" 
                                    ForeColor="#408080" onclick="Button1_Click" Text="Print All" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Print Unitwise Details</td>
                            <td>
                                <asp:DropDownList ID="ddlunitname" runat="server" DataSourceID="SqlDataSource1" 
                                    DataTextField="unitname" DataValueField="unitname" ondatabound="join">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:RMSConnectionString15 %>" 
                                    SelectCommand="SELECT [unitname] FROM [unitinfo]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" 
                                    onclick="btnsubmit_Click" Text="Print" />
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