using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlybanhang.Classes
{
    class Funtions
    {
        // Nho khai bao thu vien Data va Data.SqlClient
        public static SqlConnection Conn; // Khai bao 1 doi tuong ket noi
        public static string connString; // Khai bao 1 chuoi ket noi
        
        public static void Ketnoi()
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                            E:\Lab\GitHub\CSharp-Programming\SQL\Quanlybanhang\Quanlybanhang\Database\Database1.mdf;
                            Integrated Security=True;Connect Timeout=30";
            Conn = new SqlConnection(); // Cap phat doi tuong
            Conn.ConnectionString = connString; // Chon duong dan
            Conn.Open(); // Mo ket noi
            //MessageBox.Show("Ket noi thanh cong", "Thong bao");
        }

        public static void NgatKetnoi()
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

        public static bool Checkkey(string SQL) // Viet truoc
        {
            SqlDataAdapter sda = new SqlDataAdapter(SQL, Conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            if (tbl.Rows.Count > 0)
                return true;
            else
                return false;
        }


        // Co the dung SqlDataAdapter
        public static void RunSQL(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = SQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        //Cach 2
        public static void RunSQL2(string SQL)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.DeleteCommand = new SqlCommand(SQL, Conn);
            try
            {
                sda.DeleteCommand.ExecuteNonQuery();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            catch(System.Exception del)
            {
                MessageBox.Show("Du lieu dang dung boi chuong" +
                    " trinh khac, khong the xoa" + " " + del.ToString());
            }
            cmd.Dispose();
            cmd = null;
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
    }
}
