using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrsim_Login.Connect
{
    public class Data
    {
        public static int executeQuery(string query)
        {
            // Initialization.  
            int rowCount = 0;

            string strConn = "Data Source=(LocalDb)\\LocalDB;Initial Catalog=QLNhanVien;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                // Settings.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600; //// Setting timeeout for longer queries to 12 hours.  

                // Open.  
                sqlConnection.Open();

                // Result.  
                rowCount = sqlCommand.ExecuteNonQuery();

                // Close.  
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Close.  
                sqlConnection.Close();

                throw ex;
            }

            return rowCount;
        }
    }
}
