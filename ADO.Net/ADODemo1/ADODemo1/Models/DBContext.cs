using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADODemo1.Models
{
    public class DBContext
    {
        public string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private SqlConnection cnn = null;
        public DBContext()
        {
            cnn = new SqlConnection(cs);
        }
        public DBContext(string cs)
        {
            cnn = new SqlConnection(cs);
        }
        public void OpenConnection()
        {
            try
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ClosedConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

    }
}