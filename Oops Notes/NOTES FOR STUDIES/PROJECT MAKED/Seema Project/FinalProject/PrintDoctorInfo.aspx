<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintDoctorInfo.aspx.cs" Inherits="PrintDoctorInfo" %>

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
    
        <asp:Panel ID="Panel1" runat="server" Height="246px" Width="816px">
            <table class="style1">
                <tr>
                    <td class="Text">
                        Print All Doctor Details:</td>
                    <td>
                        <asp:Button ID="btnPrintAll" runat="server" CssClass="Button" 
                            onclick="btnPrintAll_Click" Text="Print All" />
                    </td>
                </tr>
                <tr>
                    <td class="Text">
                        Doctor Wise Details:</td>
                    <td>
                        <asp:DropDownList ID="ddlDoctorName" runat="server" AutoPostBack="True">
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
