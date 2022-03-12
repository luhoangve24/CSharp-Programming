
namespace CacBaiSau
{
    partial class frmBai9
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
            this.cboThumuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboThumuc
            // 
            this.cboThumuc.FormattingEnabled = true;
            this.cboThumuc.IntegralHeight = false;
            this.cboThumuc.Location = new System.Drawing.Point(122, 54);
            this.cboThumuc.MaxDropDownItems = 2;
            this.cboThumuc.Name = "cboThumuc";
            this.cboThumuc.Size = new System.Drawing.Size(121, 24);
            this.cboThumuc.TabIndex = 0;
            // 
            // frmBai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 187);
            this.Controls.Add(this.cboThumuc);
            this.Name = "frmBai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai9";
            this.Load += new System.EventHandler(this.frmBai9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboThumuc;
    }
}