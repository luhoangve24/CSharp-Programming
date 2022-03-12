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
    public partial class frmRandom : Form
    {
        int _SL;
        double[] _DS;
        public frmRandom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamlai.Enabled = false;
            txtDayso.ReadOnly = true;
            txtTong.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnTong_Click_1(object sender, EventArgs e)
        {
            if (txtNhapN.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapN.Focus();
                return;
            }

            double tong = 0;
            _SL = Convert.ToInt32(txtNhapN.Text);
            _DS = new double[_SL];
            Random rnd = new Random();

            for (int i = 0; i < _SL; i++)
            {
                _DS[i] = rnd.Next(1, 100);
                tong += _DS[i];
                txtDayso.Text = txtDayso.Text + "   " + Convert.ToString(_DS[i]);
            }

            txtTong.Text = Convert.ToString(tong);

            txtNhapN.ReadOnly = true;
            btnTong.Enabled = false;
            btnLamlai.Enabled = true;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            btnTong.Enabled = true;
            btnLamlai.Enabled = false;
            txtNhapN.ReadOnly = false;
            txtDayso.Text = "";
            txtNhapN.Text = "";
            txtTong.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
