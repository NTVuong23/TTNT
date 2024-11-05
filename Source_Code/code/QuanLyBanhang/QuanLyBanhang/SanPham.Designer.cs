namespace QuanLyBanhang
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_nhacc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_manhacc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_loaihang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_hangsx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TKtenKH = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 227);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_nhacc);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(523, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 57);
            this.panel4.TabIndex = 9;
            // 
            // cb_nhacc
            // 
            this.cb_nhacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhacc.FormattingEnabled = true;
            this.cb_nhacc.Location = new System.Drawing.Point(153, 7);
            this.cb_nhacc.Name = "cb_nhacc";
            this.cb_nhacc.Size = new System.Drawing.Size(295, 30);
            this.cb_nhacc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Công Ty";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cb_manhacc);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(521, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 50);
            this.panel5.TabIndex = 8;
            // 
            // cb_manhacc
            // 
            this.cb_manhacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_manhacc.FormattingEnabled = true;
            this.cb_manhacc.Location = new System.Drawing.Point(159, 5);
            this.cb_manhacc.Name = "cb_manhacc";
            this.cb_manhacc.Size = new System.Drawing.Size(291, 30);
            this.cb_manhacc.TabIndex = 4;
            this.cb_manhacc.SelectedIndexChanged += new System.EventHandler(this.cb_manhacc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã NCC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_loaihang);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(521, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 58);
            this.panel3.TabIndex = 4;
            // 
            // cb_loaihang
            // 
            this.cb_loaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaihang.FormattingEnabled = true;
            this.cb_loaihang.Location = new System.Drawing.Point(159, 5);
            this.cb_loaihang.Name = "cb_loaihang";
            this.cb_loaihang.Size = new System.Drawing.Size(291, 30);
            this.cb_loaihang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mặt Hàng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_hangsx);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(28, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 40);
            this.panel6.TabIndex = 3;
            // 
            // txt_hangsx
            // 
            this.txt_hangsx.Location = new System.Drawing.Point(159, 5);
            this.txt_hangsx.MaxLength = 40;
            this.txt_hangsx.Name = "txt_hangsx";
            this.txt_hangsx.Size = new System.Drawing.Size(272, 28);
            this.txt_hangsx.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hãng sản xuất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTensp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(28, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 40);
            this.panel2.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(159, 6);
            this.txtTensp.MaxLength = 40;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(272, 28);
            this.txtTensp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMasp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(159, 5);
            this.txtMasp.MaxLength = 10;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.ReadOnly = true;
            this.txtMasp.Size = new System.Drawing.Size(272, 28);
            this.txtMasp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TKtenKH);
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Controls.Add(this.btnLammoi);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1014, 118);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // txt_TKtenKH
            // 
            this.txt_TKtenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKtenKH.Location = new System.Drawing.Point(0, 56);
            this.txt_TKtenKH.Name = "txt_TKtenKH";
            this.txt_TKtenKH.Size = new System.Drawing.Size(178, 27);
            this.txt_TKtenKH.TabIndex = 40;
            this.txt_TKtenKH.Text = "Nhập Tên Sản Phẩm";
            this.txt_TKtenKH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TKtenKH_MouseClick);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = global::QuanLyBanhang.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(184, 42);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(104, 54);
            this.btn_timkiem.TabIndex = 39;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Image = global::QuanLyBanhang.Properties.Resources.reset;
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(328, 45);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(156, 46);
            this.btnLammoi.TabIndex = 5;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseMnemonic = false;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyBanhang.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(849, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 47);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyBanhang.Properties.Resources.update;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(687, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 46);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Image = global::QuanLyBanhang.Properties.Resources.insret;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(520, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 46);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseMnemonic = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_sanpham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 268);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin sản phẩm";
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AllowUserToAddRows = false;
            this.dgv_sanpham.AllowUserToDeleteRows = false;
            this.dgv_sanpham.AllowUserToResizeRows = false;
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sanpham.Location = new System.Drawing.Point(3, 24);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersVisible = false;
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.RowTemplate.Height = 24;
            this.dgv_sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_sanpham.Size = new System.Drawing.Size(1011, 241);
            this.dgv_sanpham.TabIndex = 9;
            this.dgv_sanpham.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellEnter);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1020, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_hangsx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_nhacc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cb_manhacc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_loaihang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TKtenKH;
        private System.Windows.Forms.Button btn_timkiem;
    }
}