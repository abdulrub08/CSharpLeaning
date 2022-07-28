<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default11.aspx.cs" Inherits="Default11" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" BackColor="#FF66FF" Height="125px" 
        style="font-weight: 700" Width="260px">
        Place the mouse over me!....<br />
    </asp:Panel>
    <cc1:AnimationExtender ID="Panel1_AnimationExtender" runat="server" 
        Enabled="True" TargetControlID="Panel1">
        <Animations>
        <OnMouseOver>
        <FadeOut Fps="55" Duration="2" />
        </OnMouseOver>
        <OnMouseOut>
        <FadeIn Fps="55" Duration="15" ></FadeIn>
        </OnMouseOut>
        </Animations>
      </cc1:AnimationExtender>
    </form>
</body>
</html>
