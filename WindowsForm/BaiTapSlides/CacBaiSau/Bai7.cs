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
    public partial class frmBai7 : Form
    {
        public frmBai7()
        {
            InitializeComponent();
        }

        private void frmBai7_Load(object sender, EventArgs e)
        {
            txtNhapten.Focus();
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
        }

        private bool KiemTraNhap()
        {
            if (txtNhapten.Text == "")
            {
                MessageBox.Show("Ban phai nhap nuoc vao");
                txtNhapten.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == false)
            {
                return;
            }
            else
            {
                lstNuoc.Items.Add(txtNhapten.Text);
                txtNhapten.Text = "";
                txtNhapten.Focus();
                btnXoa.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*if (KiemTraNhap() == false)
            {
                return;
            }
            else
            {
                int num = 0;
                if (Int32.TryParse(txtNhapten.Text, out num))
                {
                    if (num - 1 < lstNuoc.Items.Count && num - 1 >= 0)
                    {
                        lstNuoc.Items.RemoveAt(num - 1);
                        if (lstNuoc.Items.Count == 0)
                        {
                            btnXoa.Enabled = false;
                        }
                    }
                    else
                        MessageBox.Show("Vuot qua gioi han!");
                }
                else
                {
                    for (int i = 0; i < lstNuoc.Items.Count; i++)
                    {
                        if (txtNhapten.Text == lstNuoc.Items[i].ToString())
                        {
                            lstNuoc.Items.Remove(txtNhapten.Text);
                            num = 1;
                            if (lstNuoc.Items.Count == 0)
                            {
                                btnXoa.Enabled = false;
                            }
                            break;
                        }
                        num = 0;
                    }

                    if (num == 0)
                        MessageBox.Show("Khong tim thay");
                }
            }*/
            if (lstNuoc.Items.Count == 0)
            {
                MessageBox.Show("Khong con phan tu nao de xoa", "Thong bao");
                btnXoa.Enabled = false;
                btnTimkiem.Enabled = false;
                return;
            }
            
            if (lstNuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Ban phai chon 1 nuoc", "Thong bao");
                return;
            }
            else
            {
                DialogResult rsl = MessageBox.Show("Ban co muon xoa khong ?", "Xac nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rsl == DialogResult.OK)
                {
                    lstNuoc.Items.RemoveAt(lstNuoc.SelectedIndex);
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (lstNuoc.Items.Count == 0)
            {
                MessageBox.Show("Khong con phan tu nao de tim kiem", "Thong bao");
                btnXoa.Enabled = false;
                btnTimkiem.Enabled = false;
                return;
            }

            if (KiemTraNhap() == false)
            {
                return;
            }

            int check = 0;
            for (int i = 0; i < lstNuoc.Items.Count; i++)
            {
                if (txtNhapten.Text.ToLower() == lstNuoc.Items[i].ToString().ToLower())
                {
                    string nuoc;
                    nuoc = string.Format("Tim thay {0} o vi tri {1}", txtNhapten.Text, i);
                    MessageBox.Show(nuoc);
                    check = 1;
                    break;
                }
            }

            if (check == 0)
            {
                MessageBox.Show("Khong tim thay nuoc nay");
                txtNhapten.Text = "";
                txtNhapten.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Ban muon thoat a?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
