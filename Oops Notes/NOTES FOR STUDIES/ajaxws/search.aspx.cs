using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page_Load ( search.aspx )
        Response.Expires = -1;
        string ename = Request.QueryString["ename"];
        string sql = string.Empty;
        if (ename == null)
            sql = "select * from emp";
        else
            sql = "select * from emp where ename like '" + ename + "%'";
        OleDbConnection cn = new OleDbConnection("provider=oraoledb.oracle;user id=scott;password=tiger");
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataSet ds = new DataSet();
        da.Fill( ds,"emp");
        Response.Write("<table width=100% align=center bgColor=seashell border=1 bordercolor=red>");
        Response.Write("<tr bgColor=gold>");
        for (int c = 0; c < ds.Tables[0].Columns.Count; c++)
            Response.Write("<th>" + ds.Tables[0].Columns[c].ColumnName + "</th>");
        Response.Write("</tr>");
        for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
        {
            Response.Write("<tr>");
            for (int c = 0; c < ds.Tables[0].Columns.Count; c++)
            {
                Response.Write("<td>" + ds.Tables[0].Rows[r][c].ToString() + " &nbsp; </td>");
            }
            Response.Write("</tr>");
        }
        Response.Write("</table>");
        Response.End();





















    }
}
