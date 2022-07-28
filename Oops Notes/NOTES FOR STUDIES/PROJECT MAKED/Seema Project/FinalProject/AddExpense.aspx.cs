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

public partial class AddExpense : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Session["mode"].ToString() == "Update")
            {

                string sql = "select Charges,tax,tamt,discount from AddExpense where id=" + Session["id"].ToString() + "";
                DataSet ds = new DataSet();
                ds = cs.SelectOuery(sql);
                DataTable dt = ds.Tables["a"];
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                lblCharges.Text = dt.Rows[i]["charges"].ToString();
                txtcharges.Text = dt.Rows[i]["tax"].ToString();
                txtTotalamt.Text = dt.Rows[i]["tamt"].ToString();
                txtdiscount.Text = dt.Rows[i]["discount"].ToString(); 


                } 
            }
        }
        if (Page.IsPostBack == false)
        {
            string sql = "select RegNo from Registration where ActiveStatus=1";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach(DataColumn col in dt.Columns)
            {
                foreach(DataRow row in dt.Rows)
                {
                    ddlRegNo.Items.Add(row[0].ToString());
                }
                break;
            }
        }
        //ddlRegNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
        if (Page.IsPostBack == false)
        {
            string sql = "select ExpenseName from ExpenseInfo";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlExpenseName.Items.Add(row[0].ToString());
                    
                }
                break;
            }
        }
        //ddlExpenseName.Items.Insert(0, new ListItem("--Please Select--", "0"));
        
    }
    protected void ddlRegNo_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void ddlExpenseName_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        string sql = "select Charges,tax,tamt,discount from ExpenseInfo where ExpenseName='" + ddlExpenseName.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                lblCharges.Text = row[0].ToString();
                string tax=row[1].ToString();
                string tamt=row[2].ToString();
                string discount=row[3].ToString();
                double totalamt = double.Parse(tamt);
                totalamt = double.Parse(tamt) + totalamt;
                txtTotalamt.Text = totalamt.ToString();
                txtcharges.Text = tax;
                txtdiscount.Text = discount;
                txtTotalamt.Text = tamt;
                

                
            }
            break;
        }
        //ddlExpenseName.Items.Clear();
     }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sql = "";

        if (Session["mode"].ToString() == "Update")
        {
             sql = "update AddExpense set RegNo='" + ddlRegNo.SelectedItem.ToString() + "',ExpenseName='" + ddlExpenseName.SelectedItem.ToString() + "',Charges='" + lblCharges.Text + "',Description='" + txtDescription.Text + "' where id=" + Session["id"].ToString() + " ";
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
        else
        {
             sql = "insert into AddExpense(RegNo,ExpenseName,Charges,Description,EntryDate,EntryPerson)values('" + ddlRegNo.SelectedItem.ToString() + "','" + ddlExpenseName.SelectedItem.ToString() + "','" + lblCharges.Text + "','" + txtDescription.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
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
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sql = "select RegNo,ExpenseName,Charges,tax,tamt,discount from AddExpense where RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        //DataTable dt = ds.Tables["a"];
        double charge = 0;
        string actives = "";
        
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                
                actives = row[4].ToString();

                charge = double.Parse(actives) + charge;

                txtTotalamt.Text = charge.ToString();
                lblCharges.Text = charge.ToString();

            }
            break;
        }
               
            
        
    }
    protected void btnCFUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateAddExpense.aspx");
    }
}
