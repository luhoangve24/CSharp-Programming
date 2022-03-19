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
    public partial class frmBai20 : Form
    {
        public frmBai20()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = @"D:\";
            sf.Filter = "Text|*.txt|Word|*.doc|All|*.*";
            sf.FilterIndex = 2;
            sf.Title = "Chon file de luu";
            sf.AddExtension = true;
            sf.DefaultExt = ".doc";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter File;
                File = new StreamWriter(sf.FileName);
                try
                {
                    File.Write(txtSave.Text);
                }
                catch(System.Exception)
                {
                    MessageBox.Show("Loi ghi file");
                }
                File.Close();
            }
        }
    }
}
