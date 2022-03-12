
namespace CacBaiSau
{
    partial class frmMessegeForBai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessegeForBai5));
            this.lblMessege = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessege
            // 
            this.lblMessege.AutoSize = true;
            this.lblMessege.Location = new System.Drawing.Point(126, 128);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(46, 17);
            this.lblMessege.TabIndex = 0;
            this.lblMessege.Text = "label1";
            this.lblMessege.Click += new System.EventHandler(this.lblMessege_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 131);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCo
            // 
            this.btnCo.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCo.Location = new System.Drawing.Point(67, 196);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(75, 23);
            this.btnCo.TabIndex = 2;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = true;
            // 
            // btnKhong
            // 
            this.btnKhong.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnKhong.Location = new System.Drawing.Point(238, 196);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(75, 23);
            this.btnKhong.TabIndex = 2;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            // 
            // frmMessegeForBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 265);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMessegeForBai5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.frmMessegeForBai5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
    }
}