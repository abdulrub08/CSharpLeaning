<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#99FF99" BorderColor="#006600" 
            BorderStyle="Solid" Height="357px" Width="523px">
            <br />
            
            <u>
            < marquee scrollamount=""10 direction="right" behaviour="alternate">
            RETAIL MANAGEMENT SYSTEM
            < /marquee>
            </u>
            <br />
            <br />
            <asp:LinkButton ID="lbnactideacti" runat="server" onclick="lbnactideacti_Click" 
                PostBackUrl="~/Aduser.aspx">Activate/Deactivate</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Companyinfo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Partyinfo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">Groupinfo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Unitinfo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Iteminfo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="Purchageinfo" runat="server" onclick="Purchageinfo_Click">Purchase 
            form</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">Stock 
            Transfer</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Stock 
            return</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Sale</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkfeedback" runat="server" onclick="lnkfeedback_Click">Feedback</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">Enquiry</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">Contactus</asp:LinkButton>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
