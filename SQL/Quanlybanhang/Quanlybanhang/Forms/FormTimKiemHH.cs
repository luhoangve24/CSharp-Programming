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
    public partial class FormTimKiemHH : Form
    {
        public FormTimKiemHH()
        {
            InitializeComponent();
        }

        DataTable tblTKHH;
        private void FormTimKiemHH_Load(object sender, EventArgs e)
        {
            ResetValues();
            d_GridTimkiem.DataSource = null;
        }

        private void ResetValues()
        {
            txtMahang.Clear();
            txtTenhang.Clear();
            txtMachatlieu.Clear();
            txtMahang.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahang.Text == "" && txtTenhang.Text == "" && txtMachatlieu.Text == "")
            {
                MessageBox.Show("Ban phai nhap it nhat mot dieu kien tim kiem");
                txtMahang.Focus();
                return;
            }
            sql = "SELECT Mahang, Tenhang, Machatlieu FROM tblHang WHERE 1=1";
            if (txtMahang.Text != "")
                sql += " AND Machatlieu like N'%"+txtMachatlieu.Text+"%'";
            if (txtTenhang.Text != "")
                sql += " AND Tenhang like N'%"+txtTenhang.Text+"%'";
            if (txtMachatlieu.Text != "")
                sql += " AND Machatlieu like N'%"+txtMachatlieu.Text+"%'";

            tblTKHH = Classes.Funtions.GetDataToTable(sql);
            if (tblTKHH.Rows.Count == 0)
            {
                MessageBox.Show("Khong co ban ghi nao thoa man", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                return;
            }
            else
            {
                MessageBox.Show("Co " + tblTKHH.Rows.Count + " ban ghi thoa man");
                d_GridTimkiem.DataSource = tblTKHH;
            }
        }

        private void Load_DataGrid()
        {
            d_GridTimkiem.Columns[0].HeaderText = "Ma hang";
            d_GridTimkiem.Columns[1].HeaderText = "Ten hang";
            d_GridTimkiem.Columns[2].HeaderText = "Ma chat lieu";

            d_GridTimkiem.AllowUserToAddRows = false;
            d_GridTimkiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            d_GridTimkiem.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
