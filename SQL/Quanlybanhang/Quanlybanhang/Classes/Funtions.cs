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
    }
}
