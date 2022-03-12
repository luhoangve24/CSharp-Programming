
namespace CacBaiSau
{
    partial class frmRandom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandom));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDayso = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTong
            // 
            resources.ApplyResources(this.btnTong, "btnTong");
            this.btnTong.Name = "btnTong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click_1);
            // 
            // txtNhapN
            // 
            resources.ApplyResources(this.txtNhapN, "txtNhapN");
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapN_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDayso
            // 
            resources.ApplyResources(this.txtDayso, "txtDayso");
            this.txtDayso.Name = "txtDayso";
            this.txtDayso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTong
            // 
            resources.ApplyResources(this.txtTong, "txtTong");
            this.txtTong.Name = "txtTong";
            this.txtTong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLamlai
            // 
            resources.ApplyResources(this.btnLamlai, "btnLamlai");
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmRandom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtDayso);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRandom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDayso;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
    }
}

