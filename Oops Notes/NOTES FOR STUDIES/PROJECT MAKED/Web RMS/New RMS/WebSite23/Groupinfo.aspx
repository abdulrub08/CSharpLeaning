﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Groupinfo.aspx.cs" Inherits="Groupinfo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 313px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblheading" runat="server" Text="Group Information Form"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Label ID="lblid" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblmode" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Log-out</asp:LinkButton>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="611px">
                    <asp:Label ID="lblmsg" runat="server" ForeColor="#CC0000"></asp:Label>
                    <br />
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                        Height="351px" Width="654px">
                        
                        
                    &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Show All Group"><HeaderTemplate>
Show All Group
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        </HeaderTemplate>
<ContentTemplate>
<asp:Panel ID="Panel3" runat="server" BackColor="#FFCCFF" 
                                BorderColor="#990033" BorderStyle="Inset" 
        Height="326px" Width="889px"><asp:GridView 
                                ID="GridView1" runat="server" AutoGenerateSelectButton="True" Height="237px" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" Width="484px"></asp:GridView></asp:Panel>
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        </ContentTemplate>
</cc1:TabPanel>&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Add New Group"><ContentTemplate>
<asp:Panel ID="Panel2" runat="server" BackColor="#FFCCFF" 
                                BorderColor="#990033" BorderStyle="Inset" Font-Bold="True" Font-Size="Large" 
                                Height="319px" Width="630px"><table class="style1"><tr><td>Group Name*</td><td><asp:TextBox 
                                    ID="txtgroupname" runat="server" Height="34px" Width="172px"></asp:TextBox>


</td></tr><tr><td>Description</td><td><asp:TextBox 
                                        ID="txtdescription" runat="server" TextMode="MultiLine"></asp:TextBox>


</td></tr><tr><td>Remark</td><td><asp:TextBox 
                                        ID="txtremark" runat="server" TextMode="MultiLine"></asp:TextBox>


</td></tr><tr><td 
                                        align="center" colspan="2"><asp:Button ID="btnsubmit" runat="server" 
                                        onclick="btnsubmit_Click" Text="Submit" />


</td></tr></table></asp:Panel>
                        

                        
                        

                        

                        
                        
                        

                        

                        
                        

                        

                        
                        
                        
                        
                        

                        
                        

                        

                        
                        
                        

                        

                        
                        

                        

                        
                        
                        
                        
                        </ContentTemplate>
</cc1:TabPanel>&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;</cc1:TabContainer>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>