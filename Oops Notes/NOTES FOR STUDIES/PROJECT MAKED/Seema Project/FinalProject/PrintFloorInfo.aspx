<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintFloorInfo.aspx.cs" Inherits="PrintFloorInfo" %>

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
    
        <asp:Panel ID="Panel1" runat="server" Height="347px">
            <table class="style1">
                <tr>
                    <td class="Text">
                        Print All Floor Details:</td>
                    <td>
                        <asp:Button ID="btnPrintAll" runat="server" CssClass="Button" 
                            onclick="btnPrintAll_Click" Text="Print All" />
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Floor Wise Details:</td>
                    <td>
                        <asp:DropDownList ID="ddlFloorNo" runat="server" CssClass="Dropdownlist">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnPrint" runat="server" CssClass="Button" Text="Print" 
                            onclick="btnPrint_Click" />
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
