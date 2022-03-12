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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMessegeForBai5 frm = new frmMessegeForBai5();
            frm.lblMessege.Text = "Bạn có muốn thoát không?";
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
