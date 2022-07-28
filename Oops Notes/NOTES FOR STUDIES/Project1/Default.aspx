<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
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
        
        </style>
<script type="text/javascript" src="stmenu.js"></script></head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
        
    
    <div style="border:  medium solid #0066CC; width: 1314px; margin-right: 0px;">
    <div id="blackhead" style="background-color:Black; height: 16px; width: 1314px;"></div>
    <div id="headnear"  style="background-image: url('image/head.jpg'); background-repeat: repeat-x; width: 1314px;"></div>
     <div style="background-image: url('image/mid.jpg'); background-repeat: repeat-x; height: 900px; width:1314px;">
     
    </div>
        
    
    <div style="background-color:Black; height: 9px; width:1314px;"></div>
    <div id="Div1" 
            style="background-image: url('image/foot.jpg'); background-repeat: repeat-x; height: 89px; width:1314px;"></div>
    </div>
    </form>
</body>
</html>
