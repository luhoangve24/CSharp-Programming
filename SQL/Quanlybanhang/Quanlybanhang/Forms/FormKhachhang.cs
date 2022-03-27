using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.Forms
{
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        DataTable tblkhachhang;

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMakhach.Enabled = false;
            Load_DataGrid();
        }

        private void Load_DataGrid()
        {
            string sql = "SELECT * FROM tblKhach";
            tblkhachhang = Classes.Funtions.GetDataToTable(sql);
            dgridBang.DataSource = tblkhachhang;
            string[] Header = new string[4] {"Ma khach", "Ten khach",
                                                "Dia chi", "Dien thoai"};
            for (int i = 0; i < Header.Length; i++)
            {
                dgridBang.Columns[i].HeaderText = Header[i];
            }

            dgridBang.AllowUserToAddRows = false;
            dgridBang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridBang_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang trong che do chinh sua");
                return;
            }

            txtMakhach.Text = dgridBang.CurrentRow.Cells["Makhach"].Value.ToString();
            txtTenkhach.Text = dgridBang.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtDiachi.Text = dgridBang.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = dgridBang.CurrentRow.Cells["Dienthoai"].Value.ToString();

            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMakhach.Enabled = true;
            ResetValues();
        }

        private void ResetValues()
        {
            txtMakhach.Clear();
            txtTenkhach.Clear();
            txtDiachi.Clear();
            mskDienthoai.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Chua nhap ma khach");
                txtMakhach.Focus();
                return;
            }

            if (txtTenkhach.Text == "")
            {
                MessageBox.Show("Chua nhap ten khach");
                txtTenkhach.Focus();
                return;
            }

            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Chua nhap dia chi");
                txtDiachi.Focus();
                return;
            }

            if (!mskDienthoai.MaskFull)
            {
                MessageBox.Show("Chua nhap du SDT");
                mskDienthoai.Focus();
                return;
            }

            string sql;
            sql = "SELECT Makhach FROM tblKhach where Makhach = N'"+txtMakhach.Text+"'";
            if (Classes.Funtions.Checkkey(sql))
            {
                MessageBox.Show("Bi trung lap khoa");
                txtMakhach.Clear();
                txtMakhach.Focus();
                return;
            }

            sql = "INSERT INTO tblKhach(Makhach, Tenkhach, Diachi, Dienthoai)" +
                "values (N'" + txtMakhach.Text + "', N'" + txtTenkhach.Text + "', N'" + txtDiachi.Text + "', N'" + mskDienthoai.Text + "')";
            Classes.Funtions.RunSQL(sql);
            Load_DataGrid();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            ResetValues();
            txtMakhach.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Chua chon hang nao");
                return;
            }


            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ban muon xoa chu");
            if (dr == DialogResult.OK)
            {
                string sql;
                sql = "DELETE FROM tblKhach WHERE Makhach = N'" + txtMakhach.Text + "'";

                Classes.Funtions.RunSQL2(sql);
                Load_DataGrid();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtTenkhach.Text == "")
            {
                MessageBox.Show("Chua nhap ten khach");
                txtTenkhach.Focus();
                return;
            }

            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Chua nhap dia chi");
                txtDiachi.Focus();
                return;
            }

            if(!mskDienthoai.MaskFull)
            {
                MessageBox.Show("Chua nhap dung SDT");
                mskDienthoai.Focus();
                return;
            }

            string sql;
            sql = "UPDATE tblKhach SET Tenkhach = N'"+txtTenkhach.Text+"', " +
                "Diachi = N'"+txtDiachi.Text+ "', Dienthoai = N'"+mskDienthoai.Text+"'" +
                "WHERE Makhach = N'"+txtMakhach.Text+"'";
            Classes.Funtions.RunSQL(sql);
            btnBoqua.Enabled = false;
            ResetValues();
            Load_DataGrid();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
