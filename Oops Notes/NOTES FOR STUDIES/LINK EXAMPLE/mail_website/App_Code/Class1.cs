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
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=vikas\SQLEXPRESS");
    public int executequery(string sql)
    {
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        return a;
    }
    public DataSet selectquery(string sql)
    {
        SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "a");
        return ds;
    }

}
