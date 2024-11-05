using System;
using System.Windows.Forms;

namespace lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thêm sự kiện cho các menu và nút bấm
            thêmMớiToolStripMenuItem.Click += new EventHandler(ThêmMớiToolStripMenuItem_Click);
            thoátToolStripMenuItem.Click += new EventHandler(ThoátToolStripMenuItem_Click);
            toolStripButton1.Click += new EventHandler(ThêmMớiToolStripMenuItem_Click);
            toolStripTextBox1.TextChanged += new EventHandler(TimKiem_TextChanged);

            // Thêm cột cho DataGridView nếu chưa có
            dataGridView1.Columns.Add("MaSo", "Mã số");
            dataGridView1.Columns.Add("Ten", "Tên sinh viên");
            dataGridView1.Columns.Add("Khoa", "Khoa");
            dataGridView1.Columns.Add("Diem", "Điểm");
        }

        private void ThêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemMoi formThemMoi = new FormThemMoi();
            if (formThemMoi.ShowDialog() == DialogResult.OK)
            {
                // Kiểm tra mã số sinh viên trùng
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaSo"].Value != null && row.Cells["MaSo"].Value.ToString() == formThemMoi.MaSo)
                    {
                        MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thêm sinh viên vào DataGridView
                dataGridView1.Rows.Add(formThemMoi.MaSo, formThemMoi.Ten, formThemMoi.Khoa, formThemMoi.Diem);
            }
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {


        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value?.ToString() == toolStripTextBox1_Click)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}
