
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class HoanTra : Form
    {
        string sql;
        public HoanTra()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            sql = "select hdx.hd_xuat, KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl*hdx.dg) from hdx left join KhachHang on hdx.ma_kh=KhachHang.ma_kh left join SanPham on hdx.ma_sp=SanPham.ma_sp";
            dgv_hoanTra.DataSource = Function.GetDataTable(sql);
        }
        private void HoanTra_Load(object sender, EventArgs e)
        {
            date_nl.Enabled = false;
            loaddata();
            dgv_hoanTra.Columns[0].HeaderText = "Số Phiếu";
            dgv_hoanTra.Columns[1].HeaderText = "Tên Khách Hàng";
            dgv_hoanTra.Columns[2].HeaderText = "Mã Sản Phẩm";
            dgv_hoanTra.Columns[3].HeaderText = "Tên Sản Phẩm";
            dgv_hoanTra.Columns[4].HeaderText = "Ngày Mua";
            dgv_hoanTra.Columns[5].HeaderText = "Số Luợng";
            dgv_hoanTra.Columns[6].HeaderText = "Đơn Giá";
            dgv_hoanTra.Columns[7].HeaderText = "Thành Tiền";
            dgv_hoanTra.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_sp.Text) && !string.IsNullOrEmpty(txt_tkh.Text))
            {
                if (btn_timkiem.Text == "Lưu")
                {
                    DateTime dateTime1 = date_nl.Value;                   
                    DateTime dateTime2 = DateTime.Today;
                    TimeSpan difference = dateTime2-dateTime1;
                    int numberOfDays = (int)Math.Abs(difference.TotalDays);

                    if (numberOfDays <= 30)
                    {
                        sql = "update hdn set sl=sl+ '" + txt_sl.Text + "' where ma_sp='" + textBox1.Text + "'";
                        Function.ExecuteNonQuery(sql);
                        sql = "delete hdx where hd_xuat='" + txt_sp.Text + "'";
                        Function.ExecuteNonQuery(sql);
                        loaddata();
                        MessageBox.Show("Hoàn Trả Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Đã vượt quá số ngày có thể hoàn trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Số ngày hoàn trả tối đa là 30 ngày", "Thông báo");
                }
            }
                else
                {
                    if (txt_TKtenKH.Text == "")
                    {
                        sql = "select hdx.hd_xuat, KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl*hdx.dg) from hdx left join KhachHang on hdx.ma_kh=KhachHang.ma_kh left join SanPham on hdx.ma_sp=SanPham.ma_sp ";
                        dgv_hoanTra.DataSource = Function.GetDataTable(sql);
                    }
                    else
                    {
                        sql = "select hdx.hd_xuat, KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl*hdx.dg) from hdx left join KhachHang on hdx.ma_kh=KhachHang.ma_kh left join SanPham on hdx.ma_sp=SanPham.ma_sp where KhachHang.ten like'%" + txt_TKtenKH.Text.Trim() + "%'";
                        dgv_hoanTra.DataSource = Function.GetDataTable(sql);
                    }
                }
            }
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenKH.Clear();
        }
        private void dgv_hoanTra_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hoanTra.CurrentRow != null)
            {
                txt_sp.Text = dgv_hoanTra.CurrentRow.Cells[0].Value.ToString();
                txt_tkh.Text = dgv_hoanTra.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dgv_hoanTra.CurrentRow.Cells[2].Value.ToString();
                txt_tsp.Text = dgv_hoanTra.CurrentRow.Cells[3].Value.ToString();
               date_nl.Text = dgv_hoanTra.CurrentRow.Cells[4].Value.ToString();
                txt_sl.Text = dgv_hoanTra.CurrentRow.Cells[5].Value.ToString();
                txt_dGia.Text = dgv_hoanTra.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btn_hoanTra_Click(object sender, EventArgs e)
        {
            if (btn_hoanTra.Text == "Hoản Trả")
            {
                btn_hoanTra.Text = "Hủy";
                btn_timkiem.Text = "Lưu";
 
            }
            else
            {
                btn_hoanTra.Text = "Hoản Trả";
                btn_timkiem.Text = "Tìm Kiếm";

            }
 
        }

        private void txt_TKtenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
