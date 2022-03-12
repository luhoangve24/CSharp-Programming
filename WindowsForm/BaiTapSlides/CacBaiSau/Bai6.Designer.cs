
namespace CacBaiSau
{
    partial class frmCalculation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.txtNhapb = new System.Windows.Forms.TextBox();
            this.txtNhapa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoChia = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            this.rdoTru = new System.Windows.Forms.RadioButton();
            this.rdoCong = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetqua);
            this.groupBox1.Controls.Add(this.txtNhapb);
            this.groupBox1.Controls.Add(this.txtNhapa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(121, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(113, 84);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(100, 22);
            this.txtKetqua.TabIndex = 1;
            // 
            // txtNhapb
            // 
            this.txtNhapb.Location = new System.Drawing.Point(113, 54);
            this.txtNhapb.Name = "txtNhapb";
            this.txtNhapb.Size = new System.Drawing.Size(100, 22);
            this.txtNhapb.TabIndex = 1;
            this.txtNhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapb_KeyPress);
            // 
            // txtNhapa
            // 
            this.txtNhapa.Location = new System.Drawing.Point(113, 24);
            this.txtNhapa.Name = "txtNhapa";
            this.txtNhapa.Size = new System.Drawing.Size(100, 22);
            this.txtNhapa.TabIndex = 1;
            this.txtNhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoChia);
            this.groupBox2.Controls.Add(this.rdoNhan);
            this.groupBox2.Controls.Add(this.rdoTru);
            this.groupBox2.Controls.Add(this.rdoCong);
            this.groupBox2.Location = new System.Drawing.Point(24, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phép toán";
            // 
            // rdoChia
            // 
            this.rdoChia.AutoSize = true;
            this.rdoChia.Location = new System.Drawing.Point(21, 102);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new System.Drawing.Size(57, 21);
            this.rdoChia.TabIndex = 0;
            this.rdoChia.TabStop = true;
            this.rdoChia.Text = "Chia";
            this.rdoChia.UseVisualStyleBackColor = true;
            this.rdoChia.Click += new System.EventHandler(this.rdoChia_Click);
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.Location = new System.Drawing.Point(21, 75);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(63, 21);
            this.rdoNhan.TabIndex = 0;
            this.rdoNhan.TabStop = true;
            this.rdoNhan.Text = "Nhân";
            this.rdoNhan.UseVisualStyleBackColor = true;
            this.rdoNhan.Click += new System.EventHandler(this.rdoNhan_Click);
            // 
            // rdoTru
            // 
            this.rdoTru.AutoSize = true;
            this.rdoTru.Location = new System.Drawing.Point(21, 48);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new System.Drawing.Size(51, 21);
            this.rdoTru.TabIndex = 0;
            this.rdoTru.TabStop = true;
            this.rdoTru.Text = "Trừ";
            this.rdoTru.UseVisualStyleBackColor = true;
            this.rdoTru.Click += new System.EventHandler(this.rdoTru_Click);
            // 
            // rdoCong
            // 
            this.rdoCong.AutoSize = true;
            this.rdoCong.Location = new System.Drawing.Point(22, 21);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new System.Drawing.Size(62, 21);
            this.rdoCong.TabIndex = 0;
            this.rdoCong.Text = "Cộng";
            this.rdoCong.UseVisualStyleBackColor = true;
            this.rdoCong.Click += new System.EventHandler(this.rdoCong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkMin);
            this.groupBox3.Controls.Add(this.chkMax);
            this.groupBox3.Location = new System.Drawing.Point(283, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 143);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "So sánh";
            // 
            // chkMin
            // 
            this.chkMin.AutoSize = true;
            this.chkMin.Location = new System.Drawing.Point(19, 93);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(52, 21);
            this.chkMin.TabIndex = 1;
            this.chkMin.Text = "Min";
            this.chkMin.UseVisualStyleBackColor = true;
            this.chkMin.Click += new System.EventHandler(this.chkMin_Click);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(19, 48);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(55, 21);
            this.chkMax.TabIndex = 1;
            this.chkMax.Text = "Max";
            this.chkMax.UseVisualStyleBackColor = true;
            this.chkMax.Click += new System.EventHandler(this.chkMax_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(151, 288);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 23);
            this.btnLamlai.TabIndex = 2;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(288, 288);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 323);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program of Calculation";
            this.Load += new System.EventHandler(this.frmCalculation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.TextBox txtNhapb;
        private System.Windows.Forms.TextBox txtNhapa;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
    }
}