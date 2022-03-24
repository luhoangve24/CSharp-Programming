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
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
            lbl1.Parent = pictureBox1;
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_Datagrid();
        }

        DataTable tblchatlieu;

        private void Load_Datagrid() // Viet truoc
        {
            string SQL;
            SQL = "Select Machatlieu, Tenchatlieu from dbo.tblChatlieu";
            tblchatlieu = Classes.Funtions.GetDataToTable(SQL);
            dgridBang.DataSource = tblchatlieu;

            dgridBang.Columns[0].HeaderText = "Mã chất liệu";
            dgridBang.Columns[1].HeaderText = "Tên chất liệu";
            dgridBang.AllowUserToAddRows = false;
            dgridBang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMachatlieu.Enabled = true;
            txtMachatlieu.Focus();
            btnThem.Enabled = false;
            ResetValue();
        }

        private void ResetValue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }

        private void dgridBang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachatlieu.Focus();
                return;
            }

            if (tblchatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMachatlieu.Text = dgridBang.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtTenchatlieu.Text = dgridBang.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMachatlieu.Text == "" || txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu");
                return;
            }

            string SQL = "Select Machatlieu From tblChatlieu where Machatlieu=N'"+ txtMachatlieu.Text.Trim()+ "'";
            if (Classes.Funtions.Checkkey(SQL) == true)
            {
                MessageBox.Show("Ma chat lieu nay da ton tai!");
                txtMachatlieu.Text = "";
                txtMachatlieu.Focus();
                return;
            }

            SQL = "Insert into tblChatlieu(Machatlieu, Tenchatlieu) values (N'"+txtMachatlieu.Text.Trim()+"', N'" + txtTenchatlieu.Text.Trim()+"')";
            Classes.Funtions.RunSQL(SQL);
            Load_Datagrid();

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            ResetValue();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblchatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu de sua");
                return;
            }

            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi nao");
                return;
            }

            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Ban chua nhap ten chat lieu");
                txtTenchatlieu.Focus();
                return;
            }

            string SQL;
            SQL = "Update tblChatlieu set Tenchatlieu=N'"+txtTenchatlieu.Text+"' where Machatlieu=N'"+txtMachatlieu.Text+"'";
            Classes.Funtions.RunSQL(SQL);
            Load_Datagrid();
            ResetValue();
            btnSua.Enabled = false;
        }
    }
}
