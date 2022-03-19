using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTSlides
{
    public partial class frmBai23 : Form
    {
        string path = null;
        public frmBai23()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "RichTextBox|*.rtf|Word|*.doc|Text|*.txt";
            dlgOpen.Title = "Chon file de mo";
            dlgOpen.InitialDirectory = @"E:\Lab\GitHub\CSharp-Programming\Baihat&Loibaihat";
            dlgOpen.FilterIndex = 1;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                path = dlgOpen.FileName;
                rtbLoi.LoadFile(path, RichTextBoxStreamType.RichText);
            }
            else
            {
                path = null;
                MessageBox.Show("Ban da tat");
                rtbLoi.Clear();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.ShowColor = true;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                rtbLoi.Font = dlgFont.Font;
                rtbLoi.ForeColor = dlgFont.Color;
            }
            else
            {
                MessageBox.Show("Ban huy chon font");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Chua chon file nao de chinh sua va luu");
            }
            else
            {
                rtbLoi.SaveFile(path, RichTextBoxStreamType.RichText);
            }

        }
    }
}
