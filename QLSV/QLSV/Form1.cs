namespace QLSV
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            InitializeFormState();
            dgvStudent.CellClick += dgvStudent_CellClick;
        }

        private void InitializeFormState()
        {
            List<string> faculties = new List<string> { "QTKD", "CNTT", "NNA" };
            cmbFaculty.Items.Clear();
            foreach (var faculty in faculties)
            {
                if (!cmbFaculty.Items.Contains(faculty))
                {
                    cmbFaculty.Items.Add(faculty);
                }
            }
            cmbFaculty.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFormState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateGenderCount();
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = radioButton1.Checked ? "Nam" : "Nữ";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
            UpdateGenderCount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");

                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                        ClearInputFields();
                        UpdateGenderCount();    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearInputFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void dgvStudent_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số dòng hợp lệ
            {
                // Lấy thông tin sinh viên từ dòng đã chọn
                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtFullName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                string gender = selectedRow.Cells[2].Value?.ToString() ?? "Nam";
                radioButton1.Checked = (gender == "Nam");
                radioButton2.Checked = (gender == "Nữ");
                txtAverageScore.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                cmbFaculty.SelectedItem = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                UpdateGenderCount();
            }
        }

        private void UpdateGenderCount()
        {
            int maleCount = 0;
            int femaleCount = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string gender = row.Cells[2].Value?.ToString() ?? string.Empty;
                    if (gender == "Nam")
                        maleCount++;
                    else if (gender == "Nữ")
                        femaleCount++;
                }
            }   
            textBox1.Text = maleCount.ToString();
            textBox2.Text = femaleCount.ToString();
        }



        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
