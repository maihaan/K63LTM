using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QLSinhVien.DataAccess
{
    public class DataAccess
    {
        String connection = Properties.Settings.Default.Connection;

        public DataTable Doc(String query)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;
            }
            catch(Exception e)
            {
                Log(e.ToString());
                return null;
            }
        }

        public int Ghi(String query)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                return count;
            }
            catch(Exception e)
            {
                Log(e.ToString());
                return -2;
            }
        }

        private void Log(String value)
        {
            using(StreamWriter s = new StreamWriter("Log.txt", true))
            {
                s.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ": " + value);
            }
        }
    }
}
