namespace QuanLyBanhang
{
    partial class frmMain_nv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain_nv));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.hdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_MENU = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhmuc,
            this.mnuHoadon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 450);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
            this.mnuFile.BackColor = System.Drawing.Color.Aqua;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Image = global::QuanLyBanhang.Properties.Resources.account_cog_icon_137995;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(195, 60);
            this.mnuFile.Text = "&Tài Khoản";
            // 
            // mnuThoat
            // 
            this.mnuThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(274, 30);
            this.mnuThoat.Text = "Thông Tin Tài Khoản";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.AutoSize = false;
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachhang});
            this.mnuDanhmuc.Image = global::QuanLyBanhang.Properties.Resources.category_add_button_icon_icons_com_71724;
            this.mnuDanhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(200, 60);
            this.mnuDanhmuc.Text = "&Quản Lý Thông Tin";
            this.mnuDanhmuc.Click += new System.EventHandler(this.mnuDanhmuc_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.mnuKhachhang.Size = new System.Drawing.Size(273, 30);
            this.mnuKhachhang.Text = "&Khách hàng";
            this.mnuKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click_1);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.AutoSize = false;
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hdToolStripMenuItem});
            this.mnuHoadon.Image = global::QuanLyBanhang.Properties.Resources.shoppaymentorderbuy_23_icon_icons_com_73884;
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(193, 60);
            this.mnuHoadon.Text = "&Danh Mục";
            // 
            // hdToolStripMenuItem
            // 
            this.hdToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hdToolStripMenuItem.Name = "hdToolStripMenuItem";
            this.hdToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.hdToolStripMenuItem.Text = "Hóa Đơn";
            this.hdToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hdToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click_1);
            // 
            // PB_MENU
            // 
            this.PB_MENU.BackColor = System.Drawing.Color.Transparent;
            this.PB_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_MENU.Image = global::QuanLyBanhang.Properties.Resources.robo;
            this.PB_MENU.Location = new System.Drawing.Point(0, 0);
            this.PB_MENU.Name = "PB_MENU";
            this.PB_MENU.Size = new System.Drawing.Size(48, 48);
            this.PB_MENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_MENU.TabIndex = 4;
            this.PB_MENU.TabStop = false;
            this.PB_MENU.MouseEnter += new System.EventHandler(this.PB_MENU_MouseEnter);
            this.PB_MENU.MouseLeave += new System.EventHandler(this.PB_MENU_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanhang.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // frmMain_nv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_MENU);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain_nv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_nv_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem hdToolStripMenuItem;
        private System.Windows.Forms.PictureBox PB_MENU;
    }
}