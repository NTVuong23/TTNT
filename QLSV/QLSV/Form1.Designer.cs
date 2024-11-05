namespace QLSV
{
    partial class Form1
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
            label1 = new Label();
            dgvStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbFaculty = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtAverageScore = new TextBox();
            txtFullName = new TextBox();
            txtStudentID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 96);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Thông Tin Sinh Viên\r\n";
            label1.Click += label1_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToOrderColumns = true;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvStudent.Location = new Point(419, 78);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(717, 313);
            dgvStudent.TabIndex = 1;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 60F;
            dataGridViewTextBoxColumn1.HeaderText = "MSSV";
            dataGridViewTextBoxColumn1.MaxInputLength = 30000;
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Giới Tính";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ĐTB";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Khoa";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 345);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 46);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Thêm/ Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(278, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbFaculty
            // 
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(161, 212);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(217, 33);
            cmbFaculty.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(txtAverageScore);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbFaculty);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 274);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(242, 129);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 29);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(161, 129);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtAverageScore
            // 
            txtAverageScore.Location = new Point(161, 173);
            txtAverageScore.Name = "txtAverageScore";
            txtAverageScore.Size = new Size(89, 31);
            txtAverageScore.TabIndex = 14;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(161, 80);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(217, 31);
            txtFullName.TabIndex = 13;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(161, 40);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 31);
            txtStudentID.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 217);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 11;
            label6.Text = "Chuyên Ngành";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 179);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 10;
            label5.Text = "Điểm TB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 129);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 9;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 80);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 8;
            label3.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 43);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 7;
            label2.Text = "Mã Sinh Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(781, 406);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 9;
            label7.Text = "Tổng SV Nam";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(909, 403);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 31);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1047, 403);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 31);
            textBox2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1005, 406);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 12;
            label8.Text = "Nữ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 450);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(dgvStudent);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvStudent;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmbFaculty;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAverageScore;
        private TextBox txtFullName;
        private TextBox txtStudentID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label8;
    }
}
