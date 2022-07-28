    <%@ Page Language="C#" %>  
      
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
      
    <script runat="server">  
        protected void Button1_Click(object sender, System.EventArgs e)  
        {  
            Panel1.ScrollBars = ScrollBars.Both;  
            Label1.Text = "Panel ScrollBars now Both";  
        }  
        protected void Button2_Click(object sender, System.EventArgs e)  
        {  
            Panel1.ScrollBars = ScrollBars.None;  
            Label1.Text = "Panel ScrollBars now None";  
        }  
    </script>  
      
    <html xmlns="http://www.w3.org/1999/xhtml">  
    <head id="Head1" runat="server">  
        <title>How to set, change Panel ScrollBars property Both or None</title>  
    </head>  
    <body>  
        <form id="form1" runat="server">  
        <div>  
            <h2 style="color:Navy; font-style:italic;">Panel Example: ScrollBars Both/None</h2>  
            <asp:Label   
                 ID="Label1"  
                 runat="server"  
                 Font-Bold="true"  
                 Font-Italic="true"  
                 Font-Size="Large"  
                 ForeColor="Tomato"  
                 >  
            </asp:Label>  
            <br /><br />  
            <asp:Panel   
                 ID="Panel1"  
                 runat="server"  
                 Height="150"  
                 Width="350"  
                 BorderWidth="3"  
                 BorderColor="DarkGreen"  
                 ScrollBars="Auto"  
                 ForeColor="AliceBlue"  
                 BackColor="MediumSeaGreen"  
                 Font-Size="Large"  
                 Font-Names="Comic Sans MS"  
                 >  
                 <br />  
                 This is a test line for panel ScrollBars  
                 property Both or None test.  
            </asp:Panel>  
            <br /><br />  
            <asp:Button   
                 ID="Button1"   
                 runat="server"  
                 ForeColor="SeaGreen"  
                 Text="Panel ScrollBars Both"  
                 Height="45"  
                 OnClick="Button1_Click"  
                 Font-Bold="true"  
                 />  
            <asp:Button   
                 ID="Button2"   
                 runat="server"  
                 ForeColor="SeaGreen"  
                 Text="Panel ScrollBars None"  
                 Height="45"  
                 OnClick="Button2_Click"  
                 Font-Bold="true"  
                 />  
        </div>  
        </form>  
    </body>  
    </html>  