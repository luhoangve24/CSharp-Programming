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
    public partial class frmBai10 : Form
    {
        public frmBai10()
        {
            InitializeComponent();
        }

        private bool KiemTraNhap()
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Ban chua nhap gi!");
                txtNhap.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void rdoVnTime_Click(object sender, EventArgs e)
        {
            string Font = "";
            RadioButton rdo = sender as RadioButton;
            if (KiemTraNhap() == true)
            {
                switch (rdo.Text)
                {
                    case "VnTime":
                        {
                            Font = "Agency FB";
                            break;
                        }

                    case "VnUniverse":
                        {
                            Font = "Microsoft YaHei UI";
                            break;
                        }

                    case "VnVogue":
                        {
                            Font = "Modern No. 20";
                            break;
                        }

                    case "Tahoma":
                        {
                            Font = "Tahoma";
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                txtNhap.Font = new Font(Font, 8);
                groupBox1.Enabled = false;
                btnLamlai.Enabled = true;
            }
        }


        private void chkStrike_H_Click(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked == true)
            {
                if (chk.Text == "Bold")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style | FontStyle.Bold);
                }

                if (chk.Text == "Italic")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style | FontStyle.Italic);
                }

                if (chk.Text == "Strikeout")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style | FontStyle.Strikeout);
                }

                if (chk.Text == "UnderLine")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style | FontStyle.Underline);
                }
            }
            else
            {
                if (chk.Text == "Bold")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style ^ FontStyle.Bold);
                }

                if (chk.Text == "Italic")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style ^ FontStyle.Italic);
                }

                if (chk.Text == "Strikeout")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style ^ FontStyle.Strikeout);
                }

                if (chk.Text == "UnderLine")
                {
                    txtNhap.Font = new Font(txtNhap.Font, txtNhap.Font.Style ^ FontStyle.Underline);
                }
            }
        }

        private void rdoXanh_Click(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            switch(rdo.Text)
            {
                case "Xanh":
                    {
                        txtNhap.ForeColor = Color.Blue;
                        break;
                    }

                case "Đỏ":
                    {
                        txtNhap.ForeColor = Color.Red;
                        break;
                    }

                case "Vàng":
                    {
                        txtNhap.ForeColor = Color.Yellow;
                        break;
                    }

                case "Tím":
                    {
                        txtNhap.ForeColor = Color.Purple;
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            btnLamlai.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void frmBai10_Load(object sender, EventArgs e)
        {
            btnLamlai.Enabled = false;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is RadioButton)
                {
                    RadioButton rdo = (RadioButton)ctr;
                    if (rdo.Checked == true)
                    {
                        rdo.Checked = false;
                    }
                }
            }

            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    if  (chk.Checked == true)
                    {
                        chk.Checked = false;
                    }
                }
            }

            foreach (Control ctr in groupBox3.Controls)
            {
                if (ctr is RadioButton)
                {
                    RadioButton rdo = (RadioButton)ctr;
                    if (rdo.Checked == true)
                    {
                        rdo.Checked = false;
                    }
                }
            }

            txtNhap.Text = "";
            txtNhap.Focus();
            btnLamlai.Enabled = false;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Muon thoat a?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
