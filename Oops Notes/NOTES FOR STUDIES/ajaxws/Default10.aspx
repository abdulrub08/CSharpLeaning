<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default10.aspx.cs" Inherits="Default10" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <p>
        Notepad is a basic text editor that you can use to create simple documents. The 
        most common use for Notepad is to view or edit text (.txt) files, but many users 
        find Notepad a simple tool for creating Web pages.</p>
    <p>
        Because Notepad supports only very basic formatting, you cannot accidentally 
        save special formatting in documents that need to remain pure text. This is 
        especially useful when creating HTML documents for a Web page because special 
        characters or other formatting may not appear in your published Web page or may 
        even cause errors.</p>
    <p>
        You can save your Notepad files as Unicode, ANSI, UTF-8, or big-endian Unicode. 
        These formats provide you greater flexibility when working with documents that 
        use different character sets.</p>
    <p>
        Notepad is a basic text editor that you can use to create simple documents. The 
        most common use for Notepad is to view or edit text (.txt) files, but many users 
        find Notepad a simple tool for creating Web pages.</p>
    <p>
        Because Notepad supports only very basic formatting, you cannot accidentally 
        save special formatting in documents that need to remain pure text. This is 
        especially useful when creating HTML documents for a Web page because special 
        characters or other formatting may not appear in your published Web page or may 
        even cause errors.</p>
    <p>
        You can save your Notepad files as Unicode, ANSI, UTF-8, or big-endian Unicode. 
        These formats provide you greater flexibility when working with documents that 
        use different character sets.</p>
    <p>
        Notepad is a basic text editor that you can use to create simple documents. The 
        most common use for Notepad is to view or edit text (.txt) files, but many users 
        find Notepad a simple tool for creating Web pages.</p>
    <p>
        Because Notepad supports only very basic formatting, you cannot accidentally 
        save special formatting in documents that need to remain pure text. This is 
        especially useful when creating HTML documents for a Web page because special 
        characters or other formatting may not appear in your published Web page or may 
        even cause errors.</p>
    <p>
        You can save your Notepad files as Unicode, ANSI, UTF-8, or big-endian Unicode. 
        These formats provide you greater flexibility when working with documents that 
        use different character sets.</p>
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" BorderColor="Red" 
        BorderStyle="Solid" ForeColor="#000066" Height="89px" style="font-weight: 700" 
        Width="170px">
        <table class="style1">
            <tr>
                <td class="style2" style="background-color: #316AC5; color: #FFFFFF">
                    News</td>
                <td align="right" style="background-color: #316AC5">
                    <asp:Button ID="Button1" runat="server" BackColor="Red" BorderColor="White" 
                        BorderStyle="Solid" ForeColor="White" onclick="Button1_Click" 
                        style="font-weight: 700" Text="x" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    ASP.Net Silverlight workshop will be taken by sekhar @ PEERS</td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    <cc1:AlwaysVisibleControlExtender ID="Panel1_AlwaysVisibleControlExtender" 
        runat="server" Enabled="True" HorizontalOffset="10" HorizontalSide="Right" 
        TargetControlID="Panel1" VerticalOffset="10">
    </cc1:AlwaysVisibleControlExtender>
    </form>
</body>
</html>
