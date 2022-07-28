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

public partial class AddPayment : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Session["mode"].ToString() == "Update")
            {
                string sql = "select RegNo,Amount,Tax,Discount,TotalAmount,Description from AddPayment where id=" + Session["id"].ToString() + "";
                DataSet ds = new DataSet();
                ds = cs.SelectOuery(sql);
                DataTable dt = ds.Tables["a"];
                foreach (DataColumn col in dt.Columns)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ddlRegNo.Text = row[0].ToString();
                        txtAmount.Text = row[1].ToString();
                        txtTax.Text = row[2].ToString();
                        txtDiscount.Text = row[3].ToString();
                        txtTotalAmount.Text = row[4].ToString();
                        txtDescription.Text = row[5].ToString();
                    }
                }
            }
        }
        if (Page.IsPostBack == false)
        {
           string sql = "select RegNo from Registration where ActiveStatus=1";
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
        }
    }
    protected void ddlRegNo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,Amount,Tax,Discount,TotalAmount from AddPayment where RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
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
                actives = row[4].ToString();
                break;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtAmount.Text == "")
        {
            lblmsg.Text = "Please Enter the Amount";
            txtAmount.Focus();
        }
        if (txtTax.Text == "")
        {
            lblmsg.Text = "Please Enter the Tax";
            txtTax.Focus();
        }
        if (txtDiscount.Text == "")
        {
            lblmsg.Text = "Please Enter the Discount";
            txtDiscount.Focus();
        }
        if (txtTotalAmount.Text == "")
        {
            lblmsg.Text = "Please Enter the Total Amount";
            txtTotalAmount.Focus();
        }
        if (Session["mode"].ToString() == "Save")
        {
            string sql = "insert into AddPayment(RegNo,Amount,Tax,Discount,TotalAmount,Description,EntryDate,EntryPerson)values('" + ddlRegNo.SelectedItem.ToString() + "'," + txtAmount.Text + "," + txtTax.Text + "," + txtDiscount.Text + "," + txtTotalAmount.Text + ",'" + txtDescription.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Saved";
            }
        }
        else
        {
            string sql = "update AddPayment set RegNo='" + ddlRegNo.SelectedItem.ToString() + "',Amount=" + txtAmount.Text + ",Tax=" + txtTax.Text + ",Discount=" + txtDiscount.Text + ",TotalAmount=" + txtTotalAmount.Text + ",Description='" + txtDescription.Text + "' where id=" + Session["id"].ToString() + " ";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Updated";
            }
        }
    }
    protected void btnCFUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateAddPayment.aspx");
    }
}
