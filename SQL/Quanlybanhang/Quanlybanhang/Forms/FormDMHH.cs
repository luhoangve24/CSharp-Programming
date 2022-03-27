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
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtSoluong.Enabled = false;
            txtDongiaban.Enabled = false;
            txtDongianhap.Enabled = false;
            txtMahang.Enabled = false;
            cboMaCL.SelectedIndex = -1;
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            Load_Datagrid();
            Classes.Funtions.FillCombo("Select Machatlieu, Tenchatlieu from tblChatlieu", cboMaCL, "Machatlieu", "Machatlieu");
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
            cboMaCL.Text = "";
            txtSoluong.Text = "0";
            txtDongiaban.Text = "0";
            txtDongianhap.Text = "0";
            picAnh.Image = null;
        }

        private void Load_Datagrid()
        {
            string SQL;
            SQL = "SELECT Mahang, Tenhang, Machatlieu, Soluong, " +
                "Dongianhap, Dongiaban FROM tblHang";
            tblDMMH = Classes.Funtions.GetDataToTable(SQL);
            dgridBang.DataSource = tblDMMH;

            string[] Header = new string[6] { "Ma hang", "Ten hang",
                    "Ma chat lieu", "So luong", "Don gia nhap", "Don gia ban", };

            for (int i = 0; i < Header.Length; i++)
            {
                dgridBang.Columns[i].HeaderText = Header[i];
            }

            
            dgridBang.AllowUserToAddRows = false;
            dgridBang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridBang_Click(object sender, EventArgs e)
        {
            if (tblDMMH.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (!btnThem.Enabled)
            {
                MessageBox.Show("Dang o che do them");
                txtMahang.Focus();
                return;
            }
            txtMahang.Text = dgridBang.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = dgridBang.CurrentRow.Cells["Tenhang"].Value.ToString();

            string ma = dgridBang.CurrentRow.Cells["Machatlieu"].Value.ToString();
            string sqlCbo;
            sqlCbo = "SELECT Machatlieu FROM tblChatlieu WHERE Machatlieu = N'"+ma+"'";
            cboMaCL.Text = Classes.Funtions.GetFieldValues(sqlCbo);

            txtSoluong.Text = dgridBang.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongianhap.Text = dgridBang.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDongiaban.Text = dgridBang.CurrentRow.Cells["Dongiaban"].Value.ToString();

            string sqlAnh;
            sqlAnh = "SELECT Anh FROM tblHang WHERE Mahang = N'" + txtMahang.Text + "'";
            txtAnh.Text = Classes.Funtions.GetFieldValues(sqlAnh);

            string sqlGhichu;
            sqlGhichu = "SELECT Ghichu FROM tblHang WHERE Mahang = N'" + txtMahang.Text + "'";
            txtGhichu.Text = Classes.Funtions.GetFieldValues(sqlGhichu);
            picAnh.Image = Image.FromFile(txtAnh.Text);

            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMahang.Enabled = true;
            txtMahang.Focus();
            ResetValue();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPG|*.jpg|PNG|*.png";
            dlgOpen.Title = "Chon anh";
            dlgOpen.FilterIndex = 1;
            dlgOpen.InitialDirectory = @"E:\Downloads\Anh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
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
            SQL = "Select Mahang from tblHang where Mahang=N'" + txtMahang.Text + "'";
            if (Classes.Funtions.Checkkey(SQL))
            {
                MessageBox.Show("Ma hang nay da ton tai!");
                txtMahang.Text = "";
                txtMahang.Focus();
                return;
            }

            // Tiep tuc dien insert
            // Lam them hoa don nhap hang
            SQL = "INSERT INTO tblHang(Mahang, Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, Ghichu)" +
                "values (N'" + txtMahang.Text.Trim() + "', N'" + txtTenhang.Text.Trim() + "', N'" + cboMaCL.Text.Trim() + "', " +
                "N'" + txtSoluong.Text.Trim() + "', N'" + txtDongianhap.Text.Trim() + "', N'" + txtDongiaban.Text.Trim() + "', N'" + txtAnh.Text.Trim() + "', N'" + txtGhichu.Text.Trim() + "')";
            Classes.Funtions.RunSQL(SQL);
            Load_Datagrid();
            ResetValue();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTimkiem.Enabled = true;
            btnHienthiDS.Enabled = true;
            txtMahang.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTimkiem.Enabled = true;
            btnHienthiDS.Enabled = true;
            txtMahang.Enabled = false;
            Load_Datagrid();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Chua co du lieu");
                return;
            }

            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua chon hang nao");
                return;
            }

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Ban muon xoa?");
            if (dr == DialogResult.OK)
            {
                string sql;
                sql = "DELETE FROM tblHang WHERE Mahang = N'" + txtMahang.Text + "'";
                Classes.Funtions.RunSQL2(sql);
                Load_Datagrid();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgridBang.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }

            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua chon hang nao");
                return;
            }

            foreach (Object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox item2 = item as TextBox;
                    if (item2.Text.Trim() == "")
                    {
                        MessageBox.Show("Ban chua nhap du du lieu!");
                        return;
                    }
                }
            }

            string SQL;
            SQL = "UPDATE tblHang SET Tenhang = N'" + txtTenhang.Text.Trim() + "', " +
                "Machatlieu = N'" + cboMaCL.Text + "', Anh = N'" + txtAnh.Text.Trim() + "', " +
                "Ghichu = N'" + txtGhichu.Text.Trim() + "' WHERE Mahang = N'"+txtMahang.Text+"'";
            Classes.Funtions.RunSQL(SQL);
            MessageBox.Show("Sua thanh cong");
            Load_Datagrid();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahang.Text == "") && (txtTenhang.Text == "")
                && (cboMaCL.Text == ""))
            {
                MessageBox.Show("Hay nhap mot dieu kien tim kiem");
                return;
            }

            sql = "SELECT * FROM tblHang WHERE 1=1";
            if (txtMahang.Text != "")
            {
                sql += " AND Mahang like N'%"+txtMahang.Text+"%'";
            }
            if (txtTenhang.Text != "")
            {
                sql += " AND Tenhang like N'%"+txtTenhang.Text+"%'";
            }
            if (cboMaCL.Text != "")
            {
                sql += " AND Machatlieu like N'%"+cboMaCL.Text+"%'";
            }

            tblDMMH = Classes.Funtions.GetDataToTable(sql);
            if (tblDMMH.Rows.Count == 0)
            {
                MessageBox.Show("Khong thoa man dieu kien");
            }
            else
            {
                MessageBox.Show("Co" + tblDMMH.Rows.Count +" ban ghi thoa man");
            }

            dgridBang.DataSource = tblDMMH;
            ResetValue();
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            Load_Datagrid();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
