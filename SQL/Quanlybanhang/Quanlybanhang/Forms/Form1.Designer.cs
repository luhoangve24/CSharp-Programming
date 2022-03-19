
namespace Quanlybanhang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFindHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHangton = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuHoadon,
            this.mnuTimkiem,
            this.mnuBaocao,
            this.mnuHelp,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatlieu,
            this.mnuNhanvien,
            this.mnuKhachhang,
            this.mnuHanghoa});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhmuc.Text = "Danh muc";
            // 
            // mnuChatlieu
            // 
            this.mnuChatlieu.Name = "mnuChatlieu";
            this.mnuChatlieu.Size = new System.Drawing.Size(169, 26);
            this.mnuChatlieu.Text = "Chat lieu";
            this.mnuChatlieu.Click += new System.EventHandler(this.mnuChatlieu_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanvien.Text = "Nhan vien";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachhang.Text = "Khach hang";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuHanghoa
            // 
            this.mnuHanghoa.Name = "mnuHanghoa";
            this.mnuHanghoa.Size = new System.Drawing.Size(224, 26);
            this.mnuHanghoa.Text = "Hang hoa";
            this.mnuHanghoa.Click += new System.EventHandler(this.mnuHanghoa_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoadonban});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(81, 24);
            this.mnuHoadon.Text = "Hoa don";
            // 
            // mnuHoadonban
            // 
            this.mnuHoadonban.Name = "mnuHoadonban";
            this.mnuHoadonban.Size = new System.Drawing.Size(224, 26);
            this.mnuHoadonban.Text = "Hoa don ban";
            this.mnuHoadonban.Click += new System.EventHandler(this.mnuHoadonban_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoadon,
            this.toolStripMenuItem1,
            this.mnuFindHang,
            this.mnuFindKhachhang});
            this.mnuTimkiem.Name = "mnuTimkiem";
            this.mnuTimkiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimkiem.Text = "Tim kiem";
            // 
            // mnuFindHoadon
            // 
            this.mnuFindHoadon.Name = "mnuFindHoadon";
            this.mnuFindHoadon.Size = new System.Drawing.Size(224, 26);
            this.mnuFindHoadon.Text = "Hoa don";
            this.mnuFindHoadon.Click += new System.EventHandler(this.mnuFindHoadon_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuFindHang
            // 
            this.mnuFindHang.Name = "mnuFindHang";
            this.mnuFindHang.Size = new System.Drawing.Size(169, 26);
            this.mnuFindHang.Text = "Hang";
            // 
            // mnuFindKhachhang
            // 
            this.mnuFindKhachhang.Name = "mnuFindKhachhang";
            this.mnuFindKhachhang.Size = new System.Drawing.Size(169, 26);
            this.mnuFindKhachhang.Text = "Khach hang";
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHangton,
            this.mnuBCDoanhthu});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaocao.Text = "Bao cao";
            // 
            // mnuBCHangton
            // 
            this.mnuBCHangton.Name = "mnuBCHangton";
            this.mnuBCHangton.Size = new System.Drawing.Size(161, 26);
            this.mnuBCHangton.Text = "Hang ton";
            // 
            // mnuBCDoanhthu
            // 
            this.mnuBCDoanhthu.Name = "mnuBCDoanhthu";
            this.mnuBCDoanhthu.Size = new System.Drawing.Size(161, 26);
            this.mnuBCDoanhthu.Text = "Doanh thu";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(78, 24);
            this.mnuHelp.Text = "Tro giup";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoat";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(-1, 35);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(594, 416);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("iCielBC Cubano Normal", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(118, 243);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(361, 46);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Bán hàng lưu niệm";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("iCielBC Cubano Normal", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(80, 187);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(422, 46);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Chương trình quản lý";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pic1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuong trinh quan ly ban hang";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoadon;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHangton;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}

