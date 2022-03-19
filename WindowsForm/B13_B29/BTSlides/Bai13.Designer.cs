
namespace BTSlides
{
    partial class frmCheckListBox
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
            this.clbSach = new System.Windows.Forms.CheckedListBox();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbSach
            // 
            this.clbSach.ColumnWidth = 221;
            this.clbSach.FormattingEnabled = true;
            this.clbSach.HorizontalScrollbar = true;
            this.clbSach.Items.AddRange(new object[] {
            "Visual Basic .NET 2005",
            "Visual C# .NET 2005",
            "Lap trinh Oracle",
            "Lap trinh CSDL",
            "Lap trinh Python",
            "Lap trinh huong doi tuong C++",
            "Phan tich he thong thong tin",
            "Lap trinh WinForms",
            "Nhap mon OCV",
            "Do hoa may tinh"});
            this.clbSach.Location = new System.Drawing.Point(26, 59);
            this.clbSach.MultiColumn = true;
            this.clbSach.Name = "clbSach";
            this.clbSach.Size = new System.Drawing.Size(441, 157);
            this.clbSach.TabIndex = 0;
            this.clbSach.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSach_ItemCheck);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(204, 321);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 1;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // frmCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 356);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.clbSach);
            this.Name = "frmCheckListBox";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSach;
        private System.Windows.Forms.Button btnKetqua;
    }
}

