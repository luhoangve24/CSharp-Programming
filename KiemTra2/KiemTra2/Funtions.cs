using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KiemTra2
{
    class Funtions
    {
        public static SqlConnection Conn;
        public static string connString;

        public static void Ketnoi()
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Lab\GitHub\CSharp-Programming\KiemTra2\KiemTra2\Database\DatabaseDMHH.mdf;Integrated Security=True;Connect Timeout=30";
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

        /// <summary>
        /// Trả về True nếu mã xuất hiện trong bảng, và False nếu không có
        /// </summary>
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
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.ToString());
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

        /// <summary>
        /// Phương thức để dùng bảng khác cho ComboBox
        /// </summary>
        public static void FillCombo(string SQL, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter sda = new SqlDataAdapter(SQL, Conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            cbo.DataSource = tbl;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

        /// <summary>
        /// Dùng đối tượng SqlDataReader, có hai phương thức là 
        /// Read() - Dùng để kiểm tra dòng tiếp theo có tồn tại - true 
        /// và GetValue(Chỉ số) - Dùng để lấy cột muốn lấy dữ liệu
        /// </summary>     
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
    }
}

        private void Load_DG()
        {
            string sql;
            sql = "SELECT a.Masach, a.Tensach, a.NXB, a.Giasach, a.Soluong FROM tblSachTruyen a, tblNXB b WHERE a.MaNXB = b.MaNXB";
            tblDMT = Funtions.GetDataToTable(sql);
            data_Grid.DataSource = tblDMT;
            string[] Header = new string[5] { "Ma sach", "Ten sach", "NXB", "Gia sach", "So luong" };
            for (int i = 0; i < Header.Length; i++)
            {
                data_Grid.Columns[i].HeaderText = Header[i];
            }
            data_Grid.AllowUserToAddRows = false;
            data_Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }