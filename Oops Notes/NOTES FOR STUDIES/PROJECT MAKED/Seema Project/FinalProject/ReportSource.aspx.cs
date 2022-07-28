using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;


public partial class ReportSource : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
   
    protected void Button1_Click(object sender, EventArgs e)
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
            for (int i = 0; i < x.Length; i++)
            {
                if (i == 0)
                {
                    string sql = "select Loginname from Reportsource where Loginname='" + txtloginname.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "a");
                    DataTable dt;
                    dt = ds.Tables["a"];
                    int a = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            a = 1;
                            break;
                        }
                    }


                    if (a == 1)
                    {
                        Label1.Text = txtloginname.Text + " is already exists , please change login name.";

                        txtloginname.Focus();
                        return;
                    }
                }
                
              
                string page = "insert into Reportsource(Loginname,Pagename,Status)values('" + txtloginname.Text + "','" + x[i].ToString() + "','" + 1 + "')";
                SqlCommand cm = new SqlCommand();
                cm.Connection = cnn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = page;
                int p = 0;
                cnn.Open();
                p = cm.ExecuteNonQuery();
                cnn.Close();

                if (p == 0)
                {
                    Label1.Text = "Data is not saved.";
                    return;
                }
                else
                {
                    Label1.Text = "Your Data is Saved";

                }
            }

        }
        catch(Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
}