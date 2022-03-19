
namespace BTSlides
{
    partial class frmBai18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai18));
            this.lstDanhsach = new System.Windows.Forms.ListBox();
            this.rtbLoi = new System.Windows.Forms.RichTextBox();
            this.wmpMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDanhsach
            // 
            this.lstDanhsach.FormattingEnabled = true;
            this.lstDanhsach.ItemHeight = 16;
            this.lstDanhsach.Items.AddRange(new object[] {
            "Anh cu di di",
            "Anh xau xi chu khong xau xa"});
            this.lstDanhsach.Location = new System.Drawing.Point(12, 12);
            this.lstDanhsach.Name = "lstDanhsach";
            this.lstDanhsach.Size = new System.Drawing.Size(253, 292);
            this.lstDanhsach.TabIndex = 0;
            this.lstDanhsach.SelectedIndexChanged += new System.EventHandler(this.lstDanhsach_SelectedIndexChanged);
            // 
            // rtbLoi
            // 
            this.rtbLoi.Location = new System.Drawing.Point(336, 12);
            this.rtbLoi.Name = "rtbLoi";
            this.rtbLoi.Size = new System.Drawing.Size(288, 502);
            this.rtbLoi.TabIndex = 1;
            this.rtbLoi.Text = "";
            // 
            // wmpMusic
            // 
            this.wmpMusic.Enabled = true;
            this.wmpMusic.Location = new System.Drawing.Point(12, 320);
            this.wmpMusic.Name = "wmpMusic";
            this.wmpMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusic.OcxState")));
            this.wmpMusic.Size = new System.Drawing.Size(220, 133);
            this.wmpMusic.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 521);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmBai18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wmpMusic);
            this.Controls.Add(this.rtbLoi);
            this.Controls.Add(this.lstDanhsach);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmBai18";
            this.Text = "Nhung bai hat hay";
            this.Load += new System.EventHandler(this.Bai18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhsach;
        private System.Windows.Forms.RichTextBox rtbLoi;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusic;
        private System.Windows.Forms.Button btnClose;
    }
}