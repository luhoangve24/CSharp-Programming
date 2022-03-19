
namespace BTSlides
{
    partial class frmBai17
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
            this.lblChao = new System.Windows.Forms.Label();
            this.tmrChay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblChao
            // 
            this.lblChao.AutoSize = true;
            this.lblChao.Location = new System.Drawing.Point(12, 72);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(108, 17);
            this.lblChao.TabIndex = 0;
            this.lblChao.Text = "Chao mung ban";
            // 
            // tmrChay
            // 
            this.tmrChay.Enabled = true;
            this.tmrChay.Interval = 250;
            this.tmrChay.Tick += new System.EventHandler(this.tmrChay_Tick);
            // 
            // frmBai17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 185);
            this.Controls.Add(this.lblChao);
            this.Name = "frmBai17";
            this.Text = "Bai17";
            this.Load += new System.EventHandler(this.frmBai17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Timer tmrChay;
    }
}