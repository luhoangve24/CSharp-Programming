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
    public partial class frmBai8 : Form
    {
        public frmBai8()
        {
            InitializeComponent();
        }

        private void frmBai8_Load(object sender, EventArgs e)
        {
            lstDanhsach.SelectionMode = SelectionMode.MultiSimple;
            lstDanhsach.ColumnWidth = lstDanhsach.Width/4;
            lstDanhsach.MultiColumn = true;
            for (int i = 1; i <= 100; i++)
            {
                lstDanhsach.Items.Add("Item " + i.ToString());
            }
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            string KQ = "Bạn đã chọn phần tử ";
            if (lstDanhsach.SelectedItems.Count > 1)
            {
                for (int i = 0; i < lstDanhsach.SelectedItems.Count; i++)
                {
                    KQ += lstDanhsach.SelectedItems[i].ToString();
                    if (i + 1 < lstDanhsach.SelectedItems.Count)
                    {
                        KQ += ", ";
                    }
                }
                MessageBox.Show(KQ);
            }
            else
            {
                if (lstDanhsach.SelectedIndex == -1)
                {
                    MessageBox.Show("Chua chon phan tu nao!");
                }
                else
                {
                    KQ += lstDanhsach.SelectedItem.ToString();
                    MessageBox.Show(KQ);
                }

            }
        }
    }
}
