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

public partial class PatientBilling : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select RegNo from Registration where ActiveStatus=1 ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlRegNo.Items.Add(row[0].ToString());
                }
                break;
            }
            ddlRegNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
        //lblTotalDueAmount.Visible = false;
        //lblTotalRefundAmount.Visible = false;
    }
    public void ShowGrid1()
    {
        string sql = "select RegNo,BedNo,StartDate,EndDate,BedCharges,TotalDays,EntryDate,id from AddBed where ActiveStatus=1 and RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[7].ToString();
                break;
            }
        }
    }
    public void ShowGrid2()
    {
        string sql = "select RegNo,DoctorName,StartDate,EndDate,IPDFee,TotalDays,EntryDate,id from AddDoctor where ActiveStatus=1 and RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView2.DataSource = ds.Tables["a"];
        GridView2.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[7].ToString();
                break;
            }
        }
    }
    public void ShowGrid3()
    {
        string sql = "select RegNo,ExpenseName,Charges,EntryDate,id from AddExpense where ActiveStatus=1 and RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView3.DataSource = ds.Tables["a"];
        GridView3.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[4].ToString();
                break;
            }
        }
    }
    public void ShowGrid4()
    {
        string sql = "select RegNo,Amount,Tax,Discount,TotalAmount,EntryDate,id from AddPayment where ActiveStatus=1 and RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView4.DataSource = ds.Tables["a"];
        GridView4.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[4].ToString();
                break;
            }
        }
    }
    protected void ddlRegNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowGrid1();
        ShowGrid2();
        ShowGrid3();
        ShowGrid4();        
    }
    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public void TotalBedCharges()
    {
        Double Total_Bed_Charges = 0;
        string TotalDays;
        string charge;
        Double Total = 0;
        Double t1;
        Double t2;
        //string sql = "select DateDiff(Day,StartDate,CASE when EndDate='NULL' then EndDate='" + Session["cdate"].ToString() + "' else select EndDate),BedCharges from AddBed where RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        string sql = "select DateDiff(Day,StartDate,isnull(EndDate,'" + Session["cdate"].ToString() + "')),BedCharges from AddBed where RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                TotalDays = row[0].ToString();
                charge = row[1].ToString();
                t1 = Convert.ToDouble(TotalDays);
                t2 = Convert.ToDouble(charge);
                Total = t1 * t2;
                Total_Bed_Charges += Total;
            }
            break;
        }
        lblTBCharges.Text = Convert.ToString(Total_Bed_Charges); 
    }
    public void TotalDoctorCharges()
    {
        Double Total_Doctor_Charges = 0;
        string TotalDays;
        string IPDFee;
        Double Total = 0;
        Double t1;
        Double t2;
        string sql = "select DateDiff(Day,StartDate,isnull(EndDate,'" + Session["cdate"].ToString() + "')),IPDFee from AddDoctor where RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                TotalDays = row[0].ToString();
                IPDFee = row[1].ToString();
                t1 = Convert.ToDouble(TotalDays);
                t2 = Convert.ToDouble(IPDFee);
                Total = t1 * t2;
                Total_Doctor_Charges += Total;
            }
            break;
        }
        lblTDCharges.Text = Convert.ToString(Total_Doctor_Charges);
    }
    public void TotalExpenseCharges()
    {
        Double Total_Expense_Charges = 0;
        string Charges;
        string sql = "select sum(Charges) from AddExpense where RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                Charges = row[0].ToString();
                Total_Expense_Charges = Convert.ToDouble(Charges);
            }
            break;
        }
        lblTECharges.Text = Convert.ToString(Total_Expense_Charges);
    }
    
    public void TotalHospitalCharges()
    {
        Double Total_Hospital_Charges = 0;
        Double Total_Advance_Payment = 0;
        Double Total_Due_Amount = 0;
        Double Total_Refund_Amount = 0;
        Total_Hospital_Charges = Convert.ToDouble(lblTBCharges.Text)+Convert.ToDouble(lblTDCharges.Text)+Convert.ToDouble(lblTECharges.Text);
        lblTHCharges.Text = Convert.ToString(Total_Hospital_Charges);
        string Advance;
        string sql = "select Amount from AddAdvance where RegNo ='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                Advance = row[0].ToString();
                Total_Advance_Payment = Convert.ToDouble(Advance);
            }
            break;
        }
        lblTAPayment.Text = Convert.ToString(Total_Advance_Payment);
        if (Total_Hospital_Charges > Total_Advance_Payment)
        {
            lblTotalDueAmount.Visible = true;
            Total_Due_Amount = Total_Hospital_Charges - Total_Advance_Payment;
            lblTDAmount.Text = Convert.ToString(Total_Due_Amount);
        }
        else
        {
            lblTotalRefundAmount.Visible = true;
            Total_Refund_Amount = Total_Advance_Payment - Total_Hospital_Charges;
            lblTRAmount.Text = Convert.ToString(Total_Refund_Amount);
        }
    }
    protected void btnGenerateTemporaryBill_Click(object sender, EventArgs e)
    {
        TotalBedCharges();
        TotalDoctorCharges();
        TotalExpenseCharges();
        TotalHospitalCharges();
        if (lblTDAmount.Text == "0")
        {
            btnGenerateFinalBill.Visible = true;
        }
        else
        {
            btnGenerateFinalBill.Visible = false;
        }
        ////Double Amount = 0;
        ////Amount = Convert.ToDouble(lblTDAmount.Text);
        //if (lblTAPayment.Text == 0)
        //{
        //    btnGenerateFinalBill.Visible = true;
        //}
        ////else
        ////{
        ////    btnGenerateFinalBill.Visible = true;
        ////}
    }
    protected void btnGenerateFinalBill_Click(object sender, EventArgs e)
    {
        string sql = "insert into Discharge(RegNo,DischargeDate,TotalAmount,EntryDate,EntryPerson)values('" + ddlRegNo.SelectedItem.ToString() + "','" + Session["cdate"].ToString() + "'," + lblTAPayment.Text + ",'"+ Session["cdate"].ToString() +"','"+ Session["LoginName"].ToString() +"')";
        int a = 0;
        a = cs.DML(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not Saved";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully";
        }
        string sql1 = "update Registration set ActiveStatus=0 where RegNo='" + ddlRegNo.SelectedItem.ToString() + "'"; 
        int b = 0;
        b = cs.DML(sql1);
        if (b == 0)
        {
            lblmsg1.Text = "Data is not Updated";
        }
        else
        {
            lblmsg1.Text = "Data is Updated successfully";
        }
    } 
}
