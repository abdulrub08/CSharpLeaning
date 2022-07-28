<%@ Page Language="C#" %>  
<%@ OutputCache Duration="60" VaryByParam="None" %>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<script runat="server">  
    protected void Page_Load(object sender, System.EventArgs e) {  
        Label2.Text = "Present Time: ";  
        Label2.Text += DateTime.Now.ToString();  
    }  
</script>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>asp.net caching example: how to use output caching</title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <h2 style="color:Red">asp.net example: Output Caching</h2>  
        <asp:Label   
             ID="Label1"  
             runat="server"  
             Font-Size="Large"   
             ForeColor="SeaGreen"  
             Text="Output Caching Duration: 60 seconds."  
             >  
        </asp:Label>  
        <br /><br />  
        <asp:Label   
             ID="Label2"  
             runat="server"  
             Font-Size="Large"   
             ForeColor="DodgerBlue"  
             >  
        </asp:Label>  
    </div>  
    </form>  
</body>  
</html> 
