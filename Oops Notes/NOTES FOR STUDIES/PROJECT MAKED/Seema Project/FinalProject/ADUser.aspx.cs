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
using System.Data.SqlClient;

public partial class ADUser : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            if (Session["loginName"].ToString() == "Admin")
            {

            }
            else
            {
                Response.Redirect("AccessDenied.aspx");
            }

        }
    }
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
   MyConnectionString cs = new MyConnectionString();
    protected void ddlLoginName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string sql = "select UserName,LoginName,Address,ContactNo,Remark,ActiveStatus from UserInfo where LoginName='" + ddlLoginName.SelectedItem.ToString() + "'";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DetailsView1.DataSource = ds.Tables["a"];
            DetailsView1.DataBind();
            DataTable dt = ds.Tables["a"];
            string activestate = "";
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    activestate = row[5].ToString();
                    break;
                }
            }
            ddlLoginName.Items.Insert(0, new ListItem("--Please Select--", "0"));
            if (activestate == "True")
            {
                btnUpdate.Text = "DeAactivate User";
            }
            else
            {
                btnUpdate.Text = "Activate User";
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            string[] x = new string[39];
            x[0] = "AccessDenied.aspx";
            x[1] = "AddExpense.aspx";
            x[2] = "AddPayment.aspx";
            x[3] = "ADUser.aspx";
            x[4] = "BedChange.aspx";
            x[5] = "BedInfo.aspx";
            x[6] = "Captcha.aspx";
            x[7] = "Cdate.aspx";
            x[8] = "ChangeDocter.aspx";
            x[9] = "ContactUs.aspx";
            x[10] = "Default.aspx";
            x[11] = "Default7.aspx";
            x[12] = "DocterInfo.aspx";
            x[13] = "EnquiryForm.aspx";
            x[14] = "ExpenseInfo.aspx";
            x[15] = "Feedback.aspx";
            x[16] = "FloorInfo.aspx";
            x[17] = "Home.aspx";
            x[18] = "PatientBilling.aspx";
            x[19] = "PrintBedInfo.aspx";
            x[20] = "PrintDocterInfo.aspx";
            x[21] = "PrintExpenseDetails.aspx";
            x[22] = "PrintFloorInfo.aspx";
            x[23] = "PrintRoomInfo.aspx";
            x[24] = "PrintWarsInfo.aspx";
            x[25] = "PrintWingInfo.aspx";
            x[26] = "Registration.aspx";
            x[27] = "Report.aspx";
            x[28] = "ReportSource.aspx";
            x[29] = "RFinalBill.aspx";
            x[30] = "RoomInfo.aspx";
            x[31] = "UpdateAddExpense.aspx";
            x[32] = "UpdateAddPayment.aspx";
            x[33] = "VContactUs.aspx";
            x[34] = "VEnquiryForm.aspx";
            x[35] = "Vfeedback.aspx";
            x[36] = "WardInfo.aspx";
            x[37] = "Welcome.aspx";
            x[38] = "WingInfo.aspx";
            string sql1 = "";
            if (btnUpdate.Text == "Activate User")
            {
                sql1 = "update UserInfo set ActiveStatus=1 where LoginName='" + ddlLoginName.SelectedItem.ToString() + "'";

            }
            else
            {

                sql1 = "update UserInfo set ActiveStatus=0 where LoginName='" + ddlLoginName.SelectedItem.ToString() + "'";



            }
            int a = 0;
            a = cs.DML(sql1);
            if (a == 0)
            {

                lblmsg.Text = "Data is not Updated";

            }
            else
            {


                lblmsg.Text = "Data is Updated";

            }
            for (int i = 0; i < x.Length; i++)
            {
                if (i == 0)
                {
                    string sql = "select Loginname from Reportsource where Loginname='" + ddlLoginName.SelectedItem.ToString() + "'";
                    DataSet ds = new DataSet();
                    int a1 = 0;
                    ds = cs.SelectOuery(sql);
                    DataTable dt;
                    dt = ds.Tables["a"];
                    
                    foreach (DataColumn col in dt.Columns)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            a1 = 1;
                            break;
                        }
                    }


                    if (a1 == 1)
                    {
                        lblmsg.Text = ddlLoginName.SelectedItem.ToString() + " is already exists , please change login name.";

                        ddlLoginName.Focus();
                        return;
                    }
                }


                string page = "insert into Reportsource(Loginname,Pagename)values('" + ddlLoginName.SelectedItem.ToString() + "','" + x[i].ToString() + "')";

                int p = 0;
                p = cs.DML(page);

                if (p == 0)
                {
                    lblmsg.Text = "Data is not saved.";
                    return;
                }
                else
                {
                    lblmsg.Text = "Your Data is Saved";

                }
            }


        }
        catch (Exception ex1)
        {
            lblmsg.Text = ex1.Message;
        }
        finally
        {
            
            

        }
            
        }


        
    
   
    
}
