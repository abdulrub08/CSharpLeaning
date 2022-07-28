<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="style1">
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="pub_id" 
                DataSourceID="SqlDataSource1" GridLines="Vertical" Width="100%">
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <Columns>
                                <asp:BoundField DataField="pub_id" HeaderText="pub_id" 
                        ReadOnly="True" SortExpression="pub_id" />
                                <asp:BoundField DataField="pub_name" HeaderText="pub_name" 
                        SortExpression="pub_name" />
                                <asp:BoundField DataField="city" HeaderText="city" 
                        SortExpression="city" />
                                <asp:BoundField DataField="state" HeaderText="state" 
                        SortExpression="state" />
                                <asp:BoundField DataField="country" HeaderText="country" 
                        SortExpression="country" />
                                <asp:CommandField ButtonType="Button" 
                        SelectText="Show Employee" ShowSelectButton="True" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" 
                    HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" 
                    ForeColor="White" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" 
                    ForeColor="White" />
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>" 
                SelectCommand="SELECT * FROM [publishers]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp; &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server" 
                AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" DataKeyNames="emp_id" DataSourceID="SqlDataSource2" 
                GridLines="Vertical" PageSize="5" Width="100%">
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <Columns>
                                <asp:BoundField DataField="emp_id" HeaderText="emp_id" 
                        ReadOnly="True" SortExpression="emp_id" />
                                <asp:BoundField DataField="fname" HeaderText="fname" 
                        SortExpression="fname" />
                                <asp:BoundField DataField="minit" HeaderText="minit" 
                        SortExpression="minit" />
                                <asp:BoundField DataField="lname" HeaderText="lname" 
                        SortExpression="lname" />
                                <asp:BoundField DataField="job_id" HeaderText="job_id" 
                        SortExpression="job_id" />
                                <asp:BoundField DataField="job_lvl" HeaderText="job_lvl" 
                        SortExpression="job_lvl" />
                                <asp:BoundField DataField="pub_id" HeaderText="pub_id" 
                        SortExpression="pub_id" />
                                <asp:BoundField DataField="hire_date" 
                        HeaderText="hire_date" SortExpression="hire_date" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" 
                    HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" 
                    ForeColor="White" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" 
                    ForeColor="White" />
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>" 
                SelectCommand="SELECT * FROM [employee] WHERE ([pub_id] = @pub_id)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="GridView1" Name="pub_id" 
                        PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
