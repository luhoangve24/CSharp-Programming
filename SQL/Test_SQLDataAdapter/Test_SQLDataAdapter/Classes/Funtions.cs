using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test_SQLDataAdapter
{
    class Funtions
    {
        public static SqlConnection Conn;
        public static string connString;

        public static void Ketnoi()
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Lab\GitHub\CSharp-Programming\SQL\Test_SQLDataAdapter\Test_SQLDataAdapter\Database\DatabaseSQLDA.mdf;Integrated Security=True";
            Conn = new SqlConnection(connString);
            Conn.Open();
        }

        public static void Ngatketnoi()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static void RunDel(string sql, DataTable tbl)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.Update(tbl);
            
        }
    }
}
