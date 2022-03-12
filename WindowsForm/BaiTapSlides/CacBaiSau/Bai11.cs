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
    public partial class frmBai11 : Form
    {
        public frmBai11()
        {
            InitializeComponent();
        }

        private void EmptyOption()
        {
            foreach (Control crt in grpCapital.Controls)
            {
                if (crt is RadioButton)
                {
                    RadioButton rdo = crt as RadioButton;
                    if (rdo.Checked == true)
                        rdo.Checked = false;
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            string name = "";
            name = string.Format("Hãy chọn thành phố cho {0}", rdo.Text);
            lblThanhpho.Text = name;
            EmptyOption();
        }

        private void frmBai11_Load(object sender, EventArgs e)
        {
            EmptyOption();
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;

            string Capital = rdo.Text;
            int check = 0;
            string Country = "";

            foreach (Control ctr in grpCountry.Controls)
            {
                RadioButton rdo2 = ctr as RadioButton;
                if (rdo2.Checked == true)
                {
                    Country = rdo2.Text;
                    break;
                }
            }

            switch (Capital)
            {
                case "Buenos Aires":
                    {
                        if (Country == "Argentina")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Brazil":
                    { 
                        if (Country == "Brazil")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Tokyo":
                    {
                        if (Country == "Japan")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Rome":
                    {
                        if (Country == "Italia")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Washington":
                    {
                        if (Country == "The USA")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Marid":
                    {
                        if (Country == "Spain")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "London":
                    {
                        if (Country == "The UK")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Ankara":
                    {
                        if (Country == "Turkey")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Budapest":
                    {
                        if (Country == "Hungary")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }

                case "Paris":
                    {
                        if (Country == "France")
                            check = 1;
                        else
                            check = -1;
                        break;
                    }
            }

            string ThongBao = "";
            if (check == 1)
            {
                ThongBao = string.Format("Chúc mừng bạn, thủ đô của {0} là {1}", Country, Capital);
            }
            else
            {
                ThongBao = string.Format("Bạn sai rồi, thủ đô của {0} không phải là {1}", Country, Capital);
            }

            MessageBox.Show(ThongBao);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rsl;
            rsl = MessageBox.Show("Thoat ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rsl == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }


}
