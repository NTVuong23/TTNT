namespace QuanLyBanhang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuong_Menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TK_menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_MENU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MENU)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanhang.Properties.Resources._30d34757b19f10c1498e;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhmuc,
            this.mnuHoadon,
            this.tinhLuong_Menustrip,
            this.TK_menustrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Image = global::QuanLyBanhang.Properties.Resources.account_cog_icon_137995;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(130, 29);
            this.mnuFile.Text = "&Tài Khoản";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(274, 30);
            this.mnuThoat.Text = "Thông Tin Tài Khoản";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click_1);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaCungCap,
            this.mnuNhanvien,
            this.mnuKhachhang,
            this.mnuSanPham,
            this.mặtHàngToolStripMenuItem});
            this.mnuDanhmuc.Image = global::QuanLyBanhang.Properties.Resources.category_add_button_icon_icons_com_71724;
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(207, 29);
            this.mnuDanhmuc.Text = "&Quản Lý Thông Tin";
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuNhaCungCap.Size = new System.Drawing.Size(293, 30);
            this.mnuNhaCungCap.Text = "&Nhà Cung Cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mnuNhanvien.Size = new System.Drawing.Size(293, 30);
            this.mnuNhanvien.Text = "&Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click_1);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.mnuKhachhang.Size = new System.Drawing.Size(293, 30);
            this.mnuKhachhang.Text = "&Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click_1);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mnuSanPham.Size = new System.Drawing.Size(293, 30);
            this.mnuSanPham.Text = "&Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click_1);
            // 
            // mặtHàngToolStripMenuItem
            // 
            this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            this.mặtHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.mặtHàngToolStripMenuItem.Text = "Mặt Hàng";
            this.mặtHàngToolStripMenuItem.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem_Click_1);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoadonban,
            this.hóaĐơnToolStripMenuItem});
            this.mnuHoadon.Image = global::QuanLyBanhang.Properties.Resources.shoppaymentorderbuy_23_icon_icons_com_73884;
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(133, 29);
            this.mnuHoadon.Text = "&Danh Mục";
            // 
            // mnuHoadonban
            // 
            this.mnuHoadonban.Name = "mnuHoadonban";
            this.mnuHoadonban.Size = new System.Drawing.Size(197, 30);
            this.mnuHoadonban.Text = "Phiếu Nhập";
            this.mnuHoadonban.Click += new System.EventHandler(this.mnuHoadonban_Click_1);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click_1);
            // 
            // tinhLuong_Menustrip
            // 
            this.tinhLuong_Menustrip.Image = global::QuanLyBanhang.Properties.Resources.pay_cash_payment_money_dollar_bill_icon_143267;
            this.tinhLuong_Menustrip.Name = "tinhLuong_Menustrip";
            this.tinhLuong_Menustrip.Size = new System.Drawing.Size(143, 29);
            this.tinhLuong_Menustrip.Text = "Tính Lương";
            this.tinhLuong_Menustrip.Click += new System.EventHandler(this.tinhLuong_Menustrip_Click_1);
            // 
            // TK_menustrip
            // 
            this.TK_menustrip.Image = global::QuanLyBanhang.Properties.Resources.collection_statistical_data_analysis_market_research_big_data_icon_260965;
            this.TK_menustrip.Name = "TK_menustrip";
            this.TK_menustrip.Size = new System.Drawing.Size(128, 29);
            this.TK_menustrip.Text = "Thống Kê";
            this.TK_menustrip.Click += new System.EventHandler(this.TK_menustrip_Click_1);
            // 
            // PB_MENU
            // 
            this.PB_MENU.BackColor = System.Drawing.Color.Transparent;
            this.PB_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_MENU.Image = global::QuanLyBanhang.Properties.Resources.robo;
            this.PB_MENU.Location = new System.Drawing.Point(801, 0);
            this.PB_MENU.Name = "PB_MENU";
            this.PB_MENU.Size = new System.Drawing.Size(48, 48);
            this.PB_MENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_MENU.TabIndex = 6;
            this.PB_MENU.TabStop = false;
            this.PB_MENU.MouseEnter += new System.EventHandler(this.PB_MENU_MouseEnter);
            this.PB_MENU.MouseLeave += new System.EventHandler(this.PB_MENU_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 436);
            this.Controls.Add(this.PB_MENU);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MENU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadonban;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhLuong_Menustrip;
        private System.Windows.Forms.ToolStripMenuItem TK_menustrip;
        private System.Windows.Forms.PictureBox PB_MENU;
    }
}

