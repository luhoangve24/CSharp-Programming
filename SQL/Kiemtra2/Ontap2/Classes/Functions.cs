using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ontap2.Functions
{
    class Functions
    {
        public static SqlConnection Conn;
        public static string connString;

        public static void KetNoi()
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Lab\GitHub\CSharp-Programming\SQL\Ontap\Ktra1\Database\HangHoa.mdf;Integrated Security=True;Connect Timeout=30";
            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }

        public static void NgatKetNoi()
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
