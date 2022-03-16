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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bài2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBai2 fr = new frmBai2();
            fr.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculation fr = new frmCalculation();
            fr.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai5 fr = new frmBai5();
            fr.Show();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai6_P2 fr = new frmBai6_P2();
            fr.Show();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai7 fr = new frmBai7();
            fr.Show();
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai8 fr = new frmBai8();
            fr.Show();
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai9 fr = new frmBai9();
            fr.Show();
        }

        private void bài10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai10 fr = new frmBai10();
            fr.Show();
        }

        private void bài11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai11 fr = new frmBai11();
            fr.Show();
        }

        private void bài12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai12 fr = new frmBai12();
            fr.Show();
        }
    }
}
