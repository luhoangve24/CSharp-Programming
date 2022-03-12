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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtNhapthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNhapnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            int thang, nam;

            if (txtNhapthang.Text == "")
            {
                MessageBox.Show("Chưa nhập tháng");
                txtNhapthang.Focus();
                return;
            }
            else
            {
                thang = Convert.ToInt32(txtNhapthang.Text);
                if (thang < 1 || thang > 12)
                {
                    MessageBox.Show("Nhập tháng lỗi, vui lòng nhập lại");
                    txtNhapthang.Focus();
                    return;
                }
            }


            if (txtNhapnam.Text == "")
            {
                MessageBox.Show("Chưa nhập năm");
                txtNhapnam.Focus();
                return;
            }
            else
            {
                nam = Convert.ToInt32(txtNhapnam.Text);
                if ((nam.ToString().Length != 4) && nam < 1900)
                {
                    MessageBox.Show("Nhập năm lỗi, năm tối thiểu 4 chữ số và lớn hơn 1900!");
                    txtNhapnam.Focus();
                    return;
                }
            }

            int ngay = 0;
            Boolean loaiNam = false;

            if (nam % 4 == 0 || nam % 400 == 0)
            {
                loaiNam = true;
            }
            else
            {
                loaiNam = false;
            }

            switch(thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        ngay = 31;
                        break;
                    }

                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        ngay = 30;
                        break;
                    }

                case 2:
                    {
                        if (loaiNam == true)
                        {
                            ngay = 29;
                        }
                        else
                        {
                            ngay = 28;
                        }
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Nothing!");
                        break;
                    }
            }

            lblKetqua.Visible = true;
            btnLamlai.Enabled = true;
            btnKetqua.Enabled = false;
            txtNhapnam.ReadOnly = true;
            txtNhapthang.ReadOnly = true;
            lblKetqua.Text = "Tháng " + thang.ToString() + " năm " + nam.ToString() + " có " + ngay.ToString() + " ngày";
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            lblKetqua.Visible = false;
            btnLamlai.Enabled = false;
            lblKetqua.Text = "";
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = "";
            lblKetqua.Visible = false;
            btnKetqua.Enabled = true;
            btnLamlai.Enabled = false;
            txtNhapthang.ReadOnly = false;
            txtNhapnam.Text = "";
            txtNhapthang.Text = "";
            txtNhapnam.ReadOnly = false;
            txtNhapthang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            == DialogResult.OK)
            {
                Application.Exit();
            }    
        }
    }
}
