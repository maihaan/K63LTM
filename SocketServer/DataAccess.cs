using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace SocketServer
{
    public class DataAccess
    {
        String connectionString = "Data Source=.\\MSSQL; "
            + "Initial Catalog=LTMK63DB; "
            + "User ID=LTMK63;"
            + "Password=LTMK63@123456;";

        public DataTable Read(String query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader, LoadOption.OverwriteChanges);
                connection.Close();
                return tb;
            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return null;
            }
        }

        public int Write(String query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                connection.Close();
                return count;
            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return -2;
            }
        }
    }
}
