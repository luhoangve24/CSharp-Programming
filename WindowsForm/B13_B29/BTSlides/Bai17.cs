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
    public partial class frmBai17 : Form
    {
        bool KT; // KT = true sang phai, KT = false sang trai
        int x = 0;
        int y = 0;
        Point diem;
        public frmBai17()
        {
            InitializeComponent();
        }

        private void frmBai17_Load(object sender, EventArgs e)
        {
            KT = true;
        }

        private void tmrChay_Tick(object sender, EventArgs e)
        {
            /*            if (KT)
                        {
                            if (lblChao.Left + lblChao.Width < this.Width)
                            {
                                lblChao.Left = lblChao.Left + 13;
                            }
                            else
                            {
                                KT = false;
                            }
                        }

                        if (!KT)
                        {
                            if (lblChao.Left > 0)
                            {
                                lblChao.Left = lblChao.Left - 13;
                            }
                            else
                            {
                                KT = true;
                            }
                        }*/
            if (KT)
            {
                if (lblChao.Location.X + lblChao.Width < this.Width)
                {
                    x += 13;
                    y = lblChao.Height;
                    diem = new Point(x, y);
                    lblChao.Location = diem;
                }
                else KT = false;
            }
            else
            {
                if (lblChao.Location.X >= 0)
                {
                    x -= 13;
                    y = lblChao.Height;
                    diem = new Point(x, y);
                    lblChao.Location = diem;
                }
                else KT = true;
            }
        }
    }
}
