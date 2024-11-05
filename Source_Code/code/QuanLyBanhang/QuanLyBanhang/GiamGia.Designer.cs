namespace QuanLyBanhang
{
    partial class GiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ptGiam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_loaihang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_giam = new System.Windows.Forms.Button();
            this.btn_tang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txt_ptGiam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 51);
            this.panel1.TabIndex = 13;
            // 
            // txt_ptGiam
            // 
            this.txt_ptGiam.Location = new System.Drawing.Point(171, 10);
            this.txt_ptGiam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ptGiam.MaxLength = 100;
            this.txt_ptGiam.Name = "txt_ptGiam";
            this.txt_ptGiam.Size = new System.Drawing.Size(290, 27);
            this.txt_ptGiam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần Trăm Giảm";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.cb_loaihang);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(34, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 51);
            this.panel5.TabIndex = 12;
            // 
            // cb_loaihang
            // 
            this.cb_loaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaihang.FormattingEnabled = true;
            this.cb_loaihang.Location = new System.Drawing.Point(165, 10);
            this.cb_loaihang.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loaihang.Name = "cb_loaihang";
            this.cb_loaihang.Size = new System.Drawing.Size(296, 28);
            this.cb_loaihang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_giam);
            this.panel2.Controls.Add(this.btn_tang);
            this.panel2.Location = new System.Drawing.Point(552, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 190);
            this.panel2.TabIndex = 1;
            // 
            // btn_giam
            // 
            this.btn_giam.Location = new System.Drawing.Point(29, 115);
            this.btn_giam.Name = "btn_giam";
            this.btn_giam.Size = new System.Drawing.Size(105, 39);
            this.btn_giam.TabIndex = 1;
            this.btn_giam.Text = "Giảm Giá";
            this.btn_giam.UseVisualStyleBackColor = true;
            this.btn_giam.Click += new System.EventHandler(this.btn_giam_Click);
            // 
            // btn_tang
            // 
            this.btn_tang.Location = new System.Drawing.Point(29, 32);
            this.btn_tang.Name = "btn_tang";
            this.btn_tang.Size = new System.Drawing.Size(105, 39);
            this.btn_tang.TabIndex = 0;
            this.btn_tang.Text = "Tăng Giá";
            this.btn_tang.UseVisualStyleBackColor = true;
            this.btn_tang.Click += new System.EventHandler(this.btn_tang_Click);
            // 
            // GiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(729, 214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GiamGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Giá";
            this.Load += new System.EventHandler(this.GiamGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ptGiam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cb_loaihang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_giam;
        private System.Windows.Forms.Button btn_tang;
    }
}