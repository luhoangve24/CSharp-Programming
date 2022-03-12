
namespace CacBaiSau
{
    partial class frmBai8
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
            this.lstDanhsach = new System.Windows.Forms.ListBox();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhsach
            // 
            this.lstDanhsach.FormattingEnabled = true;
            this.lstDanhsach.ItemHeight = 16;
            this.lstDanhsach.Location = new System.Drawing.Point(12, 12);
            this.lstDanhsach.Name = "lstDanhsach";
            this.lstDanhsach.Size = new System.Drawing.Size(397, 244);
            this.lstDanhsach.TabIndex = 0;
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(165, 274);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 1;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // frmBai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 322);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.lstDanhsach);
            this.Name = "frmBai8";
            this.Text = "Bai8";
            this.Load += new System.EventHandler(this.frmBai8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhsach;
        private System.Windows.Forms.Button btnKetqua;
    }
}