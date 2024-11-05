using System;
using System.Windows.Forms;
using System.Drawing;


namespace QuanLyBanhang
{
    public partial class NhaCungCap : Form
    {
        private string sql;
        public NhaCungCap()
        {
            InitializeComponent();
 
        }
        private void loaddata()
        {
            sql = "select * from NhaCungCap";
            dgv_nhacc.DataSource = Function.GetDataTable(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnSua.Text = "Lưu";
                btnLammoi.Enabled = false;
                btnXoa.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_tk.Enabled = false;
            }
            else if (btnThem.Text == "Lưu")
            {

                sql = "update NhaCungCap set ten_ct=N'" + txtTenNCC.Text + "', dia_chi=N'" + txtDiaChi.Text + "', sdt='" + txtSoDienThoai.Text + "' where ma_nhacc='" + ma + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
                ClearTextBox();
                txtTenNCC.Focus();
                MessageBox.Show("Sua Thanh Cong", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                txt_tk.Enabled = true;
                btn_timkiem.Enabled=true;
                ClearTextBox();
                txtTenNCC.Focus();
            }
        }
        private void ClearTextBox()
        {
            Random random = new Random();
            string manhacc;
            manhacc = "CT" + random.Next(1, 999).ToString();
            txtMaNCC.Text = manhacc;
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }
        private bool checkID(string ma)
        {
            sql="select count(*) from NhaCungCap where ma_nhacc='"+ma+"'";
            int kq = Convert.ToInt32 (Function.ExecuteScalar(sql));
            return kq > 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();
            if (btnSua.Text == "Sửa")
            {
                btnThem.Text = "Lưu";
                btnSua.Text = "Hủy";
                btnXoa.Enabled = false;
                btnLammoi.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_tk.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!checkID(ma))
                {
                    sql = "insert into NhaCungCap values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "','" + txtSoDienThoai.Text + "')";
                    Function.ExecuteNonQuery(sql);
                    MessageBox.Show("Them Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                    loaddata();
                    ClearTextBox();
                    txtTenNCC.Focus();
                }

                else
                {
                    MessageBox.Show("Nha Cung Cap Da Ton Tai!!", "Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled=true;
                btn_timkiem.Enabled=true;
                txt_tk.Enabled=true;
                ClearTextBox();
                txtTenNCC.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq==DialogResult.Yes) {
                sql = "delete NhaCungCap where ma_nhacc='" + txtMaNCC.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {          
            dgv_nhacc.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgv_nhacc.Columns[1].HeaderText = "Tên Công Ty";
            dgv_nhacc.Columns[2].HeaderText = "Địa Chỉ";
            dgv_nhacc.Columns[3].HeaderText = "SDT";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            txtTenNCC.Focus();
        }

        private void NhaCungCap_Load_1(object sender, EventArgs e)
        {
            loaddata();
            dgv_nhacc.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgv_nhacc.Columns[1].HeaderText = "Tên Công Ty";
            dgv_nhacc.Columns[2].HeaderText = "Địa Chỉ";
            dgv_nhacc.Columns[3].HeaderText = "SDT";
        }

        private void dgv_nhacc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_nhacc.CurrentRow != null)
            {
               txtMaNCC.Text = dgv_nhacc.CurrentRow.Cells[0].Value.ToString();
               txtTenNCC.Text = dgv_nhacc.CurrentRow.Cells[1].Value.ToString();
               txtDiaChi.Text = dgv_nhacc.CurrentRow.Cells[2].Value.ToString();
               txtSoDienThoai.Text = dgv_nhacc.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void NhaCungCap_Resize(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "select * from NhaCungCap where ten_ct like '%"+txt_tk.Text+"%'";
                dgv_nhacc.DataSource = Function.GetDataTable(sql);
            }
        }

        private void txt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tk.Clear();
        }
    }
}
