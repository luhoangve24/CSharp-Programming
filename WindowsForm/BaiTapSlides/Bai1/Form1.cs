using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmPheptoan : Form
    {
        public frmPheptoan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetqua.Enabled = false;
            btnLamlai.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             if ((MessageBox.Show("Bạn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes))
                {
                    Application.Exit();
                }
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào", "Cảnh báo", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                txtSoA.Focus();
                return;
            }

            if(txtSoB.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoB.Focus();
                return;
            }
            double a = Convert.ToDouble(txtSoA.Text);
            double b = Convert.ToDouble(txtSoB.Text);
            double c = 0;

            switch(txtPheptoan.Text)
            {
                case "/":
                    {
                        if (b==0)
                        {
                            txtKetqua.Text = "Mẫu không được là 0, vui lòng nhập lại";
                            txtSoB.Text = "";
                            txtSoB.Focus();
                            return;
                        }
                        else
                        {
                            c = a / b;
                            txtKetqua.Text = Convert.ToString(c);
                        }
                        break;
                    }

                case "*":
                    {
                        c = a * b;
                        txtKetqua.Text = Convert.ToString(c); 
                        break;
                    }

                case "+":
                    {
                        c = a + b;
                        txtKetqua.Text = Convert.ToString(c);
                        break;
                    }

                case "-":
                    {
                        c = a - b;
                        txtKetqua.Text = Convert.ToString(c);
                        break;
                    }

                default:
                    {
                        txtKetqua.Text = "Lỗi!, Chưa nhập phép toán";
                        txtPheptoan.Focus();
                        return;
                    }
            }

            btnLamlai.Enabled = true;
            btnThuchien.Enabled = false;
            txtSoA.ReadOnly = true;
            txtSoB.ReadOnly = true;
            txtPheptoan.ReadOnly = true;
        }

        private void txtPheptoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '+' || e.KeyChar == '-' || Convert.ToInt32(e.KeyChar) == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            btnThuchien.Enabled = true;
            btnLamlai.Enabled = false;
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtPheptoan.Text = "";
            txtKetqua.Text = "";
            txtSoA.ReadOnly = false;
            txtSoB.ReadOnly = false;
            txtPheptoan.ReadOnly = false;
            txtSoA.Focus();
        }
    }
}
