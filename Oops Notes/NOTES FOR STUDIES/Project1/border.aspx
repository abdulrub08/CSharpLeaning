<%@ Page Language="C#" %>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<script runat="server">  
    protected void Button1_Click(object sender, System.EventArgs e)  
    {  
        Image1.BorderStyle = BorderStyle.Inset;  
  
    }  
    protected void Button2_Click(object sender, System.EventArgs e)  
    {  
        Image1.BorderStyle = BorderStyle.Outset;  
    }  
</script>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>How to set, change Image border style programmatically</title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <h2 style="color:Navy; font-style:italic;">Image Example: BorderStyle</h2>  
        <asp:Image   
             ID="Image1"   
             runat="server"  
             BorderColor="SteelBlue"  
             BorderWidth="5"  
             ImageUrl="~/image/career.png"  
             />  
        <br /><br />  
        <asp:Button   
             ID="Button1"   
             runat="server"  
             ForeColor="IndianRed"  
             Text="Image BorderStyle Inset"  
             Height="45"  
             OnClick="Button1_Click"  
             Font-Bold="true"  
             />  
        <asp:Button   
             ID="Button2"   
             runat="server"  
             ForeColor="IndianRed"  
             Text="Image BorderStyle Outset"  
             Height="45"  
             OnClick="Button2_Click"  
             Font-Bold="true"  
             />  
    </div>  
    </form>  
</body>  
</html> 