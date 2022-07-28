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

public partial class DoctorInfo : System.Web.UI.Page
{
    public void ShowGridData()
    {
        string sql = "select DoctorName,Speciality,IPDFee,Address,ContactNo,MobileNo,id from DoctorInfo where ActiveStatus=1";
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
                actives = row[6].ToString();
                break;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ShowGridData();
            lblid.Text = "";
            lblmode.Text = "Save";
        }
    }
    MyConnectionString cs=new MyConnectionString();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtDoctorName.Text == "")
        {
            lblmsg.Text = "Please enter the Doctor's Name";
            txtDoctorName.Focus();
            return;
        }
        if (txtSpeciality.Text == "")
        {
            lblmsg.Text = "Please enter the Speciality of Doctor";
            txtSpeciality.Focus();
            return;
        }
        if (txtIPDFee.Text == "")
        {
            lblmsg.Text = "Please enter the IPDFee of Doctor";
            txtIPDFee.Focus();
            return;
        }
        if (txtAddress.Text == "")
        {
            lblmsg.Text = "Please enter the Address of Doctor";
            txtAddress.Focus();
            return;
        }
        if (txtContactNo.Text == "")
        {
            lblmsg.Text = "Please enter the Contact No. of Doctor";
            txtContactNo.Focus();
            return;
        }

        if (lblmode.Text == "Save")
        {
            string sql = "insert into DoctorInfo(DoctorName,Speciality,IPDFee,Address,emailid,ContactNo,MobileNo,Remark,EntryDate,EntryPerson)values('" + txtDoctorName.Text + "','" + txtSpeciality.Text + "','" + txtIPDFee.Text + "','" + txtAddress.Text + "','" + txtemailid.Text + "','" + txtContactNo.Text + "','" + txtMobileNo.Text + "','" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "') ";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is saved successfully";
                txtDoctorName.Text = "";
                txtSpeciality.Text = "";
                txtIPDFee.Text = "";
                txtAddress.Text = "";
                txtemailid.Text = "";
                txtContactNo.Text = "";
                txtMobileNo.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }

        }
        else
        {
            string sql = "update DoctorInfo set DoctorName='"+ txtDoctorName.Text +"',Speciality='"+ txtSpeciality.Text +"',IPDFee='"+ txtIPDFee.Text +"',Address='"+ txtAddress.Text +"',MobileNo='"+ txtMobileNo.Text +"'where id="+ lblid.Text +"";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is Updated";
                txtDoctorName.Text = "";
                txtSpeciality.Text = "";
                txtIPDFee.Text = "";
                txtAddress.Text = "";
                txtemailid.Text = "";
                txtContactNo.Text = "";
                txtMobileNo.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[7].Text;
        string sql = "select DoctorName,Speciality,IPDFee,Address,ContactNo,MobileNo from DoctorInfo where id='"+ id +"'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtDoctorName.Text = row[0].ToString();
                txtSpeciality.Text= row[1].ToString();
                txtIPDFee.Text = row[2].ToString();
                txtAddress.Text = row[3].ToString();
                txtContactNo.Text = row[4].ToString();
                txtMobileNo.Text = row[5].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }
}
