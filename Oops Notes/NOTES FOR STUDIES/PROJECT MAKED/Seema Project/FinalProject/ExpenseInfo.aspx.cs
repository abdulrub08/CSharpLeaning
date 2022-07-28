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

public partial class ExpenseInfo : System.Web.UI.Page
{
    
    public void ShowGridData()
    {
        string sql = "select * from ExpenseInfo where ActiveStatus=1";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        //string actives = "";
        //foreach (DataColumn col in dt.Columns)
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        actives = row[3].ToString();
        //        break;
        //    }
        //}
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
    MyConnectionString cs = new MyConnectionString();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[1].Text;
        string sql = "select ExpenseName,Description,charges,tax,tamt,discount from ExpenseInfo where id='" + id + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtExpenseName.Text = row[0].ToString();
                txtDescription.Text = row[1].ToString();
                txtCharges.Text = row[2].ToString();
                txttaxchrg.Text = row[3].ToString();
                txtdiscount.Text = row[5].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }
    protected void btnsbmt_Click(object sender, EventArgs e)
    {
        if (txtExpenseName.Text == "")
        {
            lblmsg.Text = "please enter the Expense Name";
            txtExpenseName.Focus();
            return;
        }
        if (txtDescription.Text == "")
        {
            lblmsg.Text = "please enter the Description";
            txtDescription.Focus();
            return;
        }
        if (txtCharges.Text == "")
        {
            lblmsg.Text = "please enter the Charges";
            txtCharges.Focus();
            return;
        }
        double charges=double.Parse(txtCharges.Text);
        double tax = double.Parse(txttaxchrg.Text);
        double discount = double.Parse(txtdiscount.Text);
        tax = (tax * charges) / 100;
        //discount = charges - discount;
        double tamt = (charges + tax) - discount;
        if (lblmode.Text == "Save")
        {
            int a = 0;
            a = cs.DML("insert into ExpenseInfo(ExpenseName,Description,Charges,Remark,EntryDate,EntryPerson,tax,tamt,discount)values('" + txtExpenseName.Text + "','" + txtDescription.Text + "'," + txtCharges.Text + ",'" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"] + "',"+tax+","+tamt+","+discount+")");
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Saved";
                txtExpenseName.Text = "";
                txtDescription.Text = "";
                txtCharges.Text = "";
                txtRemark.Text = "";
                txttaxchrg.Text = "";
                txtdiscount.Text = "";
                ShowGridData();
            }
        }
        else
        {
            int a = 0;
            a = cs.DML("update ExpenseInfo set tamt="+tamt+", tax="+tax+", discount="+discount+", ExpenseName='" + txtExpenseName.Text + "',Description='" + txtDescription.Text + "',Charges='" + txtCharges.Text + "',Remark='" + txtRemark.Text + "' where id='" + lblid.Text + "'");
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Updated";
                txtExpenseName.Text = "";
                txtDescription.Text = "";
                txtCharges.Text = "";
                txtRemark.Text = "";
                txttaxchrg.Text = "";
                txtdiscount.Text = "";
                ShowGridData();
            }
        }
    }
}
