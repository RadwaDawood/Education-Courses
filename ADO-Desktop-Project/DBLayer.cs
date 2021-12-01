using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ADO_Desktop_Project
{
    internal class DBLayer
    {
        public static DataTable Select (SqlCommand cmd)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ITIcon"].ConnectionString);
            cmd.Connection= con;
            DataTable dt=new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }
        public static int DML(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ITIcon"].ConnectionString);
            cmd.Connection = con;
            con.Open();
            int RowAffect=cmd.ExecuteNonQuery();
            con.Close();
            return RowAffect;
        }
    }
}
