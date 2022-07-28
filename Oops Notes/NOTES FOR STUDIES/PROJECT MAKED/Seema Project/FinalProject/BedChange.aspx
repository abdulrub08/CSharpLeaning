<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BedChange.aspx.cs" Inherits="BedChange" %>

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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="575px">
                    <table class="style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Text">
                                Reg No*</td>
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
                                <asp:Button ID="btnChangeBed" runat="server" CssClass="Button" 
                                    onclick="btnChangeBed_Click" Text="Change Bed" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Panel ID="Panel2" runat="server" Height="159px">
                                    <table class="style1">
                                        <tr>
                                            <td class="Text">
                                                Floor No*</td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtlFloorNo" runat="server" AutoPostBack="True" 
                                                    onselectedindexchanged="rbtlFloorNo_SelectedIndexChanged" 
                                                    RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Text">
                                                Wing Name*</td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtlWingName" runat="server" AutoPostBack="True" 
                                                    onselectedindexchanged="rbtlWingName_SelectedIndexChanged" 
                                                    RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Text">
                                                Ward No*</td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtlWardNo" runat="server" AutoPostBack="True" 
                                                    onselectedindexchanged="rbtlWardNo_SelectedIndexChanged" 
                                                    RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Text">
                                                Room No*</td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtlRoomNo" runat="server" AutoPostBack="True" 
                                                    onselectedindexchanged="rbtlRoomNo_SelectedIndexChanged" 
                                                    RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Text">
                                                Bed No*</td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtlBedNo" runat="server" AutoPostBack="True" 
                                                    RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
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
                            <td class="Text">
                                Remark</td>
                            <td>
                                <asp:TextBox ID="txtRemark" runat="server" CssClass="Textbox"></asp:TextBox>
                            </td>
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
        <br />
    
    </div>
    </form>
</body>
</html>
