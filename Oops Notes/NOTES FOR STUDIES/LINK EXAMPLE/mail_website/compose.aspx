<%@ Page Language="C#" MasterPageFile="~/MasterPageforsetup.master" AutoEventWireup="true" CodeFile="compose.aspx.cs" Inherits="compose" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel4" runat="server" Height="496px" Width="836px" 
    BackColor="#CCCCFF" BorderColor="#66CCFF" BorderStyle="Double" 
        style="margin-bottom: 4px">
    <table class="style2" 
        
            
        
        
            style="font-family: Arial, Helvetica, sans-serif; font-size: large; color: #000000; font-variant: normal; font-style: normal; font-weight: normal; height: 496px; width: 101%;">
        <tr>
            <td style="color: #FFFFFF;" align="center" bgcolor="White" colspan="2">
                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Gray"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:</td>
            <td>
                <asp:TextBox ID="txt_to" runat="server" Height="44px" TextMode="MultiLine" 
                    Width="631px"></asp:TextBox>
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
                <asp:TextBox ID="txtcc" runat="server" Visible="False" Height="22px" 
                    Width="592px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblbcc" runat="server" Text="To Bcc:" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtbcc" runat="server" Visible="False" Height="22px" 
                    Width="592px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;&nbsp;&nbsp; Subject:</td>
            <td>
                <asp:TextBox ID="txtsub" runat="server" Height="26px" Width="592px" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="lnkattachfile" runat="server" onclick="lnkattachfile_Click">Attach file</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" Visible="False" />
                &nbsp;<asp:Button ID="btnupload" runat="server" onclick="btnupload_Click" 
                    Text="Upload" Visible="False" />
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblaf1" runat="server" Visible="False"></asp:Label>
                &nbsp;&nbsp;
                <asp:Label ID="lblaf2" runat="server" Visible="False"></asp:Label>
                &nbsp;
                <asp:Label ID="lblaf3" runat="server" Visible="False"></asp:Label>
                &nbsp;
                <asp:Label ID="lblaf4" runat="server" Visible="False"></asp:Label>
                &nbsp;
                <asp:Label ID="lblaf5" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                &nbsp;&nbsp;Message:</td>
            <td>
                <asp:TextBox ID="txtmsg" runat="server" Height="103px" Width="631px" 
                    TextMode="MultiLine" ontextchanged="txtmsg_TextChanged"></asp:TextBox>
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
                <asp:Button ID="btnsend" runat="server" Text="Send" onclick="btnsend_Click" />
            </td>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="Save" onclick="btnsave_Click" />
            </td>
        </tr>
    </table>
</asp:Panel>
</asp:Content>

