<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default21.aspx.cs" Inherits="Default21" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="ProductId" DataSourceID="SqlDataSource1" 
        EmptyDataText="There are no data records to display." Width="100%">
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:TemplateField HeaderText="ProductName" SortExpression="ProductName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProductName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                    <cc1:HoverMenuExtender ID="Label1_HoverMenuExtender" runat="server" 
                        DynamicServicePath="" Enabled="True" PopupControlID="Image1" 
                        PopupPosition="Right" TargetControlID="Label1">
                    </cc1:HoverMenuExtender>
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="95px" 
                        ImageUrl='<%# Eval("ProductUrl") %>' Width="109px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
        DeleteCommand="DELETE FROM [Products] WHERE [ProductId] = @ProductId" 
        InsertCommand="INSERT INTO [Products] ([ProductName], [Description], [Price], [ProductUrl]) VALUES (@ProductName, @Description, @Price, @ProductUrl)" 
        ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
        SelectCommand="SELECT [ProductId], [ProductName], [Description], [Price], [ProductUrl] FROM [Products]" 
        UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [Description] = @Description, [Price] = @Price, [ProductUrl] = @ProductUrl WHERE [ProductId] = @ProductId">
        <DeleteParameters>
            <asp:Parameter Name="ProductId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="ProductUrl" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="ProductUrl" Type="String" />
            <asp:Parameter Name="ProductId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
