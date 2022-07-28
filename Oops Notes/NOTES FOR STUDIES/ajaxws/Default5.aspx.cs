using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
//Timer1_Tick
        OleDbConnection cn = new OleDbConnection("provider=oraoledb.oracle;user id=scott;password=tiger");
        OleDbDataAdapter da = new OleDbDataAdapter("select msg from workshowsnews", cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "flashnews");
        lblNews.Text = "Flash News : " + ds.Tables[0].Rows[0][0].ToString();










    }
}
