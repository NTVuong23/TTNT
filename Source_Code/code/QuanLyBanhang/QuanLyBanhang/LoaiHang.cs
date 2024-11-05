using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class LoaiHang : Form
    {
        public LoaiHang()
        {
            InitializeComponent();
        }
        private string sql;
        private void loaddata() {
            sql = "select * from Loai_Hang";
            dgv_loaiHang.DataSource = Function.GetDataTable(sql);
        }
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            loaddata();
            dgv_loaiHang.Columns[0].HeaderText = "Mã Mặt Hàng";
            dgv_loaiHang.Columns[1].HeaderText = "Mặt Hàng";
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from Loai_Hang where ma_lh='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text =="Thêm")
            {
                btnThem.Text = "Hủy";
                btnSua.Text = "Lưu";
                btnXoa.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_tk.Enabled=false;
            }else if (btnThem.Text == "Lưu")
            {
                if (!string.IsNullOrEmpty(txt_loaiHang.Text) && !string.IsNullOrEmpty(txt_maLH.Text))
                {
                    sql = "update Loai_Hang set loai_hang = N'" + txt_loaiHang.Text + "' where ma_lh='" + txt_maLH.Text + "'";
                    Function.ExecuteNonQuery(sql);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    loaddata();
                    NewData();
                }
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_tk.Enabled = true;
                NewData();
            }
        }
        private void NewData()
        {
            Random rd = new Random();
            string maMH = "MH" + rd.Next(1,99).ToString();
            txt_maLH.Text = maMH;
            txt_loaiHang.Text = "";
            txt_loaiHang.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Hủy";
                btnThem.Text = "Lưu";
                btnXoa.Enabled = false;
                txt_tk.Enabled= false;
                btn_timkiem.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!string.IsNullOrEmpty(txt_loaiHang.Text) && !string.IsNullOrEmpty(txt_maLH.Text) &&!checkID(txt_maLH.Text))
                {
                    sql = "insert into Loai_Hang values ('" + txt_maLH.Text + "',N'" + txt_loaiHang.Text + "' )";
                    Function.ExecuteNonQuery(sql);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    loaddata();
                    NewData();
                }
            }
            else
            {               
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
                txt_tk.Enabled = true;
                btn_timkiem.Enabled = true;
                NewData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_loaiHang.Text) && !string.IsNullOrEmpty(txt_maLH.Text))
            {
                DialogResult tl = MessageBox.Show("Bạn thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(tl == DialogResult.OK)
                {
                    sql = "delete Loai_Hang where ma_lh='" + txt_maLH.Text + "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    MessageBox.Show("Xóa thành công");
                    NewData();
                }
            }
        }

        private void dgv_loaiHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_loaiHang.CurrentCell != null) {
                txt_maLH.Text = dgv_loaiHang.CurrentRow.Cells[0].Value.ToString();
                txt_loaiHang.Text = dgv_loaiHang.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "select * from Loai_Hang where loai_hang like '%"+txt_tk.Text+"%'";
                dgv_loaiHang.DataSource = Function.GetDataTable(sql);
            }
        }

        private void txt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tk.Clear();
        }
    }
}
