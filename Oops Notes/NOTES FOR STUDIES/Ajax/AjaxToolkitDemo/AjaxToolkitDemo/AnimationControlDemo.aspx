<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnimationControlDemo.aspx.cs" Inherits="AjaxToolkitDemo.AnimationControlDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>Yellow Fade</title>  
    <style type="text/css">  
      
    #Message {  
        width: 250px;  
        padding: 10px;     
        margin-bottom:10px;  
    }  
      
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
  
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
    </asp:ToolkitScriptManager>  
  
    <asp:Panel ID="Message" runat="server">  
    Pay attention to me!  
    </asp:Panel>  
  
    <asp:LinkButton ID="lnkYellowFade" OnClientClick="return false;" runat="server">Play Animation</asp:LinkButton>  
  
    <asp:AnimationExtender ID="AnimationExtender1" TargetControlID="lnkYellowFade" runat="server">  
    <Animations>  
        <OnClick>  
            <Sequence>  
            <Color   
                AnimationTarget="Message"   
                Duration="2"   
                Property="style"   
                PropertyKey="backgroundColor"  
                StartValue="#779DF7"   
                EndValue="#FFFFFF" />   
            </Sequence>  
        </OnClick>  
    </Animations>  
    </asp:AnimationExtender>  
  
    </div>  
    </form>  
</body>  
</html>  