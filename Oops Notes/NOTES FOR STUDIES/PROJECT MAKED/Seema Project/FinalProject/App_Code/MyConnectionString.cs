using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for ConnectionString
/// </summary>
public class MyConnectionString
{
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
    public int DML(string sql)
    {
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.Text;
        cm.CommandText = sql;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        return a;    
    }
    public DataSet SelectOuery(string sql)
    {
        SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
        DataSet ds = new DataSet();
        da.Fill(ds,"a");
        return ds;
    }
    public DataTable MyDatatable(string Sql)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(Sql, cnn);
        da.Fill(dt);
        cnn.Close();
        return dt;

    }
    public void ConvertExcel(string sql, HttpResponse Response)
    {
        DataTable ds = new DataTable();
        ds = MyDatatable(sql);

        Response.Clear();
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        System.IO.StringWriter stringWrite = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
        System.Web.UI.WebControls.DataGrid dg = new System.Web.UI.WebControls.DataGrid();
        dg.DataSource = ds;
        int cnt = ds.Rows.Count;

        dg.HeaderStyle.Font.Bold = true;
        dg.HeaderStyle.Font.Size = 10;


        dg.DataBind();
        dg.RenderControl(htmlWrite);

        Response.Write(stringWrite.ToString().Trim());
        Response.End();
        ds.Dispose();
    }
    public MyConnectionString()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
