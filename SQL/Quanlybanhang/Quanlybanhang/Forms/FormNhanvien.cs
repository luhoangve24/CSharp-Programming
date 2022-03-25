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
        }
    }
}
