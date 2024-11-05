namespace QuanLyBanhang
{
    partial class HoanTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoanTra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_hoanTra = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TKtenKH = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_hoanTra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_msp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_dGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date_nl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_tkh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_tsp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_sp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoanTra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_hoanTra);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dgv_hoanTra
            // 
            this.dgv_hoanTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoanTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoanTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hoanTra.Location = new System.Drawing.Point(3, 23);
            this.dgv_hoanTra.Name = "dgv_hoanTra";
            this.dgv_hoanTra.RowHeadersWidth = 51;
            this.dgv_hoanTra.RowTemplate.Height = 24;
            this.dgv_hoanTra.Size = new System.Drawing.Size(1023, 194);
            this.dgv_hoanTra.TabIndex = 0;
            this.dgv_hoanTra.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoanTra_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TKtenKH);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_hoanTra);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txt_TKtenKH
            // 
            this.txt_TKtenKH.Location = new System.Drawing.Point(168, 44);
            this.txt_TKtenKH.Name = "txt_TKtenKH";
            this.txt_TKtenKH.Size = new System.Drawing.Size(180, 27);
            this.txt_TKtenKH.TabIndex = 3;
            this.txt_TKtenKH.Text = "Nhập Tên Khách Hàng";
            this.txt_TKtenKH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TKtenKH_MouseClick);
            this.txt_TKtenKH.TextChanged += new System.EventHandler(this.txt_TKtenKH_TextChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = global::QuanLyBanhang.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(385, 32);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 50);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_hoanTra
            // 
            this.btn_hoanTra.Image = global::QuanLyBanhang.Properties.Resources.pheduyet;
            this.btn_hoanTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoanTra.Location = new System.Drawing.Point(719, 32);
            this.btn_hoanTra.Name = "btn_hoanTra";
            this.btn_hoanTra.Size = new System.Drawing.Size(136, 50);
            this.btn_hoanTra.TabIndex = 1;
            this.btn_hoanTra.Text = "Hoàn Trả";
            this.btn_hoanTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hoanTra.UseVisualStyleBackColor = true;
            this.btn_hoanTra.Click += new System.EventHandler(this.btn_hoanTra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1029, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm hoàn trả";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txt_msp);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(43, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 50);
            this.panel4.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(259, 27);
            this.textBox1.TabIndex = 4;
            // 
            // txt_msp
            // 
            this.txt_msp.AutoSize = true;
            this.txt_msp.Location = new System.Drawing.Point(15, 8);
            this.txt_msp.Name = "txt_msp";
            this.txt_msp.Size = new System.Drawing.Size(102, 18);
            this.txt_msp.TabIndex = 2;
            this.txt_msp.Text = "Mã Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txt_dGia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(552, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 50);
            this.panel2.TabIndex = 10;
            // 
            // txt_dGia
            // 
            this.txt_dGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dGia.Location = new System.Drawing.Point(139, 12);
            this.txt_dGia.Name = "txt_dGia";
            this.txt_dGia.ReadOnly = true;
            this.txt_dGia.Size = new System.Drawing.Size(259, 27);
            this.txt_dGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Giá";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txt_sl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(552, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 50);
            this.panel1.TabIndex = 9;
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(139, 8);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.ReadOnly = true;
            this.txt_sl.Size = new System.Drawing.Size(259, 27);
            this.txt_sl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Lượng";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.date_nl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(43, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 40);
            this.panel3.TabIndex = 11;
            // 
            // date_nl
            // 
            this.date_nl.CustomFormat = "dd-MM-yyyy";
            this.date_nl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_nl.Location = new System.Drawing.Point(139, 10);
            this.date_nl.Name = "date_nl";
            this.date_nl.Size = new System.Drawing.Size(267, 27);
            this.date_nl.TabIndex = 3;
            this.date_nl.Value = new System.DateTime(2024, 5, 12, 22, 4, 22, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày mua";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.txt_tkh);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(552, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(429, 57);
            this.panel8.TabIndex = 10;
            // 
            // txt_tkh
            // 
            this.txt_tkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tkh.Location = new System.Drawing.Point(139, 8);
            this.txt_tkh.Name = "txt_tkh";
            this.txt_tkh.ReadOnly = true;
            this.txt_tkh.Size = new System.Drawing.Size(259, 27);
            this.txt_tkh.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Khách Hàng";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.txt_tsp);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(43, 158);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(421, 50);
            this.panel9.TabIndex = 9;
            // 
            // txt_tsp
            // 
            this.txt_tsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsp.Location = new System.Drawing.Point(148, 8);
            this.txt_tsp.Name = "txt_tsp";
            this.txt_tsp.ReadOnly = true;
            this.txt_tsp.Size = new System.Drawing.Size(259, 27);
            this.txt_tsp.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên Sản Phẩm";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.Controls.Add(this.txt_sp);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(43, 41);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(421, 50);
            this.panel10.TabIndex = 8;
            // 
            // txt_sp
            // 
            this.txt_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sp.Location = new System.Drawing.Point(148, 8);
            this.txt_sp.Name = "txt_sp";
            this.txt_sp.ReadOnly = true;
            this.txt_sp.Size = new System.Drawing.Size(259, 27);
            this.txt_sp.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số Phiếu";
            // 
            // HoanTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1029, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HoanTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoàn Trả Sản Phẩm";
            this.Load += new System.EventHandler(this.HoanTra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoanTra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_hoanTra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_hoanTra;
        private System.Windows.Forms.TextBox txt_TKtenKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker date_nl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tkh;
        private System.Windows.Forms.TextBox txt_tsp;
        private System.Windows.Forms.TextBox txt_sp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_dGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_msp;
    }
}