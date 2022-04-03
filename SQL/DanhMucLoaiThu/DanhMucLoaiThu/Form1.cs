using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanhMucLoaiThu.Classes;

namespace DanhMucLoaiThu
{
    public partial class Form1 : Form
    {
        DataTable tblThu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funtions.Ketnoi();
            txtMathu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DG();
            string sql;
            sql = "SELECT * FROM tblLoai";
            Funtions.FillCombo(sql, cboMaloai, "Maloai", "Tenloai");
            cboMaloai.SelectedIndex = -1;
            Reset_Values();

        }

        private void Load_DG()
        {
            string SQL;
            SQL = "SELECT Mathu, Tenthu, Maloai, Soluong, Tuoitho, Gioitinh FROM tblThu";
            tblThu = Funtions.GetDataToTable(SQL);
            data_grid.DataSource = tblThu;
            string[] Header = new string[6] { "Ma thu", "Ten thu", "Ma loai", "So luong", "Tuoi tho", "Gioi tinh" };
            for (int i = 0; i < Header.Length; i++)
            {
                data_grid.Columns[i].HeaderText = Header[i];
            }
            data_grid.AllowUserToAddRows = false;
            data_grid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Reset_Values()
        {
            txtMathu.Clear();
            txtTenthu.Clear();
            cboMaloai.Text = "";
            txtSoluong.Clear();
            txtTuoitho.Clear();
            txtGioitinh.Clear();
        }

        private void data_grid_Click(object sender, EventArgs e)
        {
            if (data_grid.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtMathu.Enabled)
            {
                MessageBox.Show("Dang o che do Them moi!");
                return;
            }

            txtMathu.Text = data_grid.CurrentRow.Cells["Mathu"].Value.ToString();
            txtTenthu.Text = data_grid.CurrentRow.Cells["Tenthu"].Value.ToString();
            string maloai, tenloai, sql;
            maloai = data_grid.CurrentRow.Cells["Maloai"].Value.ToString();
            sql = "SELECT Tenloai FROM tblLoai WHERE Maloai = N'"+maloai+"'";
            tenloai = Funtions.GetFieldValues(sql);
            cboMaloai.Text = tenloai;
            txtSoluong.Text = data_grid.CurrentRow.Cells["Soluong"].Value.ToString();
            txtTuoitho.Text = data_grid.CurrentRow.Cells["Tuoitho"].Value.ToString();
            txtGioitinh.Text = data_grid.CurrentRow.Cells["Gioitinh"].Value.ToString();
            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMathu.Enabled = true;
            txtMathu.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            Reset_Values();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            txtMathu.Enabled = false;
            Reset_Values();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Ban co muon thoat ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMathu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ma thu");
                txtMathu.Focus();
                return;
            }

            if (txtTenthu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ten thu");
                txtTenthu.Focus();
                return;
            }

            if (cboMaloai.Text == "")
            {
                MessageBox.Show("Chua chon ma loai");
                cboMaloai.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap so luong");
                txtSoluong.Focus();
                return;
            }

            if (txtTuoitho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap tuoi tho");
                txtTuoitho.Focus();
                return;
            }

            string sql;
            sql = "SELECT Mathu FROM tblThu WHERE Mathu = N'"+txtMathu.Text+"'";
            if (Funtions.CheckKey(sql))
            {
                MessageBox.Show("Ma thu da co trong Database, nhap lai");
                txtMathu.Clear();
                txtMathu.Focus();
                return;
            }

            string maloai;
            sql = "SELECT Maloai FROM tblLoai WHERE Tenloai = N'"+cboMaloai.Text+"'";
            maloai = Funtions.GetFieldValues(sql);

            sql = "INSERT INTO tblThu(Mathu, Tenthu, Maloai, Soluong, Gioitinh, Tuoitho) VALUES (N'" + txtMathu.Text + "', N'" + txtTenthu.Text + "', N'" + maloai + "', " + txtSoluong.Text + ", N'" + txtGioitinh.Text + "', " + txtTuoitho.Text + ")";
            Funtions.RunSQL(sql);
            Load_DG();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMathu.Enabled = false;
            Reset_Values();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (data_grid.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtMathu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua chon ban ghi nao");
                txtMathu.Focus();
                return;
            }

            if (txtTenthu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ten thu");
                txtTenthu.Focus();
                return;
            }

            if (cboMaloai.Text == "")
            {
                MessageBox.Show("Chua chon ma loai");
                cboMaloai.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap so luong");
                txtSoluong.Focus();
                return;
            }

            if (txtTuoitho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap tuoi tho");
                txtTuoitho.Focus();
                return;
            }


            string sql;

            string maloai;
            sql = "SELECT Maloai FROM tblLoai WHERE Tenloai = N'" + cboMaloai.Text + "'";
            maloai = Funtions.GetFieldValues(sql);

            sql = "UPDATE tblThu SET Tenthu = N'"+txtTenthu.Text+"', Maloai = N'"+maloai+"', Soluong = "+txtSoluong.Text+", Gioitinh = N'"+txtGioitinh.Text+"', Tuoitho = "+txtTuoitho.Text+"";
            Funtions.RunSQL(sql);
            Load_DG();
            Reset_Values();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (data_grid.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtMathu.Text == "")
            {
                MessageBox.Show("Chua chon ban ghi nao");
                return;
            }

            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Ban co muon xoa?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                string sql;
                sql = "DELETE tblThu WHERE Mathu = N'"+txtMathu.Text+"'";
                Funtions.RunDelSQL(sql);
                Load_DG();
                Reset_Values();
            }
        }

    }
}
