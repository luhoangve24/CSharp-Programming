using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lbl1.Parent = pic1;
            lbl2.Parent = pic1;
            lbl1.BackColor = Color.Transparent;
            lbl2.BackColor = Color.Transparent;
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            Classes.Funtions.Ketnoi();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            Forms.frmChatlieu f = new Forms.frmChatlieu();
            f.ShowDialog();
        }
        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien f = new Forms.frmNhanVien();
            f.ShowDialog();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.frmKhachhang f = new Forms.frmKhachhang();
            f.ShowDialog();
        }
        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            Forms.frmDMHH f = new Forms.frmDMHH();
            f.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Classes.Funtions.NgatKetnoi();
            Application.Exit();
        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.ShowDialog();
        }

        private void mnuFindHoadon_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDBan f = new Forms.frmTimHDBan();
            f.ShowDialog();
        }

        private void testFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormTest f = new Forms.FormTest();
            f.ShowDialog();
        }

        private void mnuFindHang_Click(object sender, EventArgs e)
        {
            Forms.FormTimKiemHH f = new Forms.FormTimKiemHH();
            f.ShowDialog();
        }
    }
}
