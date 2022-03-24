using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Quanlybanhang.Forms
{
    public partial class frmDMHH : Form
    {
        DataTable tblDMMH;
        public frmDMHH()
        {
            InitializeComponent();
            Load_Datagrid();
        }

        private void Load_Datagrid()
        {
            string SQL;
            SQL = "Select * from tblHang";
            tblDMMH = Classes.Funtions.GetDataToTable(SQL);
            dgridBang.DataSource = tblDMMH;

            dgridBang.AllowUserToAddRows = false;
            dgridBang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridBang_Click(object sender, EventArgs e)
        {
            txtMahang.Text = dgridBang.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = dgridBang.CurrentRow.Cells["Tenhang"].Value.ToString();
            txtSoluong.Text = dgridBang.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongianhap.Text = dgridBang.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDongiaban.Text = dgridBang.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtAnh.Text = dgridBang.CurrentRow.Cells["Anh"].Value.ToString();
            txtGhichu.Text = dgridBang.CurrentRow.Cells["Ghichu"].Value.ToString();

            picAnh.Image = Image.FromFile(txtAnh.Text);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPG|*.jpg|PNG|*.png";
            dlgOpen.Title = "Chon anh";
            dlgOpen.FilterIndex = 1;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            BtnDong.Enabled = true;
            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnHienthiDS.Enabled = false;
            btnOpen.Enabled = false;
            txtMahang.Enabled = true;
            ResetValue();
        }

        private void ResetValue()
        {
            foreach (object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox itemTB = (TextBox)item;
                    if (itemTB.Text != "")
                    {
                        itemTB.Text = "";
                    }
                }
            }
            txtSoluong.Text = "0";
            txtDongiaban.Text = "0";
            txtDongianhap.Text = "0";
            picAnh.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox itemTB = (TextBox)item;
                    if (itemTB.Text == "" && itemTB.Name != "txtGhichu")
                    {
                        MessageBox.Show("Ban chua dien day du thong tin!");
                        return;
                    }
                }
            }

            string SQL;
            SQL = "Select Mahang from tblHang where Mahang=N'" + txtMahang.Text+ "'";
            if (Classes.Funtions.Checkkey(SQL) == true)
            {
                MessageBox.Show("Ma hang nay da ton tai!");
                txtMahang.Text = "";
                txtMahang.Focus();
                return;
            }
            
            // Tiep tuc dien insert
            // Lam them hoa don nhap hang
            SQL = "Insert into tblHang(Mahang, Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, Ghichu)" +
                "values (N'"+txtMahang.Text+"', N'"+txtTenhang.Text+"', N'"+txtSoluong.Text+"')";
        }

        private void frmDMHH_Load(object sender, EventArgs e)  
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Classes.Funtions.FillCombo("Select Machatlieu, Tenchatlieu from tblChatlieu", cboMaCL, "Machatlieu", "Machatlieu");
            txtSoluong.Enabled = false;
            txtDongiaban.Enabled = false;
            txtDongianhap.Enabled = false;
            cboMaCL.SelectedIndex = -1;
        }
    }
}
