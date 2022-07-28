using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class RFinalBill : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,PType,Tittle,FirstName,MiddleName,LastName,DOB,Address,ContactNo,Occupation,FathersName from Registration where RegNo='"+ txtRegNo.Text +"' and ActiveStatus=1";

        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        DetailsView1.DataSource=ds.Tables["a"];
        DetailsView1.DataBind();
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[10].ToString();
                break;
            }
        }
        
    }
    protected void btnPrintBedDetails_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,BedNo,StartDate,EndDate,BedCharges,EntryDate from AddBed where RegNo='"+ txtRegNo.Text +"' and ActiveStatus=1 ";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        Session["Mydataset"] = ds;
        Session["PageName"] = "PrintBedDetails";
        Response.Redirect("Report.aspx");
    }
    protected void btnPrintDoctorDetails_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,DoctorName,StartDate,EndDate,IPDFee,EntryDate from AddDoctor where RegNo='" + txtRegNo.Text + "' and ActiveStatus=1 ";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        Session["Mydataset"] = ds;
        Session["PageName"] = "PrintDoctorDetails";
        Response.Redirect("Report.aspx");
    }
    protected void btnPrintExpenseDetails_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,ExpenseName,Charges,EntryDate from AddExpense where RegNo='" + txtRegNo.Text + "' and ActiveStatus=1 ";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        Session["Mydataset"] = ds;
        Session["PageName"] = "PrintExpenseDetails";
        Response.Redirect("Report.aspx");
    }
    protected void btnPrintPaymentDetails_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,Amount,Tax,Discount,TotalAmount,EntryDate from AddPayment where RegNo='" + txtRegNo.Text + "' and ActiveStatus=1 ";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        Session["Mydataset"] = ds;
        Session["PageName"] = "PrintPaymentDetails";
        Response.Redirect("Report.aspx");
    }
    protected void btnPrintDischargeSlip_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,DischargeDate,TotalAmount,EntryDate from Discharge";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        Session["Mydataset"] = ds;
        Session["PageName"] = "PrintDischargeSlip";
        Response.Redirect("Report.aspx");
    }
}
