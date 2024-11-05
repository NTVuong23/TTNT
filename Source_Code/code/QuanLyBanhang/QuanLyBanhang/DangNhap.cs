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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_user.Text;
                string mk = txt_password.Text;
                string sql = $"SELECT * FROM t_k WHERE tk = '{tk}' AND mk = '{mk}'";

                DataTable dt = Function.GetDataTable(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow rdr = dt.Rows[0];
                    Function.TaiKhoanInfo.TenTaiKhoan = rdr["tk"].ToString();
                    Function.TaiKhoanInfo.TenNguoiDung = rdr["ten_nd"].ToString();
                    Function.TaiKhoanInfo.cv = rdr["cv"].ToString();
                    Function.TaiKhoanInfo.Manv = rdr["tk"].ToString();

                    if (Function.TaiKhoanInfo.cv == "Admin")
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                    else if (Function.TaiKhoanInfo.cv == "Nhân Viên")
                    {
                        if (!Function.TaiKhoanInfo.ThoiDiemDangNhapDict.ContainsKey(Function.TaiKhoanInfo.TenTaiKhoan))
                        {
                            Function.TaiKhoanInfo.ThoiDiemDangNhapDict.Add(Function.TaiKhoanInfo.TenTaiKhoan, DateTime.Now);
                        }

                        frmMain_nv frm = new frmMain_nv();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login.Focus();
            }
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }
    }
}
