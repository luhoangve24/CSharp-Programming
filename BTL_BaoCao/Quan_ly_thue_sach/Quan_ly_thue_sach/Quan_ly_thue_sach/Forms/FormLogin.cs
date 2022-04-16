using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_ly_thue_sach.Classes;

namespace Quan_ly_thue_sach.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string userName, userPassword;

            if (txtTK.Text.Trim().Length == 0 || txtMK.Text.Trim().Length == 0)
            {
                lblLoi.Text = "**Chưa nhập đầy đủ thông tin!**";
                lblLoi.Visible = true;
                return;
            } 

            userName = txtTK.Text;
            userPassword = txtMK.Text;
            if (Funtions.Login(userName, userPassword))
            {
                MessageBox.Show("Chào Admin, chúc một ngày làm việc vui vẻ :) !");
                Forms.frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();
                Funtions.NgatKetNoi();
            }
            else
            {
                MessageBox.Show("Sai rồi, mời bạn nhập lại");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/luhoangve/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
