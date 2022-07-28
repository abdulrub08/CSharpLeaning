<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlwayVisibleDemo.aspx.cs" Inherits="AjaxToolkitDemo.AlwayVisibleDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>Simple AlwaysVisible</title>  
    <style type="text/css">  
        html {  
            background-color: #cccccc;     
        }  
          
        .staticPanel {  
             width: 150px;  
             background-color: White;    
             border: solid 1px black;  
             padding: 10px;   
        }  
      
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
      
              
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
    </asp:ToolkitScriptManager>  
  
    <asp:Panel ID="Panel1" CssClass="staticPanel" runat="server">  
        <h2>Hello World!</h2>  
    </asp:Panel>  
  
    <asp:AlwaysVisibleControlExtender   
        ID="AlwaysVisibleControlExtender1"   
        TargetControlID="Panel1"  
        VerticalSide="Bottom"  
        VerticalOffset="10"  
        HorizontalSide="Right"  
        HorizontalOffset="10"  
        runat="server" />  
      
    <p>  
    Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.  
    </p>  
    <p>  
    Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.  
    </p>  
    <p>  
    Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.  
    </p>  
  
  
    </div>  
    </form>  
</body>  
</html>  