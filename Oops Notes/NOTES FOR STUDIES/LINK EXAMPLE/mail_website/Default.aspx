<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #ADC9D1">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/>
    
    <asp:UpdatePanel ID="ChatUpdatePanel" runat="server" UpdateMode="Always">
    <ContentTemplate>
    CHATTERS:<br/>
        <asp:BulletedList ID="ChattersBulletedList" runat="server" BackColor="CadetBlue"/>
        Chat Text<br/>
        <div id="ChatText" style="width: 440px; height: 140px; overflow: auto; background-color: #B6E2B7;">
        <asp:BulletedList runat="server" ID="ChatMessageList" />
        </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="SendButton" EventName="Click"/>
            <asp:AsyncPostBackTrigger ControlID="ChatTextTimer" EventName="Tick" />
            
        </Triggers>
        
    </asp:UpdatePanel>
    Send Message Text<br />
    <asp:TextBox ID="NewMessageTextBox" Columns="50" runat="server" BackColor="White"/>
    <asp:Button EnableViewState="false" ID="SendButton" runat="server" Text="Send" OnClick="SendButton_Click" />
    <asp:Timer ID="ChatTextTimer" runat="server" Interval="1000"/>
    
    </form>
    <script type="text/javascript">
            function _SetChatTextScrollPosition() {
                var chatText = document.getElementById("ChatText");
                chatText.scrollTop = chatText.scrollHeight;
                window.setTimeout("_SetChatTextScrollPosition()", 1);
            }
            window.onload = function () {
                _SetChatTextScrollPosition();
            }
        </script>

</body>
</html>
