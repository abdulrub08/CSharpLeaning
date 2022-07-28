<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cdate.aspx.cs" Inherits="Cdate" %>

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
        <br />
        <table class="style1" bgcolor="#FFCCFF">
            <tr>
                <td align="center">
                    <table class="style1">
                        <tr>
                            <td bgcolor="#FFCCFF">
                                Select Date*</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                                    Enabled="True" TargetControlID="TextBox1">
                                </cc1:CalendarExtender>
                            </td>
                            <td align="center" rowspan="3">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/calender.jpg" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btncontinue" runat="server" onclick="btncontinue_Click" 
                                    Text="Continue" ForeColor="#003300" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Font-Size="Large" 
                                    ForeColor="#CC0000"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
