using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS ");

    
    public int ExecuteQuery(string sql)
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

    public DataSet SelectQuery(string sql)
    {
        SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "a");
        return ds;
    }
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}


	