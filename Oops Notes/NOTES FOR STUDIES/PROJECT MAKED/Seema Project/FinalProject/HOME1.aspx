<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HOME1.aspx.cs" Inherits="HOME1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            PostBackUrl="~/ADUser.aspx" CssClass="Text">Activate/Deactivate</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/DoctorInfo.aspx" 
            CssClass="Text">Doctor 
        Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/FloorInfo.aspx" 
            CssClass="Text">Floor Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/WingInfo.aspx" 
            CssClass="Text">Wing Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/WardInfo.aspx" 
            CssClass="Text" onclick="LinkButton5_Click">Ward 
        Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/RoomInfo.aspx" 
            CssClass="Text">Room 
        Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/BedInfo.aspx" 
            CssClass="Text">Bed 
        Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton8" runat="server" 
            PostBackUrl="~/ExpenseInfo.aspx" CssClass="Text" 
            onclick="LinkButton8_Click">Expense Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton9" runat="server" 
            PostBackUrl="~/Registration.aspx" CssClass="Text">Registration</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton10" runat="server" PostBackUrl="~/BedChange.aspx" 
            CssClass="Text">Bed Change</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton21" runat="server" CssClass="Text" 
            PostBackUrl="~/ChangeDoctor.aspx">Change Doctor</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton18" runat="server" CssClass="Text" 
            onclick="LinkButton18_Click">Add Expense</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton19" runat="server" CssClass="Text" 
            onclick="LinkButton19_Click">Add Payment</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton11" runat="server" 
            PostBackUrl="~/PrintDoctorInfo.aspx" CssClass="Text">Print Doctor Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton12" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintFloorInfo.aspx">Print Floor Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton13" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintWingInfo.aspx">Print Wing Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton14" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintWardInfo.aspx">Print Ward Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton15" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintRoomInfo.aspx">Print Room Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton16" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintBedInfo.aspx">Print Bed Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton17" runat="server" CssClass="Text" 
            PostBackUrl="~/PrintExpenseInfo.aspx">Print Expense Info</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton22" runat="server" CssClass="Text" 
            PostBackUrl="~/Feedback.aspx" onclick="LinkButton22_Click">Feedback</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton23" runat="server" CssClass="Text" 
            PostBackUrl="~/EnquiryForm.aspx">Enquiry Form</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton24" runat="server" CssClass="Text" 
            PostBackUrl="~/ConatctUs.aspx">Contact Us</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton25" runat="server" CssClass="Text" 
            PostBackUrl="~/VFeedback.aspx">View Feedback</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton26" runat="server" CssClass="Text" 
            PostBackUrl="~/VEnquiryForm.aspx">View Enquiry Form</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton27" runat="server" CssClass="Text" 
            PostBackUrl="~/VContactUs.aspx">View Contact Us</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton28" runat="server" CssClass="Text" 
            PostBackUrl="~/PatientBilling.aspx">Patient Billing</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton29" runat="server" CssClass="Text" 
            PostBackUrl="~/RFinalBill.aspx">Final Bill Report</asp:LinkButton>
    </div>
    </form>
</body>
</html>
