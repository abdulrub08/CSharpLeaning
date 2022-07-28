<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="Default9" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <cc1:Accordion ID="Accordion1" runat="server">
    <Panes>
        <cc1:AccordionPane ID="AccordionPane1" runat="server">
        <Header>
        <u>Chapter 1</u>
        </Header>
        <Content>
            <asp:Panel ID="Panel1" runat="server" BackColor="#999966">
 Accordion : It is used to a collection of AccordionPanes which expands a single pane and collapses all the other panes present within the collection.

AccordionPane : It is used to create a single pane for the Accordion control.
            </asp:Panel>
        </Content>
        </cc1:AccordionPane>
                <cc1:AccordionPane ID="AccordionPane2" runat="server">
        <Header>
        <u>Chapter 2</u>
        </Header>
        <Content>
            <asp:Panel ID="Panel2" runat="server" BackColor="#669999">
 Accordion : It is used to a collection of AccordionPanes which expands a single pane and collapses all the other panes present within the collection.

AccordionPane : It is used to create a single pane for the Accordion control.
            </asp:Panel>
        </Content>
        </cc1:AccordionPane>

                <cc1:AccordionPane ID="AccordionPane3" runat="server">
        <Header>
        <u>Chapter 3</u>
        </Header>
        <Content>
            <asp:Panel ID="Panel3" runat="server" BackColor="#CC6699">
 Accordion : It is used to a collection of AccordionPanes which expands a single pane and collapses all the other panes present within the collection.

AccordionPane : It is used to create a single pane for the Accordion control.
            </asp:Panel>
        </Content>
        </cc1:AccordionPane>

        
    </Panes>
    </cc1:Accordion>
    </form>
</body>
</html>


