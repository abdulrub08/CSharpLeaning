<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportPermission.aspx.cs" Inherits="ReportPermission" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
    
        <h4>
            <b>Login Name : * </b>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource1" DataTextField="LoginName" 
                DataValueField="LoginName" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:Project1ConnectionString %>" 
                SelectCommand="SELECT [LoginName] FROM [UserInfo]"></asp:SqlDataSource>
        </h4>
        <p style="text-align: left">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblmsg" runat="server" style="text-align: left" Text=""></asp:Label>
        </p>
        <p align="left">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="CheckBoxList1_SelectedIndexChanged" 
                style="text-align: left" AppendDataBoundItems="True" BorderColor="#669999" 
                BorderStyle="Solid" CausesValidation="True">
            </asp:CheckBoxList>
        </p>
    
    </div>
    </form>
</body>
</html>
