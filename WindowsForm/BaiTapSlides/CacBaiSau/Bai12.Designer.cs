
namespace CacBaiSau
{
    partial class frmBai12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lstMathang = new System.Windows.Forms.ListBox();
            this.grpThanhtoan = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.grpLienlac = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstHangdatmua = new System.Windows.Forms.ListBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpThanhtoan.SuspendLayout();
            this.grpLienlac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho ten khach";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(152, 12);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(208, 39);
            this.txtHoten.TabIndex = 1;
            // 
            // lstMathang
            // 
            this.lstMathang.FormattingEnabled = true;
            this.lstMathang.ItemHeight = 16;
            this.lstMathang.Items.AddRange(new object[] {
            "Ky nang lap trinh Visual Basic 6.0",
            "Tu hoc ASP trong 21 ngay",
            "Tu hoc PHP & My SQL trong 21 ngay",
            "Bai tap Visual Basic 6.0",
            "Tin hoc can ban",
            "Den voi Word 2000",
            "Den voi Excel 2000",
            "Bai tap C co ban va nang cao",
            "SQL server",
            "Python Crash Course",
            "Algorithms and Structures",
            "3 ky nang co ban HTML, CSS, JS",
            "Natural language processing"});
            this.lstMathang.Location = new System.Drawing.Point(38, 145);
            this.lstMathang.Name = "lstMathang";
            this.lstMathang.Size = new System.Drawing.Size(322, 132);
            this.lstMathang.TabIndex = 2;
            this.lstMathang.DoubleClick += new System.EventHandler(this.lstMathang_DoubleClick);
            // 
            // grpThanhtoan
            // 
            this.grpThanhtoan.Controls.Add(this.radioButton3);
            this.grpThanhtoan.Controls.Add(this.radioButton2);
            this.grpThanhtoan.Controls.Add(this.radioButton1);
            this.grpThanhtoan.Location = new System.Drawing.Point(38, 299);
            this.grpThanhtoan.Name = "grpThanhtoan";
            this.grpThanhtoan.Size = new System.Drawing.Size(200, 159);
            this.grpThanhtoan.TabIndex = 3;
            this.grpThanhtoan.TabStop = false;
            this.grpThanhtoan.Text = "Phuong thuc thanh toan";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "The tin dung";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sec";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tien mat";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Dien thoai";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(542, 314);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(104, 54);
            this.btnDongy.TabIndex = 2;
            this.btnDongy.Text = "Dong y";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // grpLienlac
            // 
            this.grpLienlac.Controls.Add(this.checkBox3);
            this.grpLienlac.Controls.Add(this.checkBox2);
            this.grpLienlac.Controls.Add(this.checkBox1);
            this.grpLienlac.Location = new System.Drawing.Point(257, 299);
            this.grpLienlac.Name = "grpLienlac";
            this.grpLienlac.Size = new System.Drawing.Size(200, 159);
            this.grpLienlac.TabIndex = 3;
            this.grpLienlac.TabStop = false;
            this.grpLienlac.Text = "Hinh thuc lien lac";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 91);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 21);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Email";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Fax";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(542, 374);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 48);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstHangdatmua
            // 
            this.lstHangdatmua.FormattingEnabled = true;
            this.lstHangdatmua.ItemHeight = 16;
            this.lstHangdatmua.Location = new System.Drawing.Point(388, 145);
            this.lstHangdatmua.Name = "lstHangdatmua";
            this.lstHangdatmua.Size = new System.Drawing.Size(326, 132);
            this.lstHangdatmua.TabIndex = 2;
            this.lstHangdatmua.DoubleClick += new System.EventHandler(this.lstHangdatmua_DoubleClick);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(456, 12);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(256, 64);
            this.txtDiachi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dia chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sach cac mat hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hang dat mua";
            // 
            // frmBai12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 470);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.grpLienlac);
            this.Controls.Add(this.grpThanhtoan);
            this.Controls.Add(this.lstHangdatmua);
            this.Controls.Add(this.lstMathang);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai12";
            this.Text = "Bai12";
            this.Load += new System.EventHandler(this.Bai12_Load);
            this.grpThanhtoan.ResumeLayout(false);
            this.grpThanhtoan.PerformLayout();
            this.grpLienlac.ResumeLayout(false);
            this.grpLienlac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ListBox lstMathang;
        private System.Windows.Forms.GroupBox grpThanhtoan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.GroupBox grpLienlac;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstHangdatmua;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}