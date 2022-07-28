<%@ WebHandler Language="C#" Class="Handler2" %>

using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

public class Handler2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        // Create SQL Command 

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select Image2 from Images where ID =@IID";
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Connection = con;

        SqlParameter ImageID = new SqlParameter("@IID", System.Data.SqlDbType.Int);
        ImageID.Value = Convert.ToInt32(context.Request.QueryString["ID"]);
        cmd.Parameters.Add(ImageID);
        con.Open();
        SqlDataReader dReader = cmd.ExecuteReader();
        dReader.Read();
        context.Response.BinaryWrite((byte[])dReader["Image2"]);
        dReader.Close();
        con.Close();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}