using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra2
{
    public partial class frmDMHH : Form
    {
        DataTable tblHH;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMahang.Enabled = false;
            Funtions.Ketnoi();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            string sql;
            sql = "SELECT Mamau, Tenmau FROM tblMausac";
            Load_DataGrid();
            Funtions.FillCombo(sql, cboMamau, "Mamau", "Tenmau");
            cboMamau.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txtMahang.Clear();
            txtTenhang.Clear();
            cboMamau.Text = "";
            txtSoluong.Clear();
            txtTGBH.Clear();
            txtAnh.Clear();
            picAnh.Image = null;
        }

        private void Load_DataGrid()
        {
            string sql;
            sql = "SELECT Mahang, Tenhang, Mamau, Soluong, TGBH FROM tblHanghoa";
            tblHH = Funtions.GetDataToTable(sql);
            data_Grid.DataSource = tblHH;
            string[] Header = new string[5] { "Ma hang", "Ten hang", "Ma mau", "So luong", "Thoi gian bao hanh" };
            for (int i = 0; i < Header.Length; i++)
            {
                data_Grid.Columns[i].HeaderText = Header[i];
            }
            data_Grid.AllowUserToAddRows = false;
            data_Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void data_Grid_Click(object sender, EventArgs e)
        {
            if (data_Grid.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi");
                return;
            }

            txtMahang.Text = data_Grid.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = data_Grid.CurrentRow.Cells["Tenhang"].Value.ToString();
            string mamau;
            mamau = data_Grid.CurrentRow.Cells["Mamau"].Value.ToString();
            string sql;
            sql = "SELECT Tenmau FROM tblMausac WHERE Mamau = N'"+mamau+"'";
            cboMamau.Text = Funtions.GetFieldValues(sql);
            txtSoluong.Text = data_Grid.CurrentRow.Cells["Soluong"].Value.ToString();
            txtTGBH.Text = data_Grid.CurrentRow.Cells["TGBH"].Value.ToString();
            sql = "SELECT Anh FROM tblHanghoa WHERE Mahang = N'"+txtMahang.Text+"'";
            txtAnh.Text = Funtions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMahang.Enabled = true;
            txtMahang.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMahang.Enabled = false;
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Ban co muon thoat?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ma hang");
                txtMahang.Focus();
                return;
            }

            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ten hang");
                txtTenhang.Focus();
                return;
            }

            if (cboMamau.Text == "")
            {
                MessageBox.Show("Chua chon ma mau");
                cboMamau.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap so luong");
                txtSoluong.Focus();
                return;
            }

            if (txtTGBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap TGBH");
                txtTGBH.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua chon Anh");
                txtAnh.Focus();
                return;
            }

            sql = "SELECT Mahang FROM tblHanghoa WHERE Mahang = N'"+txtMahang.Text.Trim()+"'";
            if (Funtions.Checkkey(sql))
            {
                MessageBox.Show("Ma hang nay da ton tai, nhap lai");
                txtMahang.Clear();
                txtMahang.Focus();
                return;
            }

            string mamau;
            sql = "SELECT Mamau FROM tblMausac WHERE Tenmau = N'"+cboMamau.Text+"'";
            mamau = Funtions.GetFieldValues(sql);
            sql = "INSERT INTO tblHanghoa VALUES(N'" + txtMahang.Text + "', N'" + txtTenhang.Text + "', N'" + mamau + "', N'" + txtAnh.Text + "'," + txtSoluong.Text + ", " + txtTGBH.Text + ")";
            Funtions.RunSQL(sql);
            Load_DataGrid();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMahang.Enabled = false;
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (data_Grid.Rows.Count == 0)
            {
                MessageBox.Show("Chua co du lieu");
                return;
            }

            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua chon hang nao");
                return;
            }

            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ten hang");
                txtTenhang.Focus();
                return;
            }

            if (cboMamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua chon ma mau");
                cboMamau.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap so luong");
                txtSoluong.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua chon anh nao");
                btnOpen.Focus();
                return;
            }


            string mamau;
            sql = "SELECT Mamau FROM tblMausac WHERE Tenmau = N'" + cboMamau.Text + "'";
            mamau = Funtions.GetFieldValues(sql);
            if (txtSoluong.Text.Contains(',') || txtTGBH.Text.Contains(','))
            {
                txtSoluong.Text = txtSoluong.Text.Replace(',', '.');
                txtTGBH.Text = txtTGBH.Text.Replace(',', '.');
            }
            sql = "UPDATE tblHanghoa SET Tenhang = N'"+txtTenhang.Text+ "', Mamau = N'"+mamau+ "', Soluong = "+txtSoluong.Text+", TGBH = "+txtTGBH.Text+", Anh = N'"+txtAnh.Text+ "' WHERE Mahang = N'"+txtMahang.Text+"'";
            Funtions.RunSQL(sql);
            Load_DataGrid();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (data_Grid.Rows.Count == 0)
            {
                MessageBox.Show("Chua co du lieu");
                return;
            }

            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua chon ban ghi nao");
                return;
            }

            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Ban co muon xoa?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                sql = "DELETE tblHanghoa WHERE Mahang = N'" + txtMahang.Text + "'";
                Funtions.RunDelSQL(sql);
                Load_DataGrid();
                ResetValues();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png";
            ofd.Title = "Chon hinh anh";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = ofd.FileName;
                picAnh.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTGBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8)
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
