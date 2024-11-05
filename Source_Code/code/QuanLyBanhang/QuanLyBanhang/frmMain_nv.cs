using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class frmMain_nv : Form
    {
        public frmMain_nv()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
        }

        private void frmMain_nv_Load(object sender, EventArgs e)
        {

        }
        private void UpdateWorkingTime(int thoiGianLamViecPhut)
        {
            string selectSql = $"SELECT COUNT(*) FROM luong WHERE ma_nv = '{Function.TaiKhoanInfo.Manv}'";
            int count = Convert.ToInt32(Function.ExecuteScalar(selectSql));

            if (count > 0)
            {
                string updateSql = $"UPDATE luong SET so_gio = so_gio + {thoiGianLamViecPhut} WHERE ma_nv = '{Function.TaiKhoanInfo.Manv}'";
                Function.ExecuteNonQuery(updateSql);
            }
            else
            {
                string insertSql = $"INSERT INTO luong (ma_nv, so_gio) VALUES ('{Function.TaiKhoanInfo.Manv}', {thoiGianLamViecPhut})";
                Function.ExecuteNonQuery(insertSql);
            }
        }

        private void frmMain_nv_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Xác nhận Đăng Xuất
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát tài khoản ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                DateTime thoiDiemDangNhap;
                if (Function.TaiKhoanInfo.ThoiDiemDangNhapDict.TryGetValue(Function.TaiKhoanInfo.TenTaiKhoan, out thoiDiemDangNhap))
                {
                    // Tính thời gian làm việc
                    TimeSpan thoiGianLamViec = DateTime.Now - thoiDiemDangNhap;
                    int thoiGianLamViecPhut = (int)thoiGianLamViec.TotalMinutes; // Chuyển đổi thành phút
                    UpdateWorkingTime(thoiGianLamViecPhut);

                    DangNhap frmdangnhap = new DangNhap();
                    frmdangnhap.Show();
                    this.Hide();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void PB_MENU_MouseLeave(object sender, EventArgs e)
        {
            if (!menuStrip1.Bounds.Contains(PointToClient(MousePosition)))
            {
                PB_MENU.Visible = true; // Hiển thị PictureBox khi chuột rời khỏi
                menuStrip1.Visible = false; // Ẩn MenuStrip khi chuột rời khỏi
            }
        }

        private void PB_MENU_MouseEnter(object sender, EventArgs e)
        {
            PB_MENU.Visible = false; // Ẩn PictureBox khi trỏ chuột vào
            menuStrip1.Visible = true;
        }

        private void mnuDanhmuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuKhachhang_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KhachHangcs kh = new KhachHangcs();
            kh.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HoaDoncs hd = new HoaDoncs("Nhan Vien");
            hd.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PB_MENU.Visible = true;
            menuStrip1.Visible=false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PB_MENU_MouseLeave(sender,e);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaoTaiKhoan tk = new TaoTaiKhoan("Menu_NV");
            tk.ShowDialog();
            this.Show();
        }
    }
}
