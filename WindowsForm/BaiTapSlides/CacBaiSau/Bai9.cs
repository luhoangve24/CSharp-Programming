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
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        private void frmBai9_Load(object sender, EventArgs e)
        {
            string[] Folder;
            Folder = System.IO.Directory.GetDirectories("E:/Lab");
            cboThumuc.DataSource = Folder;
        }


    }
}
