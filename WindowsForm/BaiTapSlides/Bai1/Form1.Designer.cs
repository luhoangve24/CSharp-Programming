
namespace Bai1
{
    partial class frmPheptoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPheptoan));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtPheptoan = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(170, 55);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(325, 22);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoA_KeyPress);
            // 
            // btnThuchien
            // 
            this.btnThuchien.Location = new System.Drawing.Point(107, 238);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(102, 44);
            this.btnThuchien.TabIndex = 0;
            this.btnThuchien.Text = "&Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(170, 96);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(325, 22);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoB_KeyPress);
            // 
            // txtPheptoan
            // 
            this.txtPheptoan.Location = new System.Drawing.Point(170, 137);
            this.txtPheptoan.Name = "txtPheptoan";
            this.txtPheptoan.Size = new System.Drawing.Size(325, 22);
            this.txtPheptoan.TabIndex = 1;
            this.txtPheptoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPheptoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPheptoan_KeyPress);
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(170, 178);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(325, 22);
            this.txtKetqua.TabIndex = 1;
            this.txtKetqua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phép toán:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(278, 238);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(102, 44);
            this.btnLamlai.TabIndex = 0;
            this.btnLamlai.Text = "&Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(449, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 44);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPheptoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 349);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtPheptoan);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPheptoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình thực hiện phép toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtPheptoan;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
    }
}

