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
    public partial class frmBai15 : Form
    {
        public frmBai15()
        {
            InitializeComponent();
            
        }

        private void hsbRed_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblRed.Text = hsbRed.Value.ToString();
            lblGreen.Text = hsbGreen.Value.ToString();
            lblBlue.Text = hsbBlue.Value.ToString();
        }
    }
}
