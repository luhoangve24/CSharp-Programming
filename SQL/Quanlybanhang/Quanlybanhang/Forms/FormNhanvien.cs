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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        DataTable tblnhanvien;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtManhanvien.Enabled = false;
            Load_DataGrid();
        }

        private void Load_DataGrid()
        {
            string sql;
            sql = "SELECT * FROM tblNhanvien";
            tblnhanvien = Classes.Funtions.GetDataToTable(sql);
            dgridBang.DataSource = tblnhanvien;

            string[] Header = new string[6] {
                "Ma nhan vien", "Ten nhan vien", "Gioi tinh",
            "Dia chi", "Dien thoai", "Ngay sinh"};
            for (int i = 0; i < Header.Length; i++)
            {
                dgridBang.Columns[i].HeaderText = Header[i];
            }

            dgridBang.AllowUserToAddRows = false;
            dgridBang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridBang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang bat che do Them");
                txtManhanvien.Focus();
                return;
            }

            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Chua co du lieu");
                return;
            }

            txtManhanvien.Text = dgridBang.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennhanvien.Text = dgridBang.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (dgridBang.CurrentRow.Cells["Gioitinh"].Value.ToString()=="Nam")
            {
                chkNam.Checked = true;
            }
            else
            {
                chkNam.Checked = false;
            }
            txtDiachi.Text = dgridBang.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = dgridBang.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNgaysinh.Text = dgridBang.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtManhanvien.Enabled = true;
            txtTennhanvien.Focus();
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
        }

        private void ResetValues()
        {
            txtTennhanvien.Clear();
            txtDiachi.Clear();
            mskDienthoai.Clear();
            mskNgaysinh.Clear();
            txtManhanvien.Clear();
            chkNam.Checked = false;
        }

        private string GioiTinh(CheckBox chk)
        {
            if (chk.Checked)
            {
                return "Nam";
            }
            else
            {
                return "Nu";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Chua nhap ma nhan vien");
                txtManhanvien.Focus();
                return;
            }

            if (txtTennhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Chua nhap ten nhan vien");
                txtTennhanvien.Focus();
                return;
            }

            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Chua nhap dia chi");
                txtDiachi.Focus();
                return;
            }

            if (mskDienthoai.MaskCompleted == false)
            {
                MessageBox.Show("Chua nhap SDT");
                mskDienthoai.Focus();
                return;
            }

            if (mskNgaysinh.MaskCompleted == false)
            {
                MessageBox.Show("Chua nhap DOB");
                mskNgaysinh.Focus();
                return;
            }

            string sql;
            sql = "select Manhanvien from tblNhanvien where Manhanvien = N'"+txtManhanvien.Text+"'";
            if (Classes.Funtions.Checkkey(sql))
            {
                MessageBox.Show("Ma nhan vien bi trung lap");
                txtManhanvien.Clear();
                txtManhanvien.Focus();
                return;
            }

            if (!Classes.Funtions.isDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Ban phai nhap lai ngay sinh");
                mskNgaysinh.Clear();
                mskNgaysinh.Focus();
                return;
            }

            sql = "insert into tblNhanvien(Manhanvien, Tennhanvien, Gioitinh, Diachi, Dienthoai, Ngaysinh) " +
                "values(N'"+txtManhanvien.Text+"', N'"+txtTennhanvien.Text+ "', N'"+GioiTinh(chkNam)+ "', N'"+txtDiachi.Text+ "', N'"+mskDienthoai.Text+ "', N'"+Classes.Funtions.ConvertDateTime(mskNgaysinh.Text)+"')";

            Classes.Funtions.RunSQL(sql);
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtManhanvien.Enabled = false;
            Load_DataGrid();
            ResetValues();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtManhanvien.Enabled = false;
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Chua chon gi");
                dgridBang.Focus();
                return;
            }

            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ban muon xoa chu?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string sql;
                sql = "Delete from tblNhanvien where Manhanvien = N'" + txtManhanvien.Text + "'";
                Classes.Funtions.RunDelSQL(sql);
                Load_DataGrid();
                ResetValues();
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Chua co du lieu");
                return;
            }

            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Chua chon gi");
                dgridBang.Focus();
                return;
            }

            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Ban phai nhap ten nhan vien");
                txtTennhanvien.Focus();
                return;
            }

            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Ban phai nhap dia chi");
                txtDiachi.Focus();
                return;
            }

            if(mskDienthoai.MaskFull == false)
            {
                MessageBox.Show("Ban phai nhap SDT");
                mskDienthoai.Focus();
                return;
            }

            if (mskNgaysinh.MaskFull == false)
            {
                MessageBox.Show("Nhap day du ngay sinh");
                mskNgaysinh.Focus();
                return;
            }

            if (!Classes.Funtions.isDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Ban phai nhap lai ngay sinh");
                mskNgaysinh.Clear();
                return;
            }

            string sql;
            sql = "UPDATE tblNhanvien SET Tennhanvien = N'"+txtTennhanvien.Text+ "', Gioitinh = N'"+GioiTinh(chkNam)+ "', Diachi = N'"+txtDiachi.Text+ "', Dienthoai = N'"+mskDienthoai.Text+ "', Ngaysinh = N'"+Classes.Funtions.ConvertDateTime(mskNgaysinh.Text)+ "' where Manhanvien = N'"+txtManhanvien.Text+"'";
            Classes.Funtions.RunSQL(sql);
            ResetValues();
            Load_DataGrid();
        }


        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
