<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomInfo.aspx.cs" Inherits="RoomInfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
    
    </div>
    <asp:Label ID="lblheading" runat="server" Text="Room Info"></asp:Label>
    <br />
    <asp:Label ID="lblid" runat="server"></asp:Label>
    <asp:Label ID="lblmode" runat="server"></asp:Label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="380px" Width="460px">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                    Height="344px" Width="447px">
                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show All Rooms">
                    <ContentTemplate><asp:GridView ID="GridView1" runat="server" BackColor="White" 
                            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                            GridLines="Horizontal" 
                            onselectedindexchanged="GridView1_SelectedIndexChanged" 
                            AutoGenerateSelectButton="True"><FooterStyle 
                            BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                </ContentTemplate>
                </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Room">
                    <ContentTemplate><asp:Panel ID="Panel2" runat="server" Height="308px"><table 
                            class="style1"><tr><td colspan="2"><asp:Label ID="lblmsg" runat="server"></asp:Label></td></tr><tr>
                        <td class="Text">Floor No*</td><td><asp:DropDownList 
                            ID="ddlFloorNo" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlFloorNo_SelectedIndexChanged" 
                            CssClass="Dropdownlist">
                        </asp:DropDownList>
                        </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Wing Name*</td><td><asp:DropDownList ID="ddlWingName" runat="server" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="ddlWingName_SelectedIndexChanged" 
                                    CssClass="Dropdownlist">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Ward No*</td><td><asp:DropDownList ID="ddlWardNo" runat="server" 
                                    AutoPostBack="True" CssClass="Dropdownlist">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Room No*</td><td><asp:TextBox ID="txtRoomNo" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr>
                        <td class="Text">Description</td><td><asp:TextBox 
                            ID="txtDescription" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr>
                            <td class="Text">Remark</td><td><asp:TextBox 
                                ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox></td></tr><tr><td>&#160;</td><td><asp:Button 
                                ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="Submit" />
                            </td>
                        </tr>
                        </table>
                        </asp:Panel>
                </ContentTemplate>
                </cc1:TabPanel>
                </cc1:TabContainer>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
