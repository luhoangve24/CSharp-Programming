using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BTSlides
{
    public partial class frmBai18 : Form
    {
        public frmBai18()
        {
            InitializeComponent();
        }

        private void Bai18_Load(object sender, EventArgs e)
        {
            
        }

        private void lstDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chon;
            chon = lstDanhsach.SelectedIndex;
            switch(chon)
            {
                case 0:
                    {
                        rtbLoi.LoadFile(@"E:\Lab\GitHub\CSharp-Programming\Baihat&Loibaihat\AnhCudidi.rtf", RichTextBoxStreamType.RichText);
                        wmpMusic.URL = (@"E:\Lab\GitHub\CSharp-Programming\Baihat&Loibaihat\Anh Cu Di Di - Hari Won.mp3");
                        break;
                    }
            }
        }
    }
}
