using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang.Classes;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Quanlybanhang.Forms
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyHD.Enabled = false;
            btnInHD.Enabled = false;
            txtMahoadon.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenkhachhang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtTenhang.ReadOnly = true;
            txtDongia.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";

            string sql;

            sql = "SELECT Manhanvien, Tennhanvien FROM tblNhanvien";
            Funtions.FillCombo(sql, cboManhanvien, "Manhanvien", "Manhanvien");
            cboManhanvien.SelectedIndex = -1;

            sql = "SELECT Makhach, Tenkhach FROM tblKhach";
            Funtions.FillCombo(sql, cboMakhach, "Makhach", "Makhach");
            cboMakhach.SelectedIndex = -1;

            sql = "SELECT Mahang, Tenhang FROM tblHang";
            Funtions.FillCombo(sql, cboMahang, "Mahang", "Mahang");
            cboMahang.SelectedIndex = -1;

            sql = "SELECT MaHDBan FROM tblChitietHDBan";
            Funtions.FillCombo(sql, cboMaHDBan, "MaHDBan", "MaHDBan");
            cboMaHDBan.SelectedIndex = -1;

            if (txtMahoadon.Text != "")
            {
                Load_DataGridHD();
                btnHuyHD.Enabled = true;
                btnInHD.Enabled = true;
            }

            Load_DataGridChitiet();
        }

        DataTable tblHoaDonBan;
        private void Load_DataGridChitiet()
        {
            string sql;
            sql = "SELECT a.Mahang, b.Tenhang, a.Dongia, a.Soluong, a.Giamgia, a.Thanhtien" +
                " FROM tblChitietHDBan a, tblHang b " +
                "WHERE a.Mahang = b.Mahang AND a.MaHDBan = N'"+txtMahoadon.Text+"'";
            tblHoaDonBan = Funtions.GetDataToTable(sql);
            dataGrid_Chitiet.DataSource = tblHoaDonBan;

            string[] Header = new string[6] {
            "Ma hang", "Ten hang", "So luong",
            "Don gia ban", "Giam gia", "Thanh tien"};
            for (int i = 0; i < Header.Length; i++)
            {
                dataGrid_Chitiet.Columns[i].HeaderText = Header[i];
            }

            dataGrid_Chitiet.AllowUserToAddRows = false;
            dataGrid_Chitiet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Load_DataGridHD()
        {
            string sql;

            sql = "SELECT Ngayban FROM tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
            txtNgayban.Text = Funtions.ConvertDateTime(Funtions.GetFieldValues(sql));

            sql = "SELECT Manhanvien FROM tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
            cboManhanvien.Text = Funtions.GetFieldValues(sql);

            sql = "SELECT Makhach FROM tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
            cboMakhach.Text = Funtions.GetFieldValues(sql);;
        
            sql = "SELECT Tongtien FROM tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
            txtTongtien.Text = Funtions.GetFieldValues(sql);

            lblBangchu.Text = "Bằng chữ: "; //Viet sau
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuyHD.Enabled = false;
            btnInHD.Enabled = false;
            ResetValues();
            txtMahoadon.Text = Funtions.CreateKey("HDB");
            Load_DataGridChitiet();
        }
        

        private void ResetValues()
        {
            txtMahoadon.Enabled = true;
            txtNgayban.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboMakhach.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = "";
            cboMahang.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM tblHDBan WHERE MaHDBan = N'" + txtMahoadon.Text + "'";
            if (!Funtions.Checkkey(sql))
            {
                // Ma hoa don chua co, tien hanh luu cac thong tin chung
                // Ma HDBan duoc sinh tu dong do do khong co truong hop duplicate

                if (txtNgayban.Text.Trim() == "")
                {
                    MessageBox.Show("Ban phai nhap ngay ban");
                    txtNgayban.Focus();
                    return;
                }

                if (cboManhanvien.Text == "")
                {
                    MessageBox.Show("Ban phai chon nhan vien");
                    return;
                }

                if (cboMakhach.Text == "")
                {
                    MessageBox.Show("Ban phai chon khach");
                    return;
                }

                // Luu thong tin chung vao tblHDBan

                sql = "INSERT INTO tblHDBan (MaHDBan, Ngayban, Manhanvien, Makhach, Tongtien) " +
                    "VALUES (N'"+txtMahoadon.Text.Trim()+ "', N'"+Funtions.ConvertDateTime(txtNgayban.Text.Trim())+"', " +
                    "N'"+cboManhanvien.Text+ "', N'"+cboMakhach.Text+ "', "+float.Parse(txtTongtien.Text)+")"; // ???
                Funtions.RunSQL(sql);
                MessageBox.Show(txtTongtien.Text);

                // Luu thong tin chi tiet mat hang

                if (cboMahang.Text == "")
                {
                    MessageBox.Show("Ban phai chon ma hang");
                    return;
                }

                if (txtSoluong.Text.Trim() == "" || txtSoluong.Text == "0")
                {
                    MessageBox.Show("Ban phai nhap so luong");
                    txtSoluong.Focus();
                    return;
                }

                if (txtGiamgia.Text.Trim() == "")
                {
                    MessageBox.Show("Ban phai nhap giam gia");
                    txtSoluong.Focus();
                    return;
                }

                sql = "SELECT Mahang FROM tblChitietHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"' " +
                    "AND Mahang = N'"+cboMahang.Text+"'";

                if (Funtions.Checkkey(sql))
                {
                    MessageBox.Show("Ma hang nay da co, nhap ma khac");
                    cboMahang.Focus();
                    ResetValuesHang();
                    return;
                }

                // Kiem tra so luong hang trong kho con du de cung cap khong ?
                sl = Convert.ToDouble(Funtions.GetFieldValues("SELECT Soluong FROM tblHang WHERE Mahang = N'" + cboMahang.Text + "'"));
                if (Convert.ToDouble(txtSoluong.Text) > sl)
                {
                    MessageBox.Show("So luong mat hang chi con" + sl);
                    txtSoluong.Text = "";
                    txtSoluong.Focus();
                    return;
                }

                sql = "INSERT INTO tblChitietHDBan(MaHDBan, Mahang, Soluong, Dongia, Giamgia, Thanhtien) " +
                    "VALUES(N'"+txtMahoadon.Text.Trim()+ "', N'"+cboMahang.Text+ "', N'"+float.Parse(txtSoluong.Text)+ "', N'"+float.Parse(txtDongia.Text)+ "', " +
                    "N'"+float.Parse(txtGiamgia.Text)+ "', N'"+float.Parse(txtThanhtien.Text)+"')";

                Funtions.RunSQL(sql);
                Load_DataGridChitiet();
                // Cap nhat lai so luong cua mat hang vao bang tblHang

                SLcon = sl - Convert.ToDouble(txtSoluong.Text);
                sql = "UPDATE tblHang SET Soluong = " + SLcon + " WHERE Mahang = N'"+cboMahang.Text+"'";
                Funtions.RunSQL(sql);

                // Cap nhat lai thong tin tong tien cho hoa don ban
                string tmp = Funtions.GetFieldValues("SELECT Tongtien FROM tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'");
                tong = Convert.ToDouble(tmp);
                Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
                sql = "UPDATE tblHDBan SET Tongtien = "+Tongmoi+" WHERE MaHDBan = N'"+txtMahoadon.Text+"'";

                Funtions.RunSQL(sql);
                txtTongtien.Text = Tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + Funtions.ChuyenSoSangChu(Tongmoi.ToString());
                ResetValuesHang();
                btnHuyHD.Enabled = true;
                btnThem.Enabled = true;
                btnInHD.Enabled = true;
            }
        }

        private void ResetValuesHang()
        {
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void dataGrid_Chitiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            Double Thanhtien;
            if (tblHoaDonBan.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (MessageBox.Show("Ban co muon xoa?") == DialogResult.OK)
            {
                // Xoa hang va cap nhat lai so luong hang
                mahang = dataGrid_Chitiet.CurrentRow.Cells["Mahang"].Value.ToString();
                DelHang(txtMahoadon.Text, mahang);

                // Cap nhat lai tong tien cho hoa don ban
                Thanhtien = Convert.ToDouble(dataGrid_Chitiet.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongTien(txtMahoadon.Text, Thanhtien);
                Load_DataGridChitiet();
            }
        }

        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitietHDBan WHERE MaHDBan = N'"+Mahoadon+"' AND Mahang = N'"+Mahang+"'";
            s = Convert.ToDouble(Funtions.GetFieldValues(sql));
            sql = "DELETE tblChitietHDBan WHERE MaHDBan = N'"+Mahoadon+"' AND Mahang = N'"+Mahang+"'";
            Funtions.RunDelSQL(sql);

            // Cap nhat lai so luong cho cac mat hang
            sql = "SELECT Soluong FROM tblHang WHERE Mahang = N'"+Mahang+"'";
            sl = Convert.ToDouble(Funtions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblHang SET Soluong = "+SLcon+" WHERE Mahang = N'"+Mahang+"'";
            Funtions.RunSQL(sql);
        }

        private void DelUpdateTongTien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHDBan WHERE MaHDBan = N'"+Mahoadon+"'";
            Tong = Convert.ToDouble(Funtions.GetFieldValues(sql));

            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHDBan SET Tongtien = "+Tongmoi+" WHERE MaHDBan = N'"+Mahoadon+"'";
            Funtions.RunSQL(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Funtions.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT Mahang FROM tblChitietHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, Funtions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                // Xoa danh sach cac mat hang cua hoa don
                for (i = 0; i < n; i++)
                {
                    DelHang(txtMahoadon.Text, Mahang[i]);
                }

                // Xoa hoa don
                sql = "DELETE tblHDBan WHERE MaHDBan = N'"+txtMahoadon.Text+"'";
                Funtions.RunDelSQL(sql);
                ResetValues();
                Load_DataGridChitiet();
                btnHuyHD.Enabled = false;
                btnInHD.Enabled = false;
            }
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";

            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            sql = "SELECT Tennhanvien FROM tblNhanvien WHERE Manhanvien = N'"+cboManhanvien.Text+"'";
            txtTennhanvien.Text = Funtions.GetFieldValues(sql);
        }

        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMakhach.Text == "")
            {
                txtTenkhachhang.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }

            sql = "SELECT Tenkhach FROM tblKhach WHERE Makhach = N'"+cboMakhach.Text+"'";
            txtTenkhachhang.Text = Funtions.GetFieldValues(sql);

            sql = "SELECT Diachi FROM tblKhach WHERE Makhach = N'" + cboMakhach.Text + "'";
            txtDiachi.Text = Funtions.GetFieldValues(sql);

            sql = "SELECT Dienthoai FROM tblKhach WHERE Makhach = N'" + cboMakhach.Text + "'";
            txtDienthoai.Text = Funtions.GetFieldValues(sql);
        }

        private void cboMahang_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMahang.Text == "")
            {
                txtTenhang.Text = "";
                txtDongia.Text = "";
            }

            sql = "SELECT Tenhang FROM tblHang WHERE Mahang = N'"+cboMahang.Text+"'";
            txtTenhang.Text = Funtions.GetFieldValues(sql);

            sql = "SELECT Dongiaban FROM tblHang WHERE Mahang = N'" + cboMahang.Text + "'";
            txtDongia.Text = Funtions.GetFieldValues(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDBan.Text == "")
            {
                MessageBox.Show("Ban phai chon mot hoa don de tim");
                return;
            }
            txtMahoadon.Text = cboMaHDBan.Text;
            Load_DataGridHD();
            Load_DataGridChitiet();
            btnHuyHD.Enabled = true;
            btnLuu.Enabled = true;
            btnInHD.Enabled = true;
            cboMaHDBan.SelectedIndex = -1;
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            // Tu dong cap nhat khi thay doi so luong, giam gia
            double tt, sl, dg, gg;

            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = double.Parse(txtSoluong.Text);

            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = double.Parse(txtGiamgia.Text) / 100;

            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = double.Parse(txtDongia.Text);

            tt = sl*dg - sl * dg * gg;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            // Tu dong cap nhat khi thay doi so luong, giam gia
            double tt, sl, dg, gg;

            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = double.Parse(txtSoluong.Text);

            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = double.Parse(txtGiamgia.Text) / 100;

            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = double.Parse(txtDongia.Text);

            tt = sl * dg - sl * dg * gg;
            txtThanhtien.Text = tt.ToString();
        }
    }
}
