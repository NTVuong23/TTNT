using System.Drawing;

namespace NPuzzleAI
{
    partial class Form1
    {
        private System.Windows.Forms.PictureBox imgCanvas;
        private System.Windows.Forms.RadioButton goal1;
        private System.Windows.Forms.RadioButton goal2;
        private System.Windows.Forms.PictureBox goal1Image;
        private System.Windows.Forms.PictureBox goal2Image;
        private System.Windows.Forms.GroupBox goalGroup;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.TextBox stepField;
        private System.Windows.Forms.ProgressBar progressBar;

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgCanvas = new System.Windows.Forms.PictureBox();
            this.goal1 = new System.Windows.Forms.RadioButton();
            this.goal2 = new System.Windows.Forms.RadioButton();
            this.goal1Image = new System.Windows.Forms.PictureBox();
            this.goal2Image = new System.Windows.Forms.PictureBox();
            this.goalGroup = new System.Windows.Forms.GroupBox();
            this.addImage = new System.Windows.Forms.Button();
            this.stepField = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.algorithmMenu = new System.Windows.Forms.ComboBox();
            this.solveBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.jumbleBtn = new System.Windows.Forms.Button();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.sizeMenu = new System.Windows.Forms.ComboBox();
            this.addNumber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepLabel = new System.Windows.Forms.Label();
            this.displayPane = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2Image)).BeginInit();
            this.goalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.displayPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCanvas
            // 
            this.imgCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.imgCanvas.Location = new System.Drawing.Point(1, 0);
            this.imgCanvas.Name = "imgCanvas";
            this.imgCanvas.Size = new System.Drawing.Size(400, 400);
            this.imgCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCanvas.TabIndex = 0;
            this.imgCanvas.TabStop = false;
            // 
            // goal1
            // 
            this.goal1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.goal1.Location = new System.Drawing.Point(36, 44);
            this.goal1.Name = "goal1";
            this.goal1.Size = new System.Drawing.Size(89, 30);
            this.goal1.TabIndex = 1;
            this.goal1.TabStop = true;
            // 
            // goal2
            // 
            this.goal2.Location = new System.Drawing.Point(166, 44);
            this.goal2.Name = "goal2";
            this.goal2.Size = new System.Drawing.Size(100, 30);
            this.goal2.TabIndex = 2;
            this.goal2.TabStop = true;
            // 
            // goal1Image
            // 
            this.goal1Image.BackColor = System.Drawing.SystemColors.Control;
            this.goal1Image.Location = new System.Drawing.Point(36, 74);
            this.goal1Image.Name = "goal1Image";
            this.goal1Image.Size = new System.Drawing.Size(100, 100);
            this.goal1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goal1Image.TabIndex = 3;
            this.goal1Image.TabStop = false;
            // 
            // goal2Image
            // 
            this.goal2Image.BackColor = System.Drawing.SystemColors.Control;
            this.goal2Image.Location = new System.Drawing.Point(166, 74);
            this.goal2Image.Name = "goal2Image";
            this.goal2Image.Size = new System.Drawing.Size(100, 100);
            this.goal2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goal2Image.TabIndex = 4;
            this.goal2Image.TabStop = false;
            // 
            // goalGroup
            // 
            this.goalGroup.BackColor = System.Drawing.Color.LightPink;
            this.goalGroup.Controls.Add(this.goal1Image);
            this.goalGroup.Controls.Add(this.goal1);
            this.goalGroup.Controls.Add(this.goal2);
            this.goalGroup.Controls.Add(this.goal2Image);
            this.goalGroup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalGroup.Location = new System.Drawing.Point(476, 12);
            this.goalGroup.Name = "goalGroup";
            this.goalGroup.Size = new System.Drawing.Size(300, 200);
            this.goalGroup.TabIndex = 5;
            this.goalGroup.TabStop = false;
            this.goalGroup.Text = "Đích";
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.Color.LightPink;
            this.addImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImage.Location = new System.Drawing.Point(103, 3);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(105, 30);
            this.addImage.TabIndex = 8;
            this.addImage.Text = "Thêm ảnh";
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // stepField
            // 
            this.stepField.BackColor = System.Drawing.Color.LightPink;
            this.stepField.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepField.Location = new System.Drawing.Point(194, 30);
            this.stepField.Name = "stepField";
            this.stepField.ReadOnly = true;
            this.stepField.Size = new System.Drawing.Size(106, 30);
            this.stepField.TabIndex = 15;
            this.stepField.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(119, 494);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(219, 29);
            this.progressBar.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(56, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.addImage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(476, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 243);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.stepLabel);
            this.panel3.Controls.Add(this.stepField);
            this.panel3.Controls.Add(this.displayPane);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 616);
            this.panel3.TabIndex = 22;
            // 
            // algorithmMenu
            // 
            this.algorithmMenu.Items.AddRange(new object[] {
            "DFS",
            "BFS",
            "A* H1",
            "A* H2",
            "A* H3",
            "A* H4",
            "A* H5",
            "A* H6"});
            this.algorithmMenu.Location = new System.Drawing.Point(130, 115);
            this.algorithmMenu.Name = "algorithmMenu";
            this.algorithmMenu.Size = new System.Drawing.Size(94, 28);
            this.algorithmMenu.TabIndex = 13;
            this.algorithmMenu.SelectedIndexChanged += new System.EventHandler(this.algorithmMenu_SelectedIndexChanged);
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.Color.LightPink;
            this.solveBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.Location = new System.Drawing.Point(237, 27);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(96, 30);
            this.solveBtn.TabIndex = 7;
            this.solveBtn.Text = "AI Giải";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.LightPink;
            this.playBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(237, 69);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(96, 34);
            this.playBtn.TabIndex = 11;
            this.playBtn.Text = "Chơi";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // jumbleBtn
            // 
            this.jumbleBtn.BackColor = System.Drawing.Color.LightPink;
            this.jumbleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumbleBtn.Location = new System.Drawing.Point(130, 27);
            this.jumbleBtn.Name = "jumbleBtn";
            this.jumbleBtn.Size = new System.Drawing.Size(94, 30);
            this.jumbleBtn.TabIndex = 6;
            this.jumbleBtn.Text = "Trộn";
            this.jumbleBtn.UseVisualStyleBackColor = false;
            this.jumbleBtn.Click += new System.EventHandler(this.jumbleBtn_Click);
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.BackColor = System.Drawing.Color.LightPink;
            this.algorithmLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmLabel.Location = new System.Drawing.Point(6, 116);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(107, 27);
            this.algorithmLabel.TabIndex = 18;
            this.algorithmLabel.Text = "Thuật toán";
            // 
            // compareBtn
            // 
            this.compareBtn.BackColor = System.Drawing.Color.LightPink;
            this.compareBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareBtn.Location = new System.Drawing.Point(237, 114);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(96, 30);
            this.compareBtn.TabIndex = 10;
            this.compareBtn.Text = "So sánh";
            this.compareBtn.UseVisualStyleBackColor = false;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.BackColor = System.Drawing.Color.LightPink;
            this.difficultyLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(6, 73);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(107, 30);
            this.difficultyLabel.TabIndex = 17;
            this.difficultyLabel.Text = "Độ khó";
            // 
            // sizeMenu
            // 
            this.sizeMenu.Items.AddRange(new object[] {
            "Dễ",
            "T.Bình",
            "Khó"});
            this.sizeMenu.Location = new System.Drawing.Point(130, 73);
            this.sizeMenu.Name = "sizeMenu";
            this.sizeMenu.Size = new System.Drawing.Size(94, 28);
            this.sizeMenu.TabIndex = 12;
            // 
            // addNumber
            // 
            this.addNumber.BackColor = System.Drawing.Color.LightPink;
            this.addNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNumber.Location = new System.Drawing.Point(6, 27);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(107, 31);
            this.addNumber.TabIndex = 9;
            this.addNumber.Text = "Bảng số";
            this.addNumber.UseVisualStyleBackColor = false;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrchid;
            this.groupBox1.Controls.Add(this.addNumber);
            this.groupBox1.Controls.Add(this.sizeMenu);
            this.groupBox1.Controls.Add(this.jumbleBtn);
            this.groupBox1.Controls.Add(this.algorithmMenu);
            this.groupBox1.Controls.Add(this.algorithmLabel);
            this.groupBox1.Controls.Add(this.difficultyLabel);
            this.groupBox1.Controls.Add(this.playBtn);
            this.groupBox1.Controls.Add(this.solveBtn);
            this.groupBox1.Controls.Add(this.compareBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(449, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 161);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // stepLabel
            // 
            this.stepLabel.BackColor = System.Drawing.Color.LightPink;
            this.stepLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.Location = new System.Drawing.Point(134, 30);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(54, 30);
            this.stepLabel.TabIndex = 14;
            this.stepLabel.Text = "Bước";
            // 
            // displayPane
            // 
            this.displayPane.Controls.Add(this.imgCanvas);
            this.displayPane.Location = new System.Drawing.Point(15, 69);
            this.displayPane.Name = "displayPane";
            this.displayPane.Size = new System.Drawing.Size(400, 400);
            this.displayPane.TabIndex = 16;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.goalGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Trò chơi ghép hình AI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2Image)).EndInit();
            this.goalGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.displayPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox algorithmMenu;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button jumbleBtn;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.ComboBox sizeMenu;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Panel displayPane;
    }
}
