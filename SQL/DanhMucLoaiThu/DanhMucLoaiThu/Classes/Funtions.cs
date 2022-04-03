using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DanhMucLoaiThu.Classes
{
    class Funtions
    {
        public static SqlConnection Conn;
        public static string connString;

        public static void Ketnoi()
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Lab\GitHub\CSharp-Programming\SQL\DanhMucLoaiThu\DanhMucLoaiThu\Database\DataThu.mdf;Integrated Security=True;Connect Timeout=30";
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

        public static DataTable GetDataToTable(string SQL)
        {
            SqlDataAdapter sda = new SqlDataAdapter(SQL, Conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            return tbl;
        }

        public static void FillCombo(string SQL, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter sda = new SqlDataAdapter(SQL, Conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            cbo.DataSource = tbl;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

        public static string GetFieldValues(string sql)
        {
            string value = "";
            SqlCommand sc = new SqlCommand(sql, Conn);
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
                value = sdr.GetValue(0).ToString();
            }
            sdr.Close();
            return value;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }

            cmd.Dispose();
            cmd = null;
        }

        public static void RunDelSQL(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = SQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception del)
            {
                MessageBox.Show("Du lieu dang dung boi chuong" +
                    " trinh khac, khong the xoa" + " " + del.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
