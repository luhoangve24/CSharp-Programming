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
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            string KetQua = "";
            KetQua = "Ban da chon sach ";
            foreach (string item in clbSach.CheckedItems)
            {
                KetQua += item + ", ";
            }

            KetQua = KetQua.Remove(KetQua.Length - 2, 2);
            MessageBox.Show(KetQua);
        }

        private void clbSach_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                MessageBox.Show("Ban da chon sach" + clbSach.Text);

        }
    }
}
