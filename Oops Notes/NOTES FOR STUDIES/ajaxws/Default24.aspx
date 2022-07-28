<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default24.aspx.cs" Inherits="Default24" %>

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
    </style>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <table class="style1">
        <tr align="center" style="background-color: #FF6600; color: #FFFFFF">
            <td>
                Elective I</td>
            <td>
                Elective II</td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Windows Appl. using VB.Net" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox1_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option1" TargetControlID="CheckBox1">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" 
                    Text="Windows Appl. using Visual C#" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox4_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option1" TargetControlID="CheckBox4">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" Text="ASP.Net Appl. using VB.Net" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox2_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option2" TargetControlID="CheckBox2">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox5" runat="server" 
                    Text="ASP.Net Appl. using Visual C#" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox5_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option2" TargetControlID="CheckBox5">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" Text="SQL Server" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox3_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option3" TargetControlID="CheckBox3">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox6" runat="server" Text="ASP.Net Web Services" />
                <cc1:MutuallyExclusiveCheckBoxExtender ID="CheckBox6_MutuallyExclusiveCheckBoxExtender" 
                    runat="server" Enabled="True" Key="option3" TargetControlID="CheckBox6">
                </cc1:MutuallyExclusiveCheckBoxExtender>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
