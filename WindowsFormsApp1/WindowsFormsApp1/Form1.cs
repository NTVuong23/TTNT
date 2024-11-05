using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QLSach
{
    public partial class Form1 : Form
    {
        QLSachEntities db = new QLSachEntities();
        public Form1()
        {
            InitializeComponent();
            db = new QLSachEntities();
            InitializeFormState();
            dgvBook.CellClick += dgvBook_CellClick;
            LoadDataToDataGridView();
        }
        private void InitializeFormState()
        {
            // Lấy danh sách thể loại sách từ CSDL
            List<string> categories = db.LoaiSach.Select(c => c.TenLoai).ToList();
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(categories.ToArray());

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không có thể loại sách nào để chọn!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(); // Nạp dữ liệu từ CSDL lên DataGridView
        }

        private void LoadDataToDataGridView()
        {
            dgvBook.Rows.Clear(); // Xóa dữ liệu cũ từ DataGridView

            // Lấy tất cả sách từ CSDL
            var books = db.Sach.ToList();

            foreach (var book in books)
            {
                // Lấy tên thể loại từ bảng Category
                var category = db.LoaiSach.FirstOrDefault(c => c.MaLoai == book.MaLoai);
                var categoryName = category != null ? category.TenLoai : "Không xác định"; // Tránh NullReferenceException
                dgvBook.Rows.Add(book.MaSach, book.TenSach, book.NamXB, categoryName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrEmpty(txtBookID.Text) || string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtYear.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sách!");
                }

                if (!int.TryParse(txtYear.Text, out int year) || year < 0)
                {
                    throw new Exception("Năm xuất bản không hợp lệ!");
                }

                var existingBook = db.Sach.FirstOrDefault(b => b.MaSach == txtBookID.Text);

                if (existingBook == null)
                {
                    var selectedCategory = db.LoaiSach.FirstOrDefault(c => c.TenLoai == cmbCategory.Text);
                    if (selectedCategory == null)
                    {
                        throw new Exception("Thể loại sách không tồn tại!");
                    }

                    // Tạo sách mới
                    Sach newBook = new Sach
                    {
                        MaSach = txtBookID.Text,
                        TenSach = txtBookName.Text,
                        NamXB = year,
                        MaLoai = selectedCategory.MaLoai
                    };

                    db.Sach.Add(newBook);
                }
                else
                {
                    // Cập nhật thông tin sách
                    existingBook.TenSach = txtBookName.Text;
                    existingBook.NamXB = year;

                    var selectedCategory = db.LoaiSach.FirstOrDefault(c => c.TenLoai == cmbCategory.SelectedItem.ToString());
                    if (selectedCategory != null)
                    {
                        existingBook.MaLoai = selectedCategory.MaLoai;
                    }
                }

                db.SaveChanges();
                LoadDataToDataGridView();
                MessageBox.Show("Cập nhật thông tin sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookID.Text))
                {
                    throw new Exception("Vui lòng nhập Mã Sách cần xóa!");
                }

                var bookToDelete = db.Sach.FirstOrDefault(b => b.MaSach == txtBookID.Text);
                if (bookToDelete == null)
                {
                    throw new Exception("Không tìm thấy sách cần xóa!");
                }

                DialogResult dr = MessageBox.Show("Bạn có muốn xóa sách " + bookToDelete.TenSach + "?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.Sach.Remove(bookToDelete);
                    db.SaveChanges();
                    LoadDataToDataGridView(); // Nạp lại dữ liệu sau khi xóa sách
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK);
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            txtBookID.Clear();
            txtBookName.Clear();
            txtYear.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBook.Rows[e.RowIndex];
                txtBookID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtBookName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtYear.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                cmbCategory.SelectedItem = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
            }
        }


        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }


        private void txtSearch_Leaave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.LightGray;
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchBook(txtSearch.Text);
        }

      


        private void SearchBook(string search)
        {
            var books = db.Sach.ToList();

            var fBooks = books.Where(b =>
                                b.MaSach.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                b.TenSach.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                b.NamXB.ToString().IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            dgvBook.Rows.Clear(); // Xóa dữ liệu cũ từ DataGridView

            foreach (var book in fBooks)
            {
                // Lấy tên thể loại từ bảng LoaiSach
                var category = db.LoaiSach.FirstOrDefault(c => c.MaLoai == book.MaLoai);
                var categoryName = category != null ? category.TenLoai : "Không xác định";
                dgvBook.Rows.Add(book.MaSach, book.TenSach, book.NamXB, categoryName);
            }
        }

        private void thốngKêSáchTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report frmrp = new report();
            frmrp.ShowDialog();
        }

       
    }
}
