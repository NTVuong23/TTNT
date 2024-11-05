namespace lab03_03
{
    partial class FormThemMoi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtMaSo = new TextBox();
            txtTen = new TextBox();
            txtDiem = new TextBox();
            comboBoxKhoa = new ComboBox();
            btnThem = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(178, 38);
            txtMaSo.Margin = new Padding(3, 4, 3, 4);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(222, 31);
            txtMaSo.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(178, 85);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(271, 31);
            txtTen.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(178, 191);
            txtDiem.Margin = new Padding(3, 4, 3, 4);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(96, 31);
            txtDiem.TabIndex = 2;
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Location = new Point(178, 141);
            comboBoxKhoa.Margin = new Padding(3, 4, 3, 4);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(271, 33);
            comboBoxKhoa.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(212, 251);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(111, 38);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(338, 251);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 38);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã số sinh viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 8;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 191);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 9;
            label4.Text = "Điểm TB";
            // 
            // FormThemMoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 312);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(comboBoxKhoa);
            Controls.Add(txtDiem);
            Controls.Add(txtTen);
            Controls.Add(txtMaSo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormThemMoi";
            Text = "Thêm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSo;
        private TextBox txtTen;
        private TextBox txtDiem;
        private ComboBox comboBoxKhoa;
        private Button btnThem;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
