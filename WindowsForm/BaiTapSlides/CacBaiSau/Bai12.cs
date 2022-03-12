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
    public partial class frmBai12 : Form
    {
        KiemTraNhap Vu;
        public frmBai12()
        {
            InitializeComponent();
        }

        private void Bai12_Load(object sender, EventArgs e)
        {

        }

        private void lstMathang_DoubleClick(object sender, EventArgs e)
        {
            int check = 1;
            foreach (string item in lstHangdatmua.Items)
            {
                if (string.Compare(item, lstMathang.SelectedItem.ToString()) == 0)
                {
                    MessageBox.Show("Ban da  chon roi");
                    check = 0;
                    break;
                }
            }

            if (check == 1)
            {
                lstHangdatmua.Items.Add(lstMathang.SelectedItem);
            }
        }

        private void lstHangdatmua_DoubleClick(object sender, EventArgs e)
        {
            DialogResult rsl;
            string Sach = "";
            Sach = string.Format("Ban co muon xoa {0} khong ?", lstHangdatmua.SelectedItem);
            rsl = MessageBox.Show(Sach, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rsl == DialogResult.Yes)
                lstHangdatmua.Items.Remove(lstHangdatmua.SelectedItem);
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            Vu = new KiemTraNhap();
            string KetQua = "";
            if (Vu.KiemTra(txtHoten) == true
                && Vu.KiemTra(txtDiachi) == true
                && Vu.KiemTra(grpLienlac) == true
                && Vu.KiemTra(grpThanhtoan) == true
                && Vu.KiemTra(lstHangdatmua) == true
                )
            {
                KetQua = string.Format("Ho ten khach: {0}\n" +
                    "Dia chi: {1}\n" +
                    "Hang dat mua:\n", txtHoten.Text, txtDiachi.Text);

                foreach (string item in lstHangdatmua.Items)
                {
                    KetQua += "-" + " " + item + "\n";
                }

                string KetQua2 = "";
                string PTTT = "";
                foreach (RadioButton item in grpThanhtoan.Controls)
                {
                    if (item.Checked == true)
                    {
                        PTTT = item.Text;
                        break;
                    }
                }
                KetQua2 = string.Format("Phuong thuc thanh toan: {0}\n", PTTT);
                KetQua += KetQua2 + "Hinh thuc lien lac:";

                foreach (CheckBox item in grpLienlac.Controls)
                {
                    if (item.Checked == true)
                    {
                        KetQua += " " + item.Text + ",";
                    }
                }

                KetQua = KetQua.Remove(KetQua.Length - 1, 1);
                MessageBox.Show(KetQua, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rsl;
            rsl = MessageBox.Show("Muon thoat ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    class KiemTraNhap
    {
        public bool KiemTra(TextBox txt)
        {
            if (txt.Text == "")
            {
                MessageBox.Show("Vui long kiem tra lai nhap thong tin!");
                txt.Focus();
                return false;
            }
            else
                return true;
        }

        public bool KiemTra(GroupBox grp)
        {
            int check = 0;
            foreach (Control item in grp.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rdo = item as RadioButton;
                    if (rdo.Checked == false)
                    {
                        check += 1;
                    }
                }

                if (item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    if (chk.Checked == false)
                    {
                        check += 1;
                    }
                }
            }

            if (check == grp.Controls.Count)
            {
                MessageBox.Show("Vui long kiem tra lai xem chon lua chon chua ?");
                grp.Focus();
                return false;
            }
            else
                return true;
        }

        public bool KiemTra(ListBox lst)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Ban chua chon mat hang nao !");
                return false;
            }
            else
                return true;
        }
    }
}
