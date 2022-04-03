using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _49_LeHoangVu_23A4040156.Classes;

namespace _49_LeHoangVu_23A4040156
{
    public partial class frmDMT : Form
    {
        DataTable tblDMT;
        public frmDMT()
        {
            InitializeComponent();
        }

        private void frmDMT_Load(object sender, EventArgs e)
        {
            Funtions.Ketnoi();
            txtMasach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DG();
            string sql;
            sql = "SELECT MaNXB, TenNXB FROM tblNXB";
            Funtions.FillCombo(sql, cboNXB, "MaNXB", "TenNXB");
            cboNXB.SelectedIndex = -1;
            Reset_Values();
        }

        private void Load_DG()
        {
            string sql;
            sql = "SELECT a.Masach, a.Tensach, a.MaNXB, a.Giasach, a.Soluong, b.TenNXB, b.Diachi FROM tblSachTruyen a, tblNXB b WHERE a.MaNXB = b.MaNXB";
            tblDMT = Funtions.GetDataToTable(sql);
            data_Grid.DataSource = tblDMT;
            string[] Header = new string[7] { "Ma sach", "Ten sach", "NXB", "Gia sach", "So luong", "Ten NXB", "Dia chi" };
            for (int i = 0; i < Header.Length; i++)
            {
                data_Grid.Columns[i].HeaderText = Header[i];
            }
            data_Grid.AllowUserToAddRows = false;
            data_Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Reset_Values()
        {
            txtMasach.Clear();
            txtTensach.Clear();
            cboNXB.Text = "";
            txtSoluong.Clear();
            txtGiasach.Clear();
            txtMasach.Enabled = false;
        }

        private void data_Grid_Click(object sender, EventArgs e)
        {
            if (tblDMT.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang o che do Them moi");
                return;
            }

            txtMasach.Text = data_Grid.CurrentRow.Cells["Masach"].Value.ToString();
            txtTensach.Text = data_Grid.CurrentRow.Cells["Tensach"].Value.ToString();
            string ma, ten, sql;
            ma = data_Grid.CurrentRow.Cells["MaNXB"].Value.ToString();
            sql = "SELECT TenNXB FROM tblNXB WHERE MaNXB = N'"+ma+"'";
            ten = Funtions.GetFieldValues(sql);
            cboNXB.Text = ten;
            txtSoluong.Text = data_Grid.CurrentRow.Cells["Soluong"].Value.ToString();
            txtGiasach.Text = data_Grid.CurrentRow.Cells["Giasach"].Value.ToString();
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            Reset_Values();
            txtMasach.Enabled = true;
            txtMasach.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Reset_Values();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMasach.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Ban muon thoat a?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ma sach");
                txtMasach.Focus();
                return;
            }

            if (txtTensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ten sach");
                txtTensach.Focus();
                return;
            }

            if (cboNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua chon NXB sach");
                cboNXB.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap so luong");
                txtSoluong.Focus();
                return;
            }

            if (txtGiasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap gia sach");
                txtGiasach.Focus();
                return;
            }

            string sql;
            sql = "SELECT Masach FROM tblSachTruyen WHERE Masach = N'"+txtMasach.Text+"'";
            if (Funtions.Checkkey(sql))
            {
                MessageBox.Show("Ma sach nay da ton tai, vui long nhap ma sach khac");
                txtMasach.Clear();
                txtMasach.Focus();
                return;
            }

            string ma;
            sql = "SELECT MaNXB FROM tblNXB WHERE TenNXB = N'"+cboNXB.Text+"'";
            ma = Funtions.GetFieldValues(sql);
            sql = "INSERT INTO tblSachTruyen(Masach, Tensach, MaNXB, Giasach, Soluong) VALUES(N'"+txtMasach.Text.Trim()+ "', N'"+txtTensach.Text.Trim()+ "', N'"+ma.Trim()+"', "+txtGiasach.Text.Trim()+", "+txtSoluong.Text.Trim()+")";
            Funtions.RunSQL(sql);
            Load_DG();
            Reset_Values();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMasach.Enabled = false;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtGiasach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8 || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
