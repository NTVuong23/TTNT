using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DTO;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL(); 

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.sTaiKhoan = txtTaiKhoan.Text;
            taikhoan.sMatKhau = txtMatKhau.Text;
            string getuser = TKBLL.CheckLogic(taikhoan);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "Requeid_taikhoan":
                    MessageBox.Show("Vui lòng nhập tài khoản!");
                    return;
                case "Requeid_matkhau":
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            // Nếu getuser là null hoặc chuỗi rỗng, tức là đăng nhập không thành công
            if (string.IsNullOrEmpty(getuser))
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
                return;
            }

            // Nếu có kết quả hợp lệ, nghĩa là đăng nhập thành công
            MessageBox.Show("Đăng nhập hệ thống thành công!");
        }

    }
}
