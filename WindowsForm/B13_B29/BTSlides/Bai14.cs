using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTSlides
{
    public partial class frmBai14 : Form
    {
        public frmBai14()
        {
            InitializeComponent();
        }

        private void frmBai14_Load(object sender, EventArgs e)
        {
            nuda.Increment = 1;
            nuda.Minimum = -100;
            nuda.Maximum = 100;
            nuda.Value = 0;

            nudb.Increment = 1;
            nudb.Minimum = -100;
            nudb.Maximum = 100;
            nudb.Value = 0;

            nudc.Increment = 1;
            nudc.Minimum = -100;
            nudc.Maximum = 100;
            nudc.Value = 0;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = (double)nuda.Value;
            double b = (double)nudb.Value;
            double c = (double)nudc.Value;

            double delta = 0;
            delta = Math.Pow(b, 2) - 4 * a * c;
            txtKQ.Text = "A=" + a + "\r\nB=" + b + "\r\nC=" + c;
            if (delta == 0)
            {
                txtKQ.Text += "\r\nPhuong trinh co nghiem kep";
                txtx1.Text = ((-b) / (2 * a)).ToString();
                txtx2.Text = txtx1.Text;
            }
            if (delta > 0)
            {
                txtKQ.Text += "\r\nPhuong trinh co 2 nghiem phan biet";
                txtx1.Text = ((-b + Math.Sqrt(delta) / 2 * a)).ToString();
                txtx2.Text = ((-b - Math.Sqrt(delta) / 2 * a)).ToString();
            }
            if (delta < 0)
            {
                txtKQ.Text += "\r\nPhuong trinh vo nghiem";
            }
        }

        private void nuda_ValueChanged(object sender, EventArgs e)
        {
            txtKQ.Text = "A=" + nuda.Value + "\r\nB=" + nudb.Value + "\r\nC=" + nudc.Value;
            txtx1.Text = "";
            txtx2.Text = "";
        }
    }
}
