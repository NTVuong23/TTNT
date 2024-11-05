using Microsoft.Office.Interop.Word;
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
    public partial class KhachHangcs : Form
    {
        private string sql;
        public KhachHangcs()
        {
            InitializeComponent();
            cb_gioitinh.Text = "Nam";
        }
        private void loaddata()
        {
            sql = "select * from KhachHang";
            dgv_khachhang.DataSource = Function.GetDataTable(sql);
        }
        private void KhachHangcs_Load(object sender, EventArgs e)
        {
            loaddata();
            dgv_khachhang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgv_khachhang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgv_khachhang.Columns[2].HeaderText = "Giới Tính";
            dgv_khachhang.Columns[3].HeaderText = "Địa Chỉ";
            dgv_khachhang.Columns[4].HeaderText = "SDT";
        }
        private void ClearTextBox()
        {
            Random random = new Random();
            string makh;
            makh = "KH" + random.Next(1, 999).ToString();
            txtMaKhachHang.Text = makh;
            txtHoTen.Text = "";
            txt_diachi.Text = "";
            txtSoDienThoai.Text = "";
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            txtHoTen.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
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
                if (Regex.IsMatch(txtHoTen.Text.Trim(), @"^[a-zA-Z]+$")) 
                { 
                    sql = "update KhachHang set ten=N'" + txtHoTen.Text + "', gioi_tinh=N'" + cb_gioitinh.Text + "',dia_chi=N'" + txt_diachi.Text + "', sdt='" + txtSoDienThoai.Text + "' where ma_kh='" + txtMaKhachHang.Text+ "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    ClearTextBox();
                    txtHoTen.Focus();
                    MessageBox.Show("Sua Thanh Cong", "Thong bao", MessageBoxButtons.OK);
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
                btn_timkiem.Enabled=true;
                txt_tk.Enabled = true;
                ClearTextBox();
                txtHoTen.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhachHang.Text.Trim();
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
                if (!checkID(ma) )
                {
                    if (Regex.IsMatch(txtHoTen.Text.Trim(), @"^[a-zA-Z]+$"))
                    {
                        sql = "insert into KhachHang values('" + txtMaKhachHang.Text + "',N'" + txtHoTen.Text + "',N'" + cb_gioitinh.Text + "',N'" + txt_diachi.Text + "','" + txtSoDienThoai.Text + "')";
                        Function.ExecuteNonQuery(sql);
                        MessageBox.Show("Them Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                        loaddata();
                        ClearTextBox();
                        txtHoTen.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập chữ cái", "Thông báo");
                    }
                }

                else
                {
                    MessageBox.Show("Khach Hang Da Ton Tai!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled=true;
                txt_tk.Enabled= true;
                ClearTextBox();
                txtHoTen.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "delete KhachHang where ma_kh='" + txtMaKhachHang.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
            }
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from KhachHang where ma_kh='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }

        private void dgv_khachhang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_khachhang.CurrentRow != null)
            {
                txtMaKhachHang.Text = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
                cb_gioitinh.Text = dgv_khachhang.CurrentRow.Cells[2].Value.ToString();
                txt_diachi.Text = dgv_khachhang.CurrentRow.Cells[3].Value.ToString();
                txtSoDienThoai.Text = dgv_khachhang.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "select * from KhachHang where ten like '%"+txt_tk.Text+"%'";
                dgv_khachhang.DataSource = Function.GetDataTable(sql);
            }
        }

        private void txt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tk.Clear();
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
