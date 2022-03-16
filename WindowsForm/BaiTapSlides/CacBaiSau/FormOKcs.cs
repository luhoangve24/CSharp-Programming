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
    public partial class frmOK : Form
    {
        public frmOK()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "BM|*.bmp|GIF|*.gif|Allfile|*.*";
            a.InitialDirectory = "E://";
            a.FilterIndex = 3;
            a.Title = "Hay chon hinh anh";
            if (a.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(a.FileName);
            }
            else
                MessageBox.Show("Ban chua mo hinh anh nao");
        }
    }
}
