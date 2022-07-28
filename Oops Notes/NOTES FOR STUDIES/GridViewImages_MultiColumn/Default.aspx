<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <br />
<asp:GridView ID="GridView1" runat="server" 
              AutoGenerateColumns="False" DataKeyNames="ID"
              DataSourceID="SqlDataSource1">
<Columns>
<asp:BoundField DataField="ID" HeaderText="ID" 
                InsertVisible="False" ReadOnly="True"
                               SortExpression="ID" />
<asp:BoundField DataField="ImageName" HeaderText="ImageName" 
                               SortExpression="ImageName" />
<asp:TemplateField HeaderText="Image">
<ItemTemplate>
<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ID", "Handler.ashx?ID={0}")%>'/>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Image2">
<ItemTemplate>
<asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("ID", "Handler2.ashx?ID={0}")%>'/>
</ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
SelectCommand="SELECT [ID], [ImageName], [Image], [Image2] 
              FROM [Images]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
