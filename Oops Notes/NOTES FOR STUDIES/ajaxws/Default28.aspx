<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default28.aspx.cs" Inherits="Default28" %>

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
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
        <HeaderTemplate>
        Home
        </HeaderTemplate>
        <ContentTemplate>
        Notepad is a basic text editor that you can use to create simple documents. The most common use for Notepad is to view or edit text (.txt) files, but many users find Notepad a simple tool for creating Web pages.

Because Notepad supports only very basic formatting, you cannot accidentally save special formatting in documents that need to remain pure text. This is especially useful when creating HTML documents for a Web page because special characters or other formatting may not appear in your published Web page or may even cause errors.

You can save your Notepad files as Unicode, ANSI, UTF-8, or big-endian Unicode. These formats provide you greater flexibility when working with documents that use different character sets.
        </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel2">
        <HeaderTemplate>
        Login
        </HeaderTemplate>
        <ContentTemplate>
            <asp:Login ID="Login1" runat="server">
            </asp:Login>
        </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel3">
        <HeaderTemplate>
        Register
        </HeaderTemplate>
        <ContentTemplate>
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                <WizardSteps>
                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                    </asp:CompleteWizardStep>
                </WizardSteps>
            </asp:CreateUserWizard>
        </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>
    
    
    
    
    
    </form>
</body>
</html>
