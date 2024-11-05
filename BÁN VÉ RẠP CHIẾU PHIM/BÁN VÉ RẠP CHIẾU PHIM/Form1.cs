namespace BÁN_VÉ_RẠP_CHIẾU_PHIM
{
    public partial class Form1 : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int ThanhTien = 0;
        public Form1()
        {
            InitializeComponent();
            InitiaLizeFormState();
            textBox1.Enabled = false;
        }

        private void InitiaLizeFormState()
        {
            List<string> khuvuc = new List<string> { "TP.HCM", "DA NANG", "HANOI" };
            comboBox1.Items.Clear();
            foreach (var khuvuc1 in khuvuc)
            {
                if (!comboBox1.Items.Contains(khuvuc1))
                    comboBox1.Items.Add(khuvuc1);
            }
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Chức năng khác nếu cần
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chức năng khác nếu cần
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Chức năng khác nếu cần
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "YES/NO", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if (a <= 5)
                {
                    b.BackColor = Color.Yellow;
                    ThanhTien += 30000;
                }
                if (5 < a && a <= 10)
                {
                    b.BackColor = Color.Yellow;
                    ThanhTien += 40000;
                }
                if (10 < a && a <= 15)
                {
                    b.BackColor = Color.Yellow;
                    ThanhTien += 50000;
                }
                if (15 < a && a <= 20)
                {
                    b.BackColor = Color.Yellow;
                    ThanhTien += 80000;
                }
            }
            textBox1.Text = ThanhTien.ToString();
            ThanhTien = 0;
            DanhSachChon = new List<Button>();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
                else
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Kết nối sự kiện cho các nút
        private void button1_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button10_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button11_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button12_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button13_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button14_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button15_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button16_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button17_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button18_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button19_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button20_Click(object sender, EventArgs e) => button_Click(sender, e);

        private void button22_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            textBox1.Text = "";
            DanhSachChon = new List<Button>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

    }
}
