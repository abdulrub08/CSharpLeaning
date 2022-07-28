<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="stylesheet.css" />
 
 
 <style type="text/css">
        #headnear
        {
            height: 156px;
        }
        .quicklink_tab 
        {
	background-image: url(images/tab_quicklinks.gif);
	background-repeat: no-repeat;
	height: 42px;
	width: 137px;
        }

.quicklink_body li a:link
 {
	margin: 0px;
	height: 17px;
	width: 115px;
	display: block;
	padding-top: 3px;
	padding-right: 0px;
	padding-bottom: 0px;
	padding-left: 5px;
	border-bottom-width: 1px;
	border-bottom-style: solid;
	border-bottom-color: #0E617D;
	color:#FFFFFF;
	text-decoration:none;
}
.quicklink_body li a:visited {
	margin: 0px;
	height: 17px;
	width: 115px;
	display: block;
	padding-top: 3px;
	padding-right: 0px;
	padding-bottom: 0px;
	padding-left: 5px;
	border-bottom-width: 1px;
	border-bottom-style: solid;
	border-bottom-color: #0E617D;
	color:#FFFFFF;
	text-decoration:none;
}

.quicklink_body li a:hover {
	margin: 0px;
	height: 17px;
	width: 115px;
	display: block;
	padding-top: 3px;
	padding-right: 0px;
	padding-bottom: 0px;
	padding-left: 5px;
	border-bottom-width: 1px;
	border-bottom-style: solid;
	color:#FFFFFF;
	text-decoration:none;
	background-color:#0E617D;
}




.quicklink_body{
	color:#FFFFFF;
	background-image:url(images/menu_background.gif);
	background-repeat:repeat-x;
	width: 137px;
	height: 240px;
	margin: 0px;
	padding: 0px;
	}

        .side_menu_wrapper 
        {
	    float: right;
	    width: 137px;
	    height: auto;
	    font-family: Arial, Helvetica, sans-serif;
	    font-size: 11px;
	    color: #FFFFFF;
	    margin-right: 30px;
	    display:inline;
        }
        
        #midbar
        {
            height: 431px;
            width: 1116px;
        }
        
        .style1
     {
         color: #0066FF;
         font-weight: bold;
         font-size: xx-large;
     }
        
        .style2
     {
         font-size: large;
     }
        
        .style3
     {
         font-size: x-large;
     }
        
        .style4
     {
         width: 100%;
         height: 106px;
     }
     .style5
     {
         width: 119px;
         height: 90px;
     }
        
        .style7
     {         text-align: center;
     }
        
        .style11
     {
         width: 100%;
         height: 199px;
     }
        
        #textboder
     {
         height: 329px;
     }
        
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script type="text/javascript" src="stmenu.js"></script><body>

    <asp:Panel ID="Panel1" runat="server" Height="899px">
                         <div id="midbar" 
                             
                             style="border-style: none none solid none; border-width: thin; border-color: #f15a21">
                             <div id="cornerframeleft" 
                                 
                                 style=" background-image:url('image/crnerframeleft.png'); position:absolute; margin-top:128px; margin-left:0px; height: 308px; width:228px;"></div>                            
                             <div id="cornerframe" 
                                 
                                 style=" background-image:url('image/crnerframe.png'); position:absolute; margin-top:128px; margin-left:889px; height: 308px; width:228px;"></div>
                              
                             <div id="product" 
                                      style="background-image: url('image/picborder.png'); background-repeat: no-repeat; width: 240px; height: 250px;">
                                      <div style="position:absolute; margin-top:58px; margin-left:34px;"><asp:Image ID="Image2" runat="server" ImageUrl="~/image/product1.png"/></div>
                                      </div>
                             
                             
                             
                             
                             </div>
                             
                         
                       
                         <div id="midbar2" 
                             style="border-right-style: groove; border-right-width: thin; border-color: #000000">
                       
                             
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp; <span class="style1">C.M.D.&#39;S&nbsp; Message<br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                             <div id="frame" 
                                 
                                 
                                 style="position:absolute;  margin-top:-55px; margin-left:5px; background-image: url('image/imagermame.png'); background-repeat: no-repeat; top: 747px; left: 39px; height: 175px; width: 212px;">
                                <div id="inside" style="position:absolute; margin-left:22px; margin-top:20px;"><asp:Image ID="Image1" runat="server" ImageUrl="~/image/insideboder.png" /></div>
                             </div>
                             
                           
                             </div>
                             
                         
                         <div id="midbar3" >
                         <center>
        <h3> Enter the information<br /></h3>
                                <div style=" width: 617px; height: 244px;">
                                    <asp:Panel ID="Panel3" runat="server" Height="245px" Width="611px" 
                                        BackColor="Silver">
                                        <table style="height: 241px" >
                                            <tr>
                                                <td align="left" >
                                                    <asp:Label ID="lblname" runat="server" 
                                                        style="font-size: x-large; text-align: left;" Text="Login name : " 
                                                        Font-Size="Medium"></asp:Label>
                                                    
                                                </td>
                                                <td align="left">
                                                    
                                                    <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="150px"></asp:TextBox>
                                                    
                                                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="TextBox1" Display="Static" ErrorMessage="Missing User Name!" 
                                                        style="font-size: large"></asp:RequiredFieldValidator>
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    
                                                    &nbsp;&nbsp;&nbsp;
                                                    
                                                    <asp:Label ID="Password" runat="server" style="font-size: x-large" 
                                                        Text="Password : "></asp:Label>
                                                    </td>
                                                <td align="left">
                                                    
                                                    <asp:TextBox ID="TextBox2" runat="server" Width="150px" Height="30px"></asp:TextBox>
                                                    
                                                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="TextBox2" Display="Static" ErrorMessage="Rong Password ! " 
                                                        style="font-size: large"></asp:RequiredFieldValidator>
                                                    </td>
                                            </tr>
                                            <tr>
                                                <td align="left"  colspan="2">
                                                    &nbsp;
                                                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Font-Size="Large" 
                                                        ForeColor="Red"></asp:Label>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="left" >
                                                    </td>
                                                <td align="left" >
                                                    
                                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="37px" 
                                                        ImageUrl="~/image/Login.png" Width="111px" />
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left"  valign="top">
                                                    
                                                    <asp:LinkButton ID="LinkButton1" runat="server" style="font-size: medium" 
                                                        Font-Size="Medium">forget Password</asp:LinkButton>
                                                    
                                                </td>
                                               
                                                <td align="left" style="font-size: medium" valign="top">
                                                    Click Sign Up Button For Create a&nbsp; New Account&nbsp;
                                                    <asp:ImageButton ID="ImageButton3" runat="server" 
                                                        ImageUrl="~/image/sign-up.png" />
                                                </td>
                                                
                                                
                                                
                                            </tr>
                                            <tr>
                                                <td align="left" class="style7" colspan="2">
                                                    <cc1:DropShadowExtender ID="DropShadowExtender2" runat="server" Opacity="0.7" 
                                                        Radius="6" Rounded="True" TargetControlID="Panel3" TrackPosition="True" 
                                                        Width="7">
                                                    </cc1:DropShadowExtender>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                    </asp:Panel>
                                </div>
        </center>
                         </div>
                                         
                                         
                                         
                                         
     </asp:Panel>
    </body> 
</asp:Content>

