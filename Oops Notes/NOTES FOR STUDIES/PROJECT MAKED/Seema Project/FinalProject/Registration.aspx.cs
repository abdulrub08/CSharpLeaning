using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Registration : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select DoctorName from DoctorInfo ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlDoctorsName.Items.Add(row[0].ToString());
                }
                break;
            }
            ddlDoctorsName.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
        if (Page.IsPostBack == false)
        {
            string sql = "select FloorNo from FloorInfo ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    rbtlFloorNo.Items.Add(row[0].ToString());
                }
                break;
            }
            //rbtlFloorNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //if (ddlTittle.SelectedIndex < 0)
        //{
        //    lblmsg.Text = "Please select any Tittle";
        //    return;
        //}
        if (txtFirstName.Text == "")
        {
            lblmsg.Text = "Please enter the First Name";
            txtFirstName.Focus();
            return;
        }
        if (txtLastName.Text == "")
        {
            lblmsg.Text = "Please enter the Last Name";
            txtLastName.Focus();
            return;
        }
        if (txtDOB.Text == "")
        {
            lblmsg.Text = "Please enter the Date Of Birth";
            txtDOB.Focus();
            return;
        }
        if (txtAddress.Text == "")
        {
            lblmsg.Text = "Please enter the Address";
            txtAddress.Focus();
            return;
        }
        if (txtFathersName.Text == "")
        {
            lblmsg.Text = "Please enter the Fathers Name";
            txtFathersName.Focus();
            return;
        }
        string alco;
        if (chkAlcoholic.Checked == true)
        {
            alco = "Yes";
        }
        else
        {
            alco = "No";
        }
        string bls;
        if (chkBloodSugar.Checked == true)
        {
            bls = "Yes";
        }
        else
        {
            bls = "No";
        }
        string smk;
        if (chkSmoking.Checked == true)
        {
            smk = "Yes";
        }
        else
        {
            smk = "No";
        }
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "spreg";
        
        cm.Parameters.Add("PType", SqlDbType.VarChar, 20);
        cm.Parameters["PType"].Value = ddlPatientType.SelectedItem.ToString();

        cm.Parameters.Add("Tittle", SqlDbType.VarChar, 10);
        cm.Parameters["Tittle"].Value = ddlTittle.SelectedItem.ToString();

        cm.Parameters.Add("FirstName", SqlDbType.VarChar, 10);
        cm.Parameters["FirstName"].Value = txtFirstName.Text;

        cm.Parameters.Add("MiddleName", SqlDbType.VarChar, 10);
        cm.Parameters["MiddleName"].Value = txtMiddleName.Text;

        cm.Parameters.Add("LastName", SqlDbType.VarChar, 10);
        cm.Parameters["LastName"].Value = txtLastName.Text;

        cm.Parameters.Add("DOB", SqlDbType.DateTime);
        cm.Parameters["DOB"].Value = txtDOB.Text;

        cm.Parameters.Add("Address", SqlDbType.VarChar, 50);
        cm.Parameters["Address"].Value = txtAddress.Text;

        cm.Parameters.Add("City", SqlDbType.VarChar, 30);
        cm.Parameters["City"].Value = txtCity.Text;

        cm.Parameters.Add("Pincode", SqlDbType.Int, 18);
        cm.Parameters["Pincode"].Value = txtPincode.Text;

        cm.Parameters.Add("ContactNo", SqlDbType.VarChar, 50);
        cm.Parameters["ContactNo"].Value = txtContactNo.Text;

        cm.Parameters.Add("EmailID", SqlDbType.VarChar, 30);
        cm.Parameters["EmailID"].Value = txtEmailID.Text;

        cm.Parameters.Add("Occupation", SqlDbType.VarChar, 30);
        cm.Parameters["Occupation"].Value = ddlOccupation.SelectedItem.ToString();

        cm.Parameters.Add("FathersName", SqlDbType.VarChar, 30);
        cm.Parameters["FathersName"].Value = txtFathersName.Text;

        cm.Parameters.Add("BloodGroup", SqlDbType.VarChar, 10);
        cm.Parameters["BloodGroup"].Value = ddlBloodGroup.SelectedItem.ToString();
        
        cm.Parameters.Add("Alcoholic", SqlDbType.VarChar, 10);
        cm.Parameters["Alcoholic"].Value = alco;

        cm.Parameters.Add("BloodSugar", SqlDbType.VarChar, 10);
        cm.Parameters["BloodSugar"].Value = bls;

        cm.Parameters.Add("Smoking", SqlDbType.VarChar, 10);
        cm.Parameters["Smoking"].Value = smk;

        cm.Parameters.Add("BloodPressure", SqlDbType.VarChar, 20);
        cm.Parameters["BloodPressure"].Value = txtBloodPressure.Text;

        cm.Parameters.Add("Weight", SqlDbType.VarChar, 10);
        cm.Parameters["Weight"].Value = txtWeight.Text;

        cm.Parameters.Add("Height", SqlDbType.VarChar, 10);
        cm.Parameters["Height"].Value = txtHeight.Text;

        cm.Parameters.Add("Description", SqlDbType.VarChar, 100);
        cm.Parameters["Description"].Value = txtDescription.Text;

        cm.Parameters.Add("Remark", SqlDbType.VarChar, 100);
        cm.Parameters["Remark"].Value = txtRemark.Text;

        cm.Parameters.Add("BedNo", SqlDbType.VarChar, 30);
        cm.Parameters["BedNo"].Value = rbtlBedNo.SelectedItem.ToString();

        cm.Parameters.Add("StartDate", SqlDbType.DateTime);
        cm.Parameters["StartDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("EntryDate", SqlDbType.DateTime);
        cm.Parameters["EntryDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("ADate", SqlDbType.DateTime);
        cm.Parameters["ADate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("EntryPerson", SqlDbType.VarChar, 30);
        cm.Parameters["EntryPerson"].Value = Session["LoginName"].ToString();

        cm.Parameters.Add("DoctorName", SqlDbType.VarChar, 30);
        cm.Parameters["DoctorName"].Value = ddlDoctorsName.SelectedItem.ToString();

        cm.Parameters.Add("Amount", SqlDbType.Int, 18);
        cm.Parameters["Amount"].Value = txtAmount.Text;

        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved.";
        }
        else
        {
            lblmsg.Text = "Data is saved.";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPincode.Text = "";
            txtContactNo.Text = "";
            txtEmailID.Text = "";
            txtFathersName.Text = "";
            txtBloodPressure.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
            txtDescription.Text = "";
            txtRemark.Text = "";
        }


    }
    protected void ddlDoctorsName_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select DoctorName,speciality,IPDFee,Address,ContactNo,ActiveStatus from DoctorInfo where DoctorName='"+ ddlDoctorsName.SelectedItem.ToString() +"'";
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
    }
    protected void rbtlFloorNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlWingName.Items.Clear();
        rbtlWardNo.Items.Clear();
        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select WingName from WingInfo where FloorNo='" + rbtlFloorNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlWingName.Items.Add(row[0].ToString());
            }
            break;
        }
    }
    protected void rbtlWingName_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlWardNo.Items.Clear();
        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select WardNo from WardInfo where WingName='" + rbtlWingName.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlWardNo.Items.Add(row[0].ToString());
            }
            break;
        } 
        
    }
    protected void rbtlWardNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select RoomNo from RoomInfo where WardNo='" + rbtlWardNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlRoomNo.Items.Add(row[0].ToString());
            }
            break;
        }
        
    }
    protected void rbtlRoomNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlBedNo.Items.Clear();
        string sql = "select BedNo from BedInfo where RoomNo='" + rbtlRoomNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlBedNo.Items.Add(row[0].ToString());
            }
            break;
        }
        
    }
    protected void rbtlBedNo_SelectedIndexChanged(object sender, EventArgs e)
    {
           
    }
}
