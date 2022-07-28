<%@ Page Language="C#" MasterPageFile="~/MasterPageforsetup.master" AutoEventWireup="true" CodeFile="sentmail.aspx.cs" Inherits="sentmail" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel4" runat="server" Height="708px" Width="756px">
    <asp:Panel ID="Panel5" runat="server" BackColor="#CCCCFF" BorderColor="#66CCFF" 
        BorderStyle="Double" Height="499px" style="margin-bottom: 4px" Visible="False" 
        Width="820px">
        <table class="style2" 
            style="font-family: Arial, Helvetica, sans-serif; font-size: large; color: #000000; font-variant: normal; font-style: normal; font-weight: normal; height: 506px; width: 100%;">
            <tr>
                <td align="center" bgcolor="White" colspan="2" style="color: #FFFFFF;">
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Gray"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:</td>
                <td>
                    <asp:TextBox ID="txt_to" runat="server" Height="49px" TextMode="MultiLine" 
                        Width="720px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;</td>
                <td>
                    <asp:LinkButton ID="lnkaddcc" runat="server" onclick="lnkaddcc_Click">Add CC</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="lnkaddbcc" runat="server" onclick="lnkaddbcc_Click">Add Bcc</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblcc" runat="server" Text="To CC:" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcc" runat="server" Height="22px" TextMode="MultiLine" 
                        Visible="False" Width="592px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblbcc" runat="server" Text="To Bcc:" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtbcc" runat="server" Height="22px" TextMode="MultiLine" 
                        Visible="False" Width="592px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;&nbsp;&nbsp; Subject:</td>
                <td>
                    <asp:TextBox ID="txtsub" runat="server" Height="26px" TextMode="MultiLine" 
                        Width="592px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;</td>
                <td>
                    <asp:LinkButton ID="lnkattachfile" runat="server" onclick="lnkattachfile_Click">Attach 
                    file</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td>
                    <asp:TextBox ID="txtattach" runat="server" Height="22px" Width="581px"></asp:TextBox>
                    <cc1:TextBoxWatermarkExtender ID="txtattach_TextBoxWatermarkExtender0" 
                        runat="server" Enabled="True" TargetControlID="txtattach" 
                        WatermarkText="no file">
                    </cc1:TextBoxWatermarkExtender>
                </td>
            </tr>
            <tr>
                <td style="width: 89px">
                    &nbsp;&nbsp;Message:</td>
                <td>
                    <asp:TextBox ID="txtmsg" runat="server" Height="106px" TextMode="MultiLine" 
                        Width="720px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 89px; height: 25px;">
                </td>
                <td style="height: 25px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 89px">
                    <asp:Button ID="btnsend" runat="server" onclick="btnsend_Click" Text="Send" />
                </td>
                <td>
                    <asp:Button ID="btnsave" runat="server" onclick="btnsave_Click" Text="Save" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" 
        CellPadding="4" ForeColor="#333333" GridLines="None" Height="167px" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" Width="749px">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</asp:Panel>
</asp:Content>

