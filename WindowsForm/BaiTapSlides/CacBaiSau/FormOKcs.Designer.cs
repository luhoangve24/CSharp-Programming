
namespace CacBaiSau
{
    partial class frmOK
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
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(67, 113);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(277, 300);
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(411, 294);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "                                       ";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // frmOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 496);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.picAnh);
            this.Name = "frmOK";
            this.Text = "FormOKcs";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnClick;
    }
}