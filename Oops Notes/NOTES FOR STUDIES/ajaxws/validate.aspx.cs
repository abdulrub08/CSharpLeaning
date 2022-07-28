using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class validate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page_load ( validate.aspx )
        Response.Expires = -1;
        string usr = Request.QueryString["usr"];
        string sql = "select count(*) from wsajaxusers where usr='" + usr + "'";
        OleDbConnection cn = new OleDbConnection("provider=oraoledb.oracle;user id=scott;password=tiger");
        OleDbCommand cmd = new OleDbCommand(sql, cn);
        cn.Open();
        int cnt = int.Parse(cmd.ExecuteScalar().ToString());
        cn.Close();
        Response.ContentType = "text/XML";
        if (cnt > 0)
            Response.Write("<Result>Unavailable </Result>");
        else
            Response.Write("<Result>Available </Result>");
        Response.End();













    }
}
