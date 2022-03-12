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
    public partial class frmCalculation : Form
    {
        int soA = 0;
        int soB = 0;
        public frmCalculation()
        {
            InitializeComponent();
        }

        private void frmCalculation_Load(object sender, EventArgs e)
        {
            txtKetqua.ReadOnly = true;
            btnLamlai.Enabled = false;
        }

        private void txtNhapa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNhapb_KeyPress(object sender, KeyPressEventArgs e)
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

        private Boolean KiemTraNhap()
        {
            if (txtNhapa.Text == "")
            {
                MessageBox.Show("Bạn phải nhập A");
                txtNhapa.Focus();
                return false;
            }
            else
            {
                soA = Int32.Parse(txtNhapa.Text);
            }

            if (txtNhapb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập B");
                txtNhapb.Focus();
                return false;
            }
            else
            {
                soB = Int32.Parse(txtNhapb.Text);
            }

            return true;
        }

        private void rdoCong_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                rdoCong.Checked = false;
            }
            else
            {
                int tong = 0;
                tong = soA + soB;
                txtKetqua.Text = tong.ToString();
                ChonLamLai();
            }
        }

        private void rdoTru_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                rdoCong.Checked = false;
            }
            else
            {
                int tong = 0;
                tong = soA - soB;
                txtKetqua.Text = tong.ToString();
                ChonLamLai();
            }
        }

        private void rdoNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                rdoCong.Checked = false;
            }
            else
            {
                int tong = 0;
                tong = soA * soB;
                txtKetqua.Text = tong.ToString();
                ChonLamLai();
            }
        }

        private void rdoChia_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                rdoCong.Checked = false;
            }
            else
            {
                double tong = 0;
                if (soB == 0)
                {
                    txtKetqua.Text = "Mẫu = 0, nhập lại";
                    txtNhapb.Text = "";
                    txtNhapb.Focus();
                }
                else
                {
                    tong = (double)soA / soB;
                    txtKetqua.Text = tong.ToString();
                    ChonLamLai();
                }
            }
        }

        private void ChonLamLai()
        {
            txtNhapa.Enabled = false;
            txtNhapb.Enabled = false;
            btnLamlai.Enabled = true;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhapa.Enabled = true;
            txtNhapa.Text = "";
            txtNhapb.Enabled = true;
            txtNhapb.Text = "";
            txtKetqua.Text = "";
            btnLamlai.Enabled = false;
            rdoChia.Checked = false;
            rdoCong.Checked = false;
            rdoNhan.Checked = false;
            rdoTru.Checked = false;
            chkMax.Checked = false;
            chkMin.Checked = false;
            chkMax.Text = "Max";
            chkMin.Text = "Min";
        }

        private void chkMax_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                chkMax.Checked = false;
            }
            else
            {
                chkMax.Text = "Max " + ((soA>soB?soA:soB)).ToString();
            }
            ChonLamLai();
        }

        private void chkMin_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                chkMin.Checked = false;
            }
            else
            {
                chkMin.Text = "Min " + ((soA < soB ? soA : soB)).ToString();
            }
            ChonLamLai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                == DialogResult.OK)
            {
                Application.Exit();
            }    
        }
    }
}
