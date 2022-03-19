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
    public partial class frmBai25 : Form
    {
        string path = null;
        public frmBai25()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Word|*.doc|Text|*.txt|RichText|*.rtf";
            dlgOpen.FilterIndex = 3;
            dlgOpen.InitialDirectory = @"D:\";
            dlgOpen.Title = "Chon file";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                path = dlgOpen.FileName;
                rtbVanban1.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbVanban1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbVanban2.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbVanban1.SelectedText);
            rtbVanban1.SelectedText = String.Empty;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbVanban1.SelectedText = String.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbVanban1.SaveFile(path, RichTextBoxStreamType.RichText);
            }
            catch(System.Exception f)
            {
                MessageBox.Show(f.ToString());
            }
            
        }
    }
}
