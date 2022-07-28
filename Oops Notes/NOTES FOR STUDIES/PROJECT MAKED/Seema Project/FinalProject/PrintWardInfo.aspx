<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintWardInfo.aspx.cs" Inherits="PrintWardInfo" %>

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
    
        <asp:Panel ID="Panel1" runat="server" Height="421px">
            <table class="style1">
                <tr>
                    <td class="Text">
                        Print All Ward Details:</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" CssClass="Button" 
                            onclick="Button1_Click" Text="Print All" />
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Ward Wise Details:</td>
                    <td>
                        <asp:DropDownList ID="ddlWardNo" runat="server" AutoPostBack="True" 
                            CssClass="Dropdownlist">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnPrint" runat="server" CssClass="Button" 
                            onclick="btnPrint_Click" Text="Print" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
