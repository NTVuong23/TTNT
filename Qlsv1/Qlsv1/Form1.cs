using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Qlsv1;  // Namespace của Entity Framework cho mô hình dữ liệu

namespace QLSV
{
    public partial class Form1 : Form
    {
        QLSVEntities2 db = new QLSVEntities2();

        public Form1()
        {
            InitializeComponent();
            db = new QLSVEntities2();
            InitializeFormState();
            dgvStudent.CellClick += dgvStudent_CellClick;
        }

        private void InitializeFormState()
        {
            List<string> faculties = db.Facultie.Select(f => f.FacultyName).ToList(); // Lấy danh sách tên khoa từ CSDL
            cmbFaculty.Items.Clear();
            cmbFaculty.Items.AddRange(faculties.ToArray());

            if (cmbFaculty.Items.Count > 0)
            {
                cmbFaculty.SelectedIndex = 0; // Chọn mục đầu tiên nếu có
            }
            else
            {
                MessageBox.Show("Không có khoa nào để chọn!"); // Thông báo nếu không có khoa
            }

            radioButton1.Checked = false; // Giới tính "Nam" không được chọn mặc định
            radioButton2.Checked = true; // Giới tính "Nữ" được chọn mặc định
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(); // Nạp dữ liệu từ CSDL lên DataGridView
        }

        private void LoadDataToDataGridView()
        {
            dgvStudent.Rows.Clear(); // Xóa dữ liệu cũ từ DataGridView

            // Lấy tất cả sinh viên từ CSDL
            var students = db.STUDENT.ToList();

            foreach (var student in students)
            {
                // Lưu ý: Giả sử FacultyID là khóa ngoại trong bảng STUDENT
                var faculty = db.Facultie.FirstOrDefault(f => f.FacultyID == student.FacultyID);
                var facultyName = faculty != null ? faculty.FacultyName : "Không xác định"; // Tránh NullReferenceException
                dgvStudent.Rows.Add(student.StudentID, student.FullName, student.Gender, student.AverageScore, facultyName);
            }
            UpdateGenderCount(); // Cập nhật số lượng sinh viên nam/nữ sau khi nạp dữ liệu
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtAverageScore.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                }

                // Kiểm tra điểm trung bình
                if (!float.TryParse(txtAverageScore.Text, out float averageScore) || averageScore < 0 || averageScore > 10)
                {
                    throw new Exception("Điểm trung bình không hợp lệ! (0 - 10)");
                }

                var existingStudent = db.STUDENT.FirstOrDefault(s => s.StudentID == txtStudentID.Text);

                if (existingStudent == null)
                {
                    // Thêm sinh viên mới
                    var selectedFaculty = db.Facultie.FirstOrDefault(f => f.FacultyName == cmbFaculty.Text);
                    if (selectedFaculty == null)
                    {
                        throw new Exception("Khoa không tồn tại!");
                    }

                    STUDENT newStudent = new STUDENT
                    {
                        StudentID = txtStudentID.Text,
                        FullName = txtFullName.Text,
                        Gender = radioButton1.Checked ? "Nam" : "Nữ",
                        AverageScore = averageScore,
                        FacultyID = selectedFaculty.FacultyID // Sử dụng FacultyID để liên kết
                    };

                    db.STUDENT.Add(newStudent);
                }
                else
                {
                    // Cập nhật thông tin sinh viên
                    existingStudent.FullName = txtFullName.Text;
                    existingStudent.Gender = radioButton1.Checked ? "Nam" : "Nữ";
                    existingStudent.AverageScore = averageScore;

                    var selectedFaculty = db.Facultie.FirstOrDefault(f => f.FacultyName == cmbFaculty.SelectedItem.ToString());
                    if (selectedFaculty != null)
                    {
                        existingStudent.FacultyID = selectedFaculty.FacultyID; // Cập nhật lại FacultyID
                    }
                }

                db.SaveChanges(); // Lưu các thay đổi vào CSDL
                LoadDataToDataGridView(); // Nạp lại dữ liệu sau khi thêm/cập nhật sinh viên
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStudentID.Text))
                {
                    throw new Exception("Vui lòng nhập MSSV cần xóa!");
                }

                var studentToDelete = db.STUDENT.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
                if (studentToDelete == null)
                {
                    throw new Exception("Không tìm thấy sinh viên cần xóa!");
                }

                DialogResult dr = MessageBox.Show("Bạn có muốn xóa sinh viên " + studentToDelete.FullName + "?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.STUDENT.Remove(studentToDelete);
                    db.SaveChanges();
                    LoadDataToDataGridView(); // Nạp lại dữ liệu sau khi xóa sinh viên
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
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
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedIndex = 0;
            radioButton1.Checked = false; // Đặt lại giới tính
            radioButton2.Checked = true; // Đặt lại giới tính
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtFullName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                string gender = selectedRow.Cells[2].Value?.ToString() ?? "Nam";
                radioButton1.Checked = (gender == "Nam");
                radioButton2.Checked = (gender == "Nữ");
                txtAverageScore.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                cmbFaculty.SelectedItem = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                UpdateGenderCount(); // Cập nhật số lượng sinh viên nam/nữ khi chọn hàng
            }
        }

        private void UpdateGenderCount()
        {
            int maleCount = dgvStudent.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[2].Value?.ToString() == "Nam");
            int femaleCount = dgvStudent.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[2].Value?.ToString() == "Nữ");

            textBox1.Text = maleCount.ToString();
            textBox2.Text = femaleCount.ToString();
        }
    }
}
