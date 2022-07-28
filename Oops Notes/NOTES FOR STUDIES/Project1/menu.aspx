<%@ Page Language="C#" %>  
<%@ Import Namespace="System.Drawing" %>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<script runat="server">  
    protected void Button1_Click(object sender, System.EventArgs e)  
    {  
        Menu1.DynamicMenuItemStyle.BackColor = Color.MistyRose;  
        Menu1.DynamicMenuItemStyle.ForeColor = Color.Crimson;  
        Menu1.DynamicMenuItemStyle.Font.Italic = false;  
    }  
    protected void Button2_Click(object sender, System.EventArgs e)  
    {  
        Menu1.DynamicMenuItemStyle.ForeColor = Color.SkyBlue;  
        Menu1.DynamicMenuItemStyle.BackColor = Color.Snow;  
        Menu1.DynamicMenuItemStyle.Font.Italic = true;  
    }  
</script>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>How to set, change dynamic menu item style in Menu control</title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <h2 style="color:Navy; font-style:italic;">Menu Example: DynamicMenuItemStyle</h2>  
        <asp:SiteMapDataSource   
             ID="SiteMapDataSource1"   
             runat="server"  
             />  
        <div style="height:150px">  
            <asp:Menu   
                 ID="Menu1"   
                 runat="server"   
                 DataSourceID="SiteMapDataSource1"  
                 Font-Bold="true"  
                 ForeColor="OliveDrab"  
                 >  
            </asp:Menu>  
        </div>  
        <asp:Button   
             ID="Button1"   
             runat="server"  
             ForeColor="Salmon"  
             Text="Chnage DynamicMenuItemStyle"  
             Height="45"  
             OnClick="Button1_Click"  
             Font-Bold="true"  
             />  
        <asp:Button   
             ID="Button2"   
             runat="server"  
             ForeColor="Salmon"  
             Text="Another DynamicMenuItemStyle"  
             Height="45"  
             OnClick="Button2_Click"  
             Font-Bold="true"  
             />  
    </div>  
    </form>  
</body>  
</html> 