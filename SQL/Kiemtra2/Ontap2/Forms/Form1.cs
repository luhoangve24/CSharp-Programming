using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ontap2.Functions;

namespace Ontap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        DataTable tblDMHH;
        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Functions.KetNoi();
            Load_Grid();
            txtMahang.Enabled = false;
            string sql;
            sql = "SELECT Mamau, Tenmau FROM tblMausac";
            Functions.Functions.FillCombo(sql, cboMamau, "Mamau", "Mamau");
        }

        private void Load_Grid()
        {
            string sql;
            sql = "SELECT a.Mahang, a.Tenhang, a.Mamau, a.Soluong, a.Anh, a.Thoigianbaohanh , b.Tenmau FROM tblHanghoa a, tblMausac b WHERE a.Mamau = b.Mamau";
            tblDMHH = Functions.Functions.GetDataToTable(sql);
            d_GridView.DataSource = tblDMHH;
            string[] Header = new string[7] {
            "Ma hang", "Ten hang", "Ma mau", "So luong", "Anh", "Thoi gian bao hanh", "Ten mau"};

            for (int i = 0; i < Header.Length; i++)
            {
                d_GridView.Columns[i].HeaderText = Header[i];
            }

            d_GridView.AllowUserToAddRows = false;
            d_GridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            txtMahang.Enabled = true;
            ResetValues();
        }

        private void ResetValues()
        {
            foreach (object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox item2 = item as TextBox;
                    item2.Clear();
                }
            }

            cboMamau.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMahang.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua nhap ma hang");
                return;
            }

            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Chua nhap ten");
                return;
            }

            if (cboMamau.Text == "")
            {
                MessageBox.Show("Chua nhap ma mau");
                return;
            }

            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Chua nhap so luong");
                return;
            }

            if (txtTGBH.Text == "")
            {
                MessageBox.Show("Chua nhap TGBH");
                return;
            }

            if (txtPicPath.Text == "")
            {
                MessageBox.Show("Chua nhap anh");
                return;
            }


            string sql;
            sql = "SELECT Mahang FROM tblHanghoa WHERE Mahang = N'"+txtMahang.Text+"'";
            if (Functions.Functions.Checkkey(sql))
            {
                MessageBox.Show("Duplicate!");
                txtMahang.Text = "";
                return;
            }
            sql = "INSERT INTO tblHanghoa(Mahang, Tenhang, Mamau, Anh, Soluong, Thoigianbaohanh) " +
                "VALUES (N'" + txtMahang.Text + "', N'" + txtTenhang.Text + "', N'" + cboMamau.Text + "', N'" + txtPicPath.Text + "', N'" + txtSoluong.Text + "', N'" + txtTGBH.Text + "')";

            Functions.Functions.RunSQL(sql);
            Load_Grid();
            ResetValues();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.Filter = "JPG|*.jpg";
            odf.Title = "Chon anh";
            if (odf.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(odf.FileName);
                txtPicPath.Text = odf.FileName;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (d_GridView.Rows.Count == 0)
            {
                MessageBox.Show("Khong co gi de xoa");
                return;
            }

            if (txtMahang.Text == "")
            {
                MessageBox.Show("Chua chon");
                return;
            }

            sql = "DELETE FROM tblHanghoa WHERE Mahang = N'"+txtMahang.Text+"'";
            Functions.Functions.RunSQL(sql);
            Load_Grid();
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (d_GridView.Rows.Count == 0)
            {
                MessageBox.Show("Khong co gi");
                return;
            }

            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Chua nhap ten");
                return;
            }

            if (cboMamau.Text == "")
            {
                MessageBox.Show("Chua nhap ma mau");
                return;
            }

            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Chua nhap so luong");
                return;
            }

            if (txtTGBH.Text == "")
            {
                MessageBox.Show("Chua nhap TGBH");
                return;
            }

            if (txtPicPath.Text == "")
            {
                MessageBox.Show("Chua nhap anh");
                return;
            }

            sql = "UPDATE tblHanghoa(Tenhang, Mamau, Soluong, Thoigianbaohanh, Anh) " +
                "VALUES (N'"+txtTenhang.Text+"', N'"+cboMamau.Text+"', N'"+txtSoluong.Text+"', N'"+txtPicPath.Text+"' " +
                "WHERE Mahang = N'"+txtMahang.Text+"')";
            Functions.Functions.RunSQL(sql);
            Load_Grid();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void d_GridView_Click(object sender, EventArgs e)
        {
            if (d_GridView.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            if (!btnThem.Enabled)
            {
                MessageBox.Show("Dang o che do them");
                return;
            }

            txtMahang.Text = d_GridView.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = d_GridView.CurrentRow.Cells["Tenhang"].Value.ToString();
            string sql;
            sql = "SELECT Mamau FROM tblMausac WHERE Mamau = N'" + cboMamau.Text + "'";
            cboMamau.Text = Functions.Functions.GetFieldValues(sql);
            txtSoluong.Text = d_GridView.CurrentRow.Cells["Soluong"].Value.ToString();
            txtTGBH.Text = d_GridView.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            txtPicPath.Text = d_GridView.CurrentRow.Cells["Anh"].Value.ToString();
            picAnh.Image = Image.FromFile(txtPicPath.Text);

            btnBoqua.Enabled = true;
        }
    }
}
