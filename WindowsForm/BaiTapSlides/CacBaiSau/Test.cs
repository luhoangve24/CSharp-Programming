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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Division(int n)
        {
            int kq = 0;
            try
            {
                kq = 4 / n;
            }
            catch(System.DivideByZeroException loi)
            {
                MessageBox.Show("Éo thể chia cho 0" + loi.Message);
                txtA.Text = "";
                txtA.Focus();
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                txtA.Focus();
                return;
            }
            int a = Convert.ToInt32(txtA.Text);
            Division(a);
        }
    }
}
