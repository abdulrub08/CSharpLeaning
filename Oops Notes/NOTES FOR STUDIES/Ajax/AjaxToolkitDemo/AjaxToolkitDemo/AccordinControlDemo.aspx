<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccordinControlDemo.aspx.cs" Inherits="AjaxToolkitDemo.AccordinControlDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    
        <h1>
            Accordin Control Demo</h1>
        <p>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
        </p>
        
    </div>
    <asp:Accordion ID="Accordion1" CssClass="accordion"  
    HeaderCssClass="accordionHeader"  
    HeaderSelectedCssClass="accordionHeaderSelected"  
    ContentCssClass="accordionContent"   
    runat="server">  
    <Panes>
    <asp:AccordionPane ID ="p1" runat ="server">
     <Header>
     Pane-1
     </Header> 
     <Content>
     Kanpur City
     </Content> 
    </asp:AccordionPane>
    <asp:AccordionPane ID ="AccordionPane1" runat ="server">
     <Header>
     Pane-2
     </Header> 
     <Content>
     Allahabad City
     </Content> 
    </asp:AccordionPane>
    
    <asp:AccordionPane ID ="AccordionPane2" runat ="server">
     <Header>
     Pane-3
     </Header> 
     <Content>
     Agra City
     </Content> 
    </asp:AccordionPane>    
    </Panes>
        
    </asp:Accordion>
    </form>
</body>
</html>
