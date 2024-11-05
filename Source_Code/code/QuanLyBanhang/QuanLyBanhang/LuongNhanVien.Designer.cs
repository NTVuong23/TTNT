namespace QuanLyBanhang
{
    partial class LuongNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongNhanVien));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_luong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TKtenNV = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.bt_sgl = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.bt_lmoi = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nup_sgl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngayNV = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngayNL = new System.Windows.Forms.DateTimePicker();
            this.txt_tnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mnv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_sgl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_luong);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1213, 227);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Bảng Lương";
            // 
            // dgv_luong
            // 
            this.dgv_luong.AllowUserToAddRows = false;
            this.dgv_luong.AllowUserToDeleteRows = false;
            this.dgv_luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_luong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_luong.Location = new System.Drawing.Point(3, 23);
            this.dgv_luong.Name = "dgv_luong";
            this.dgv_luong.ReadOnly = true;
            this.dgv_luong.RowHeadersWidth = 51;
            this.dgv_luong.RowTemplate.Height = 24;
            this.dgv_luong.Size = new System.Drawing.Size(1207, 201);
            this.dgv_luong.TabIndex = 0;
            this.dgv_luong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_luong_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TKtenNV);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.bt_sgl);
            this.groupBox1.Controls.Add(this.btn_Excel);
            this.groupBox1.Controls.Add(this.bt_lmoi);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 112);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // txt_TKtenNV
            // 
            this.txt_TKtenNV.Location = new System.Drawing.Point(12, 38);
            this.txt_TKtenNV.Name = "txt_TKtenNV";
            this.txt_TKtenNV.Size = new System.Drawing.Size(165, 27);
            this.txt_TKtenNV.TabIndex = 7;
            this.txt_TKtenNV.Text = "Nhập Tên Nhân Viên";
            this.txt_TKtenNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TKtenKH_MouseClick);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = global::QuanLyBanhang.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(183, 21);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(135, 61);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // bt_sgl
            // 
            this.bt_sgl.Image = global::QuanLyBanhang.Properties.Resources.update;
            this.bt_sgl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sgl.Location = new System.Drawing.Point(496, 21);
            this.bt_sgl.Name = "bt_sgl";
            this.bt_sgl.Size = new System.Drawing.Size(171, 61);
            this.bt_sgl.TabIndex = 10;
            this.bt_sgl.Text = "Cập nhật sgl";
            this.bt_sgl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sgl.UseVisualStyleBackColor = true;
            this.bt_sgl.Click += new System.EventHandler(this.bt_sgl_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Image = global::QuanLyBanhang.Properties.Resources.excel;
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(1055, 21);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(146, 61);
            this.btn_Excel.TabIndex = 13;
            this.btn_Excel.Text = "File Excel";
            this.btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // bt_lmoi
            // 
            this.bt_lmoi.Image = global::QuanLyBanhang.Properties.Resources.reset;
            this.bt_lmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lmoi.Location = new System.Drawing.Point(341, 21);
            this.bt_lmoi.Name = "bt_lmoi";
            this.bt_lmoi.Size = new System.Drawing.Size(132, 61);
            this.bt_lmoi.TabIndex = 9;
            this.bt_lmoi.Text = "Làm mới";
            this.bt_lmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_lmoi.UseVisualStyleBackColor = true;
            this.bt_lmoi.Click += new System.EventHandler(this.bt_lmoi_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Image = global::QuanLyBanhang.Properties.Resources.update;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(700, 21);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(185, 61);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.Text = "Cập nhật lương";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Image = global::QuanLyBanhang.Properties.Resources.delete;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(909, 21);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(115, 61);
            this.bt_xoa.TabIndex = 12;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nup_sgl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_ngayNV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_luong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtp_ngayNL);
            this.groupBox2.Controls.Add(this.txt_tnv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_mnv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 178);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // nup_sgl
            // 
            this.nup_sgl.Location = new System.Drawing.Point(170, 111);
            this.nup_sgl.Name = "nup_sgl";
            this.nup_sgl.Size = new System.Drawing.Size(151, 27);
            this.nup_sgl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(747, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Ngày Nhận Việc";
            // 
            // dtp_ngayNV
            // 
            this.dtp_ngayNV.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngayNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNV.Location = new System.Drawing.Point(950, 49);
            this.dtp_ngayNV.Name = "dtp_ngayNV";
            this.dtp_ngayNV.Size = new System.Drawing.Size(142, 30);
            this.dtp_ngayNV.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(353, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "Lương / 1h";
            // 
            // txt_luong
            // 
            this.txt_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(496, 113);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(188, 30);
            this.txt_luong.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(747, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ngày Nhận Lương";
            // 
            // dtp_ngayNL
            // 
            this.dtp_ngayNL.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngayNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNL.Location = new System.Drawing.Point(950, 113);
            this.dtp_ngayNL.Name = "dtp_ngayNL";
            this.dtp_ngayNL.Size = new System.Drawing.Size(142, 30);
            this.dtp_ngayNL.TabIndex = 6;
            // 
            // txt_tnv
            // 
            this.txt_tnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tnv.Location = new System.Drawing.Point(496, 49);
            this.txt_tnv.Name = "txt_tnv";
            this.txt_tnv.ReadOnly = true;
            this.txt_tnv.Size = new System.Drawing.Size(188, 30);
            this.txt_tnv.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(353, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tên nhân viên";
            // 
            // txt_mnv
            // 
            this.txt_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mnv.Location = new System.Drawing.Point(170, 51);
            this.txt_mnv.Name = "txt_mnv";
            this.txt_mnv.ReadOnly = true;
            this.txt_mnv.Size = new System.Drawing.Size(148, 30);
            this.txt_mnv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Số giờ làm";
            // 
            // LuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1213, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương Nhân Viên";
            this.Load += new System.EventHandler(this.LuongNhanVien_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_sgl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_luong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_sgl;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button bt_lmoi;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox txt_TKtenNV;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ngayNL;
        private System.Windows.Forms.TextBox txt_tnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngayNV;
        private System.Windows.Forms.NumericUpDown nup_sgl;
    }
}