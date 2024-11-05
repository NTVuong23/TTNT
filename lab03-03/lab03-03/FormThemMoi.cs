using System;
using System.Windows.Forms;

namespace lab03_03
{
    public partial class FormThemMoi : Form
    {
        public string MaSo { get; private set; }
        public string Ten { get; private set; }
        public string Khoa { get; private set; }
        public double Diem { get; private set; }

        public FormThemMoi()
        {
            InitializeComponent();
            // Thêm các khoa vào ComboBox
            comboBoxKhoa.Items.AddRange(new string[] { "CNTT", "NNA", "QTKD" });
            comboBoxKhoa.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Logic để xử lý thoát form
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm hợp lệ
            if (!double.TryParse(txtDiem.Text, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu dữ liệu vào các biến public
            MaSo = txtMaSo.Text;
            Ten = txtTen.Text;

            // Gán giá trị cho Khoa và kiểm tra null
            Khoa = comboBoxKhoa.SelectedItem?.ToString(); // Sử dụng cú pháp điều kiện null

            // Kiểm tra xem Khoa có phải là null không
            if (Khoa == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Diem = diem;

            // Trả về OK khi thông tin hợp lệ
            DialogResult = DialogResult.OK;
            this.Close(); // Đóng form sau khi xác nhận
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
