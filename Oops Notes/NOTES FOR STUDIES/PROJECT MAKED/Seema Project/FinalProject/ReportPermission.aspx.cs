using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ReportPermission : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    MyConnectionString cs = new MyConnectionString();
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select Pagename,status from Reportsource where Loginname='" + DropDownList1.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = cs.MyDatatable(sql);
        string str = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            
              str= dt.Rows[i]["status"].ToString();
              
              if (str == "True")
              {
                  
                      CheckBoxList1.Items.Add(dt.Rows[i]["Pagename"].ToString());
                      CheckBoxList1.Items[i].Selected = true;
                  
              }
              else
              {
                  
                      CheckBoxList1.Items.Add(dt.Rows[i]["Pagename"].ToString());
                      CheckBoxList1.Items[i].Selected = false;
                
              }
        }
        
        
        
            
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                 sql = "update Reportsource set Status=1 where Pagename='" + CheckBoxList1.Items[i].ToString() + "' and Loginname='" + DropDownList1.SelectedItem.ToString() + "'";
                

            }
            else
            {
                 sql = "update Reportsource set Status=0 where Pagename='" + CheckBoxList1.Items[i].ToString() + "' and Loginname='" + DropDownList1.SelectedItem.ToString() + "'";
            }
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {

               lblmsg.Text = "Data is not Updated";

            }
            else
            {

               lblmsg.Text = "Data is Updated";

            }

        }
    }
}