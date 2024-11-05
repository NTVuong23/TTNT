using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace QuanLyBanhang
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private void loaddata()
        {


        }
        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
   

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtp1.Value;
            DateTime ngayKetThuc = dtp2.Value;

            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ngayBatDauFormatted = ngayBatDau.ToString("yyyy/MM/dd");
                string ngayKetThucFormatted = ngayKetThuc.ToString("yyyy/MM/dd");

                if (rdbPN.Checked)
                {

                    string sql = $"select SanPham.ten_sp as N'Tên Sản Phẩm',SanPham.mat_hang as N'Mặt Hàng',SanPham.hang_sx as N'Hãng Sản Xuất',sum(hdn.sl) as N'Số Lượng Tồn Kho' from hdn inner join SanPham on hdn.ma_sp=SanPham.ma_sp where hdn.ngay_lp BETWEEN '{ngayBatDauFormatted}' AND '{ngayKetThucFormatted}' GROUP BY SanPham.ten_sp, SanPham.mat_hang, SanPham.hang_sx";
                    dgvTK.DataSource = Function.GetDataTable(sql);
                }
                else if (rdbHD.Checked)
                {

                    string sql = $"select SanPham.ten_sp as N'Tên Sản Phẩm',SanPham.mat_hang as N'Mặt Hàng',SanPham.hang_sx as N'Hãng Sản Xuất',sum(hdx.sl) as N'Số Lượng Đã Bán',sum((hdx.sl*hdx.dg)) as N'Doanh Thu' from hdx inner join SanPham on hdx.ma_sp=SanPham.ma_sp where hdx.ngay_lp BETWEEN '{ngayBatDauFormatted}' AND '{ngayKetThucFormatted}' GROUP BY SanPham.ten_sp, SanPham.mat_hang, SanPham.hang_sx";
                    dgvTK.DataSource = Function.GetDataTable(sql);
                }
            }
        }
    }
}
