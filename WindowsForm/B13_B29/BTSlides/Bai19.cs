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
    public partial class frmBai19 : Form
    {
        public frmBai19()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|Bitmap|*.bmp|Gif|*.gif|All|*.*";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = @"D:\";
            ofd.Title = "Chon hinh anh de hien thi";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Ban chon thoat");
            }
        }
    }
}
