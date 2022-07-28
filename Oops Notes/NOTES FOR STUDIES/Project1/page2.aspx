<%@ Page Language="C#" %>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<script runat="server">  
    protected void Button1_Click(object sender, System.EventArgs e)  
    {  
        Panel1.Wrap = false;  
    }  
    protected void Button2_Click(object sender, System.EventArgs e)  
    {  
        Panel1.Wrap = true;  
    }  
</script>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>How to set, change Panel Wrap property programmatically</title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <h2 style="color:Navy; font-style:italic;">Panel Example: Wrap Property</h2>  
        <asp:Panel   
             ID="Panel1"  
             runat="server"  
             Height="150"  
             Width="350"  
             BorderWidth="3"  
             BorderColor="DimGray"  
             ScrollBars="Auto"  
             ForeColor="PaleVioletRed"  
             BackColor="Wheat"  
             Font-Size="Large"  
             Font-Names="Comic Sans MS"  
             >  
             <br />  
             This is a test line for panel content Wrap property test.  
        </asp:Panel>  
        <br /><br />  
        <asp:Button   
             ID="Button1"   
             runat="server"  
             ForeColor="DarkGray"  
             Text="Panel Wrap False"  
             Height="45"  
             OnClick="Button1_Click"  
             Font-Bold="true"  
             />  
        <asp:Button   
             ID="Button2"   
             runat="server"  
             ForeColor="DarkGray"  
             Text="Panel Wrap True"  
             Height="45"  
             OnClick="Button2_Click"  
             Font-Bold="true"  
             />  
    </div>  
    </form>  
</body>  
</html> 