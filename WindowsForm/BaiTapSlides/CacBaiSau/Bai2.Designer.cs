
namespace CacBaiSau
{
    partial class frmBai2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapthang = new System.Windows.Forms.TextBox();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.txtNhapnam = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tháng";
            // 
            // txtNhapthang
            // 
            this.txtNhapthang.Location = new System.Drawing.Point(154, 55);
            this.txtNhapthang.Name = "txtNhapthang";
            this.txtNhapthang.Size = new System.Drawing.Size(269, 22);
            this.txtNhapthang.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNhapthang, "Nhập tháng đi bạn ơi");
            this.txtNhapthang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapthang_KeyPress);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(74, 194);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 2;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // txtNhapnam
            // 
            this.txtNhapnam.Location = new System.Drawing.Point(154, 102);
            this.txtNhapnam.Name = "txtNhapnam";
            this.txtNhapnam.Size = new System.Drawing.Size(269, 22);
            this.txtNhapnam.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNhapnam, "Nhập năm đi bạn");
            this.txtNhapnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapnam_KeyPress);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(98, 146);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(46, 17);
            this.lblKetqua.TabIndex = 0;
            this.lblKetqua.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập năm";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(224, 194);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 23);
            this.btnLamlai.TabIndex = 2;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 194);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 274);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.txtNhapnam);
            this.Controls.Add(this.txtNhapthang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBai2";
            this.Text = "Program of Date";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapthang;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.TextBox txtNhapnam;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}