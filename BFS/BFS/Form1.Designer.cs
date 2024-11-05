using System;

namespace BFS
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

        private void InitializeComponent()
        {
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnTraverse = new System.Windows.Forms.Button();
            this.lblResultDFS = new System.Windows.Forms.Label();
            this.lblResultBFS = new System.Windows.Forms.Label();
            this.txtStartVertex = new System.Windows.Forms.TextBox();
            this.txtEndVertex = new System.Windows.Forms.TextBox();
            this.lblStepsDFS = new System.Windows.Forms.Label();
            this.lblStepsBFS = new System.Windows.Forms.Label();
            this.lblTimeDFS = new System.Windows.Forms.Label();
            this.lblTimeBFS = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddEdge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdge.Location = new System.Drawing.Point(488, 4);
            this.btnAddEdge.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(129, 40);
            this.btnAddEdge.TabIndex = 0;
            this.btnAddEdge.Text = "Thêm Cạnh";
            this.btnAddEdge.UseVisualStyleBackColor = false;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnTraverse
            // 
            this.btnTraverse.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTraverse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraverse.ForeColor = System.Drawing.Color.Black;
            this.btnTraverse.Location = new System.Drawing.Point(623, 4);
            this.btnTraverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraverse.Name = "btnTraverse";
            this.btnTraverse.Size = new System.Drawing.Size(129, 40);
            this.btnTraverse.TabIndex = 1;
            this.btnTraverse.Text = "Duyệt Đồ Thị";
            this.btnTraverse.UseVisualStyleBackColor = false;
            this.btnTraverse.Click += new System.EventHandler(this.btnTraverse_Click);
            // 
            // lblResultDFS
            // 
            this.lblResultDFS.AutoEllipsis = true;
            this.lblResultDFS.AutoSize = true;
            this.lblResultDFS.BackColor = System.Drawing.Color.White;
            this.lblResultDFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultDFS.Location = new System.Drawing.Point(0, 4);
            this.lblResultDFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultDFS.Name = "lblResultDFS";
            this.lblResultDFS.Size = new System.Drawing.Size(118, 21);
            this.lblResultDFS.TabIndex = 2;
            this.lblResultDFS.Text = "Kết quả DFS: ";
            // 
            // lblResultBFS
            // 
            this.lblResultBFS.AutoSize = true;
            this.lblResultBFS.BackColor = System.Drawing.Color.White;
            this.lblResultBFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultBFS.Location = new System.Drawing.Point(-1, 71);
            this.lblResultBFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultBFS.Name = "lblResultBFS";
            this.lblResultBFS.Size = new System.Drawing.Size(115, 21);
            this.lblResultBFS.TabIndex = 2;
            this.lblResultBFS.Text = "Kết quả BFS: ";
            // 
            // txtStartVertex
            // 
            this.txtStartVertex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartVertex.ForeColor = System.Drawing.Color.Gray;
            this.txtStartVertex.Location = new System.Drawing.Point(490, 106);
            this.txtStartVertex.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartVertex.Name = "txtStartVertex";
            this.txtStartVertex.Size = new System.Drawing.Size(127, 30);
            this.txtStartVertex.TabIndex = 4;
            this.txtStartVertex.Text = "Đỉnh bắt đầu";
            this.txtStartVertex.Enter += new System.EventHandler(this.txtStartVertex_Enter);
            this.txtStartVertex.Leave += new System.EventHandler(this.txtStartVertex_Leave);
            // 
            // txtEndVertex
            // 
            this.txtEndVertex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndVertex.ForeColor = System.Drawing.Color.Gray;
            this.txtEndVertex.Location = new System.Drawing.Point(625, 106);
            this.txtEndVertex.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndVertex.Name = "txtEndVertex";
            this.txtEndVertex.Size = new System.Drawing.Size(127, 30);
            this.txtEndVertex.TabIndex = 5;
            this.txtEndVertex.Text = "Đỉnh kết thúc";
            this.txtEndVertex.Enter += new System.EventHandler(this.txtEndVertex_Enter);
            this.txtEndVertex.Leave += new System.EventHandler(this.txtEndVertex_Leave);
            // 
            // lblStepsDFS
            // 
            this.lblStepsDFS.AutoSize = true;
            this.lblStepsDFS.BackColor = System.Drawing.Color.White;
            this.lblStepsDFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStepsDFS.Location = new System.Drawing.Point(0, 23);
            this.lblStepsDFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsDFS.Name = "lblStepsDFS";
            this.lblStepsDFS.Size = new System.Drawing.Size(117, 21);
            this.lblStepsDFS.TabIndex = 6;
            this.lblStepsDFS.Text = "Số bước DFS: ";
            // 
            // lblStepsBFS
            // 
            this.lblStepsBFS.AutoSize = true;
            this.lblStepsBFS.BackColor = System.Drawing.Color.White;
            this.lblStepsBFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStepsBFS.Location = new System.Drawing.Point(-1, 92);
            this.lblStepsBFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsBFS.Name = "lblStepsBFS";
            this.lblStepsBFS.Size = new System.Drawing.Size(114, 21);
            this.lblStepsBFS.TabIndex = 7;
            this.lblStepsBFS.Text = "Số bước BFS: ";
            // 
            // lblTimeDFS
            // 
            this.lblTimeDFS.AutoSize = true;
            this.lblTimeDFS.BackColor = System.Drawing.Color.White;
            this.lblTimeDFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeDFS.Location = new System.Drawing.Point(-1, 44);
            this.lblTimeDFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeDFS.Name = "lblTimeDFS";
            this.lblTimeDFS.Size = new System.Drawing.Size(129, 21);
            this.lblTimeDFS.TabIndex = 8;
            this.lblTimeDFS.Text = "Thời gian DFS: ";
            // 
            // lblTimeBFS
            // 
            this.lblTimeBFS.AutoSize = true;
            this.lblTimeBFS.BackColor = System.Drawing.Color.White;
            this.lblTimeBFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeBFS.Location = new System.Drawing.Point(0, 115);
            this.lblTimeBFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeBFS.Name = "lblTimeBFS";
            this.lblTimeBFS.Size = new System.Drawing.Size(126, 21);
            this.lblTimeBFS.TabIndex = 9;
            this.lblTimeBFS.Text = "Thời gian BFS: ";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(550, 52);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 40);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSaveImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImage.Location = new System.Drawing.Point(4, 4);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(129, 40);
            this.btnSaveImage.TabIndex = 11;
            this.btnSaveImage.Text = "Save Picture";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.btnSaveImage);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(624, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 93);
            this.panel1.TabIndex = 12;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SkyBlue;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(5, 50);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 40);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTimeBFS);
            this.panel2.Controls.Add(this.btnAddEdge);
            this.panel2.Controls.Add(this.lblStepsBFS);
            this.panel2.Controls.Add(this.txtStartVertex);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.lblResultDFS);
            this.panel2.Controls.Add(this.btnTraverse);
            this.panel2.Controls.Add(this.lblTimeDFS);
            this.panel2.Controls.Add(this.lblResultBFS);
            this.panel2.Controls.Add(this.txtEndVertex);
            this.panel2.Controls.Add(this.lblStepsDFS);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 140);
            this.panel2.TabIndex = 13;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(6, 152);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(615, 370);
            this.drawingPanel.TabIndex = 14;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint_1);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(771, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drawingPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ Thị BFS/DFS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnTraverse;
        private System.Windows.Forms.Label lblResultDFS;
        private System.Windows.Forms.Label lblResultBFS;
        private System.Windows.Forms.TextBox txtStartVertex;
        private System.Windows.Forms.TextBox txtEndVertex;
        private System.Windows.Forms.Label lblStepsDFS;
        private System.Windows.Forms.Label lblStepsBFS;
        private System.Windows.Forms.Label lblTimeDFS;
        private System.Windows.Forms.Label lblTimeBFS;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel drawingPanel;
    }
}
