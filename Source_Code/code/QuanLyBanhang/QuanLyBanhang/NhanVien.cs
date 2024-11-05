using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private string sql;
        private void loaddata()
        {
            sql = "select * from NhanVien";
            dgv_nhanvien.DataSource = Function.GetDataTable(sql);
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            txtHoTen.Focus();
        }
        private void ClearTextBox()
        {
            Random random = new Random();
            string manv;
            manv = "NV" + random.Next(1, 999).ToString();
            txtMaNhanVien.Text = manv;
            txtHoTen.Text = "";
            txtTuoi.Text = "";
            cb_gioitinh.Text = "Nam";
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from NhanVien where ma_nv='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text.Trim();
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnSua.Text = "Lưu";
                btnLammoi.Enabled = false;
                btnXoa.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_TKtenKH.Enabled = false;

            }
            else if (btnThem.Text == "Lưu")
            {
                if (!int.TryParse(txtHoTen.Text, out _))
                {
                    if (int.TryParse(txtTuoi.Text, out _))
                    {
                        sql = "update NhanVien set ten=N'" + txtHoTen.Text + "', tuoi=N'" + txtTuoi.Text + "', gioi_tinh=N'" +cb_gioitinh.Text + "',ngay_nViec='"+ dateNgayNV.Value.ToString("yyyy-MM-dd") + "' where ma_nv='" + ma + "'";
                        Function.ExecuteNonQuery(sql);
                        loaddata();
                        ClearTextBox();
                        txtHoTen.Focus();
                        MessageBox.Show("Sua Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số cho tuổi", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chữ cái", "Thông báo");
                }
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_TKtenKH.Enabled = true;
                ClearTextBox();
                txtHoTen.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text.Trim();
            if (btnSua.Text == "Sửa")
            {
                btnThem.Text = "Lưu";
                btnSua.Text = "Hủy";
                btnXoa.Enabled = false;
                btnLammoi.Enabled = false;
                btn_timkiem.Enabled= false;
                txt_TKtenKH.Enabled= false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!checkID(ma))
                {
                    if (!int.TryParse(txtHoTen.Text, out _))
                    {
                        if(int.TryParse(txtTuoi.Text, out _))
                        { 
                            sql = "insert into NhanVien values('" + txtMaNhanVien.Text + "',N'" + txtHoTen.Text + "','" + txtTuoi.Text + "',N'" +cb_gioitinh.Text + "','"+dateNgayNV.Value.ToString("yyyy-MM-dd")+"')";
                            Function.ExecuteNonQuery(sql);
                            MessageBox.Show("Them Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                            loaddata();
                            ClearTextBox();
                            txtHoTen.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số cho tuổi", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập chữ cái cho họ tên", "Thông báo");
                    }
                }

                else
                {
                    MessageBox.Show("Nhan Vien Da Ton Tai!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_TKtenKH.Enabled = true;
                ClearTextBox();
                txtHoTen.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "delete NhanVien where ma_nv='" + txtMaNhanVien.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
            }
        }

        private void dgv_nhanvien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nhanvien.CurrentRow != null)
            {
                txtMaNhanVien.Text = dgv_nhanvien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgv_nhanvien.CurrentRow.Cells[1].Value.ToString();
                txtTuoi.Text = dgv_nhanvien.CurrentRow.Cells[2].Value.ToString();
                cb_gioitinh.Text = dgv_nhanvien.CurrentRow.Cells[3].Value.ToString();
                dateNgayNV.Text = dgv_nhanvien.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
            dgv_nhanvien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_nhanvien.Columns[1].HeaderText = "Họ Tên";
            dgv_nhanvien.Columns[2].HeaderText = "Tuổi";
            dgv_nhanvien.Columns[3].HeaderText = "Giới Tính";
            dgv_nhanvien.Columns[4].HeaderText = "Ngày Nhận Việc";
            dgv_nhanvien.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenKH.Text=="")
            {
                loaddata();
            }
            else
            {
                sql = "select * from NhanVien where ten like N'%"+txt_TKtenKH.Text+"%'";
                dgv_nhanvien.DataSource = Function.GetDataTable(sql);
            }
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenKH.Clear();
        }
    }
}
