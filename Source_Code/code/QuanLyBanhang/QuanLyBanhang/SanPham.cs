using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyBanhang
{
    public partial class SanPham : Form
    {
        private string sql;
        DataTable dt;
        public SanPham()
        {
            InitializeComponent();
            cb_loaihang.Text = "Đồ Gia Dụng";
        }
        private void loaddata()
        {
            sql = "select SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,NhaCungCap.ma_nhacc,NhaCungCap.ten_ct from SanPham left join NhaCungCap on SanPham.ma_nhacc=NhaCungCap.ma_nhacc";
            dt = Function.GetDataTable(sql);
            dgv_sanpham.DataSource = dt;           
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxData();
            dgv_sanpham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_sanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_sanpham.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgv_sanpham.Columns[3].HeaderText = "Mặt Hàng";
            dgv_sanpham.Columns[4].HeaderText = "Mã NCC";
            dgv_sanpham.Columns[5].HeaderText = "Công Ty";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            txtTensp.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMasp.Text.Trim();
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

                sql = "update SanPham set ten_sp=N'" + txtTensp.Text + "', hang_sx=N'" + txt_hangsx.Text + "', mat_hang=N'" + cb_loaihang.Text + "' where ma_sp='" + ma + "' and ma_nhacc='"+cb_manhacc.Text+"'";
                Function.ExecuteNonQuery(sql);
                loaddata();
                ClearTextBox();
                txtTensp.Focus();
                MessageBox.Show("Sua Thanh Cong", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled=true;
                txt_TKtenKH.Enabled=true;
                ClearTextBox();
                txtTensp.Focus();
            }
        }
        private void ClearTextBox()
        {
            Random random = new Random();
            string manhacc;
            manhacc = "SP" + random.Next(1, 999).ToString();
            txtMasp.Text = manhacc;
            txtTensp.Text = "";
            txt_hangsx.Text = "";
            cb_loaihang.Text = "";
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from SanPham where ma_sp='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMasp.Text.Trim();
            if (btnSua.Text == "Sửa")
            {
                btnThem.Text = "Lưu";
                btnSua.Text = "Hủy";
                btnXoa.Enabled = false;
                btnLammoi.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_TKtenKH.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!checkID(ma))
                {
                    sql = "insert into SanPham values('" + txtMasp.Text + "','"+cb_manhacc.Text+"',N'" + txtTensp.Text + "',N'" + txt_hangsx.Text + "',N'" + cb_loaihang.Text + "')";
                    Function.ExecuteNonQuery(sql);
                    MessageBox.Show("Them Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                    loaddata();
                    ClearTextBox();
                    txtTensp.Focus();
                }

                else
                {
                    MessageBox.Show("San Pham Da Ton Tai!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled=true;
                txt_TKtenKH.Enabled=true;
                ClearTextBox();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMasp.Text))
            {
                DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "delete SanPham where ma_sp='" + txtMasp.Text + "' and ma_nhacc='" + cb_manhacc + "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                }
            }
            else { MessageBox.Show("Vui Long Chon 1 Dong De Xoa","Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void dgv_sanpham_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_sanpham.CurrentRow != null)
            {
                txtMasp.Text = dgv_sanpham.CurrentRow.Cells[0].Value.ToString();
                txtTensp.Text = dgv_sanpham.CurrentRow.Cells[1].Value.ToString();
                txt_hangsx.Text = dgv_sanpham.CurrentRow.Cells[2].Value.ToString();
                cb_loaihang.Text = dgv_sanpham.CurrentRow.Cells[3].Value.ToString();
                cb_manhacc.Text = dgv_sanpham.CurrentRow.Cells[4].Value.ToString();
                cb_nhacc.Text = dgv_sanpham.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void cb_manhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cb_nhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void LoadComboBoxData()
        {
            sql = "select ma_nhacc, ten_ct from NhaCungCap";
            dt = Function.GetDataTable(sql);
            sql = "select loai_hang from Loai_Hang";
            DataTable dt1 = Function.GetDataTable(sql);

            cb_manhacc.DataSource = dt;
            cb_manhacc.DisplayMember = "ma_nhacc";
            cb_manhacc.ValueMember = "ma_nhacc";

            cb_nhacc.DataSource = dt;
            cb_nhacc.DisplayMember = "ten_ct";
            cb_nhacc.ValueMember = "ten_ct";

            cb_loaihang.DataSource = dt1;
            cb_loaihang.DisplayMember = "loai_hang";
            cb_loaihang.ValueMember = "loai_hang";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenKH.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "select SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,NhaCungCap.ma_nhacc,NhaCungCap.ten_ct from SanPham left join NhaCungCap on SanPham.ma_nhacc=NhaCungCap.ma_nhacc where ten_sp like'%"+txt_TKtenKH.Text+"%'";
                dgv_sanpham.DataSource = Function.GetDataTable(sql);
            }
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenKH.Clear();
        }
    }
}
