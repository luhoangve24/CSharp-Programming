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
    public partial class frmBai28 : Form
    {
        public frmBai28()
        {
            InitializeComponent();
        }

        private void Bai28_Load(object sender, EventArgs e)
        {
            string path;
            path = @"E:\Lab\GitHub\CSharp-Programming\Baihat&Loibaihat\Dientu.rtf";
            rtbLoadFile.LoadFile(path, RichTextBoxStreamType.RichText);
            txtBai.Text = rtbLoadFile.Text;
            txtBai.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (object item1 in groupBox1.Controls)
            {
                if (item1 is TextBox)
                {
                    TextBox item = (TextBox)item1;
                    if (item.Text != "")
                    {
                        lstDien.Items.Add(item.Text);
                    }
                }
            }

            foreach (object item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox item2 = item as TextBox;
                    int count = 0;
                    foreach (string item1 in lstDapan.Items)
                    {
                        if (string.Compare(item2.Text.ToLower(), item1.ToLower()) == 0)
                        {
                            item2.BackColor = Color.Green;
                            continue;
                        }
                        count++;
                        if (count == lstDapan.Items.Count)
                        {
                            item2.BackColor = Color.Red;
                        }
                    }
                }
            }

            //Cac button khac tu lam duoc :) !
        }
    }
}
