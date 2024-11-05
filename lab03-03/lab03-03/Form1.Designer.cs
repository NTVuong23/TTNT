namespace lab03_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            chucToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            MaSo = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            toolStripTextBox2 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chucToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(889, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chucToolStripMenuItem
            // 
            chucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chucToolStripMenuItem.Name = "chucToolStripMenuItem";
            chucToolStripMenuItem.Size = new Size(113, 29);
            chucToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(194, 34);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(194, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripTextBox1, toolStripTextBox2 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(889, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "Thêm mới";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(222, 33);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSo, Ten, Khoa, Diem });
            dataGridView1.Location = new Point(13, 86);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(862, 461);
            dataGridView1.TabIndex = 2;
            // 
            // MaSo
            // 
            MaSo.HeaderText = "Mã số";
            MaSo.MinimumWidth = 8;
            MaSo.Name = "MaSo";
            MaSo.Width = 150;
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 8;
            Ten.Name = "Ten";
            Ten.Width = 150;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 8;
            Khoa.Name = "Khoa";
            Khoa.Width = 150;
            // 
            // Diem
            // 
            Diem.HeaderText = "Điểm";
            Diem.MinimumWidth = 8;
            Diem.Name = "Diem";
            Diem.Width = 150;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 33);
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chucToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn Diem;
        private ToolStripTextBox toolStripTextBox2;
    }
}
