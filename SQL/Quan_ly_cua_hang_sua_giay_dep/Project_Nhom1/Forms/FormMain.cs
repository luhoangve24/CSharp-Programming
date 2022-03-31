using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Nhom1.Classes;

namespace Project_Nhom1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Funtions.KetNoi();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("T");
            label8.Text = DateTime.Now.ToString("D");
            label9.Text = DateTime.Now.ToString("dddd");
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien f = new Forms.frmNhanVien();
            f.Show();
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang f = new Forms.frmKhachHang();
            f.Show();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            Forms.frmSanPham f = new Forms.frmSanPham();
            f.Show();
        }

        private void btnXuong_Click(object sender, EventArgs e)
        {
            Forms.frmXuong f = new Forms.frmXuong();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.frmHDNH f = new Forms.frmHDNH();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmHDDX f = new Forms.frmHDDX();
            f.Show();
        }
    }
}
