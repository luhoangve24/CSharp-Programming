using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.Forms
{
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
            lbl1.Parent = pictureBox1;
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {

        }
    }
}
