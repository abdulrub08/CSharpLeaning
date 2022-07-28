<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccordinDemo.aspx.cs" Inherits="AjaxToolkitDemo.AccordinDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title>Simple Accordion</title>  
    <style type="text/css">  
        .accordion {  
            width: 400px;  
        }  
          
        .accordionHeader {  
            border: 1px solid #2F4F4F;  
            color: white;  
            background-color: #2E4d7B;  
            font-family: Arial, Sans-Serif;  
            font-size: 12px;  
            font-weight: bold;  
            padding: 5px;  
            margin-top: 5px;  
            cursor: pointer;  
        }  
          
        .accordionHeaderSelected {  
            border: 1px solid #2F4F4F;  
            color: white;  
            background-color: #5078B3;  
            font-family: Arial, Sans-Serif;  
            font-size: 12px;  
            font-weight: bold;  
            padding: 5px;  
            margin-top: 5px;  
            cursor: pointer;  
        }  
          
        .accordionContent {  
            background-color: #D3DEEF;  
            border: 1px dashed #2F4F4F;  
            border-top: none;  
            padding: 5px;  
            padding-top: 10px;  
        }  
    </style>  
  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
      
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
</asp:ToolkitScriptManager>  
     
<asp:Accordion   
    ID="Accordion1"   
    CssClass="accordion"  
    HeaderCssClass="accordionHeader"  
    HeaderSelectedCssClass="accordionHeaderSelected"  
    ContentCssClass="accordionContent"   
    runat="server">  
<Panes>  
    <asp:AccordionPane runat="server">  
        <Header>Pane 1</Header>  
        <Content>  
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.  
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.  
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.              
        </Content>  
    </asp:AccordionPane>  
    <asp:AccordionPane ID="AccordionPane1" runat="server">  
        <Header>Pane 2</Header>  
        <Content>  
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.  
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.  
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.  
        </Content>  
    </asp:AccordionPane>  
    <asp:AccordionPane ID="AccordionPane2" runat="server">  
        <Header>Pane 3</Header>  
        <Content>  
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.  
        Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.  
        Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.  
        </Content>  
    </asp:AccordionPane>  
</Panes>  
</asp:Accordion>  
     
    </div>  
    </form>  
</body>  
</html>  