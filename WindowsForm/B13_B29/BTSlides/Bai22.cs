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
    public partial class frmBai22 : Form
    {
        public frmBai22()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.ShowColor = true;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtNhap.Font = dlgFont.Font;
                txtNhap.ForeColor = dlgFont.Color;
            }
        }
    }
}
