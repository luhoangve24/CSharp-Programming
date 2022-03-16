using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacBaiSau
{
    public partial class frmBai6_P2 : Form
    {
        public frmBai6_P2()
        {
            InitializeComponent();
        }
        private void frmBai6_P2_Load(object sender, EventArgs e)
        {
            txtTongtien.ReadOnly = true;
            rdo5.Visible = false;
            rdo10.Visible = false;
        }

        private bool KiemTraNhap()
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Phải nhập mã hàng");
                txtMahang.Focus();
                return false;
            }

            if (txtDongia.Text == "")
            {
                MessageBox.Show("Phải nhập đơn giá");
                txtDongia.Focus();
                return false;
            }

            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Phải nhập số lượng");
                txtSoluong.Focus();
                return false;
            }

            if (chkGiamgia.Checked == true && (rdo5.Checked == false && rdo10.Checked == false))
            {
                MessageBox.Show("Vui lòng chọn giảm giá bao nhiêu");
                return false;
            }

            return true;

        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chkGiamgia_Click(object sender, EventArgs e)
        {
            if (chkGiamgia.Checked == true)
            {
                rdo10.Visible = true;
                rdo5.Visible = true;
            }
            else
            {
                rdo10.Visible = false;
                rdo10.Checked = false;
                rdo5.Visible = false;
                rdo5.Checked = false;
            }
        }

        private double GiamGia()
        {
            if (rdo5.Checked == true)
            {
                rdo10.Checked = false;
                return 0.05;
            }

            else
            {
                if (rdo10.Checked == true)
                {
                    rdo5.Checked = false;
                    return 0.1;
                }

                else
                    return 0;
            }
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                return;
            }    
            else
                txtTongtien.Text = (Int32.Parse(txtDongia.Text) * Int32.Parse(txtSoluong.Text) - Int32.Parse(txtDongia.Text) * Int32.Parse(txtSoluong.Text) * GiamGia()).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void chkGiamgia_CheckedChanged(object sender, EventArgs e)
        {
            txtTongtien.Text = "";
        }

        private void rdo5_CheckedChanged(object sender, EventArgs e)
        {
            txtTongtien.Text = "";
        }

        private void rdo10_CheckedChanged(object sender, EventArgs e)
        {
            txtTongtien.Text = "";
        }
    }
}
