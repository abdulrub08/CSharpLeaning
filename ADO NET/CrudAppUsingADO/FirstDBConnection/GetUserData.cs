using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FirstDBConnection
{
    public class GetUserData
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestApp"].ConnectionString);

        public void GetUsers()
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cnn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetUser";
            cnn.Open();
            SqlDataReader reader= cm.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt64(0) + "- " + reader.GetString(1));
            }
            cnn.Close();

        }
      

    }
}
