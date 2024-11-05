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
    public partial class GiamGia : Form
    {
        private string sql;
        public GiamGia()
        {
            InitializeComponent();
        }
        private void loadcombobox()
        {
            sql = "select loai_hang from Loai_Hang";
            DataTable dt = Function.GetDataTable(sql);

            cb_loaihang.DataSource = dt;
            cb_loaihang.DisplayMember = "loai_hang";
            cb_loaihang.ValueMember = "loai_hang";
        }
        private bool check(string key)
        {
            if (string.IsNullOrEmpty(key))
                return false;
            if (!int.TryParse(key, out int number) || number <1 || number >100 )
                return false;
            return true;

        }
        private void GiamGia_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }
        private void btn_tang_Click(object sender, EventArgs e)
        {
            if(btn_tang.Text=="Tăng Giá")
            {
                btn_tang.Text = "Hủy";
                btn_giam.Text = "Lưu";
            }
            else if (btn_tang.Text=="Lưu")
            {
                sql = " SELECT COUNT(*) FROM hdn inner join SanPham on SanPham.ma_sp=hdn.ma_sp WHERE SanPham.mat_hang = N'" + cb_loaihang.Text.Trim() + "'";
                int count = Convert.ToInt16(Function.ExecuteScalar(sql));
                if (count > 0)
                {
                    if (check(txt_ptGiam.Text))
                    {
                        int x = Convert.ToInt16(txt_ptGiam.Text);
                        float y = (float)(x / 100.0);
                        sql = "UPDATE hdn SET dg = dg- (dg * (" + y + ")) FROM hdn INNER JOIN SanPham ON hdn.ma_sp = SanPham.ma_sp where hdn.ma_sp = SanPham.ma_sp and SanPham.mat_hang = N'" + cb_loaihang.Text.Trim() + "'";
                        Function.ExecuteNonQuery(sql);
                        MessageBox.Show("Giảm giá thành công", "Thông báo");
                        txt_ptGiam.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tỷ lệ % tối thiểu là 1% hoặc tối đa là 100% ", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mặt hàng này hiện không có trong kho");
                }
            }
            else
            {
                btn_tang.Text = "Tăng Giá";
                btn_giam.Text = "Giảm Giá";
            }
        }

        private void btn_giam_Click(object sender, EventArgs e)
        {
            if (btn_giam.Text == "Giảm Giá")
            {
                btn_tang.Text = "Lưu";
                btn_giam.Text = "Hủy";
            }
            else if (btn_giam.Text == "Lưu")
            {
                sql = " SELECT COUNT(*) FROM hdn inner join SanPham on SanPham.ma_sp=hdn.ma_sp WHERE SanPham.mat_hang = N'" + cb_loaihang.Text.Trim() + "'";
                int count = Convert.ToInt16(Function.ExecuteScalar(sql));
                if (count > 0)
                {
                    if (check(txt_ptGiam.Text))
                    {
                        int x = Convert.ToInt16(txt_ptGiam.Text);
                        float y = (float)(x / 100.0);
                        sql = "UPDATE hdn SET dg = dg+ (dg * (" + y + ")) FROM hdn INNER JOIN SanPham ON hdn.ma_sp = SanPham.ma_sp where hdn.ma_sp=SanPham.ma_sp and SanPham.mat_hang=N'" + cb_loaihang.Text.Trim() + "'";
                        Function.ExecuteNonQuery(sql);
                        MessageBox.Show("Tăng giá thành công", "Thông báo");
                        txt_ptGiam.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tỷ lệ % tối thiểu là 1% hoặc tối đa là 100% ", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mặt hàng này hiện không có trong kho");
                }
            }
            else
            {
                btn_tang.Text = "Tăng Giá";
                btn_giam.Text = "Giảm Giá";
            }
        }
    }
}
