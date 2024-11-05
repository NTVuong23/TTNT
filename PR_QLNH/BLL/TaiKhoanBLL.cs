using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        public string CheckLogic(TaiKhoan taiKhoan)
        {
            // Kiểm tra nếu tài khoản hoặc mật khẩu rỗng
            if (string.IsNullOrWhiteSpace(taiKhoan.sTaiKhoan))
            {
                return "Requeid_taikhoan";
            }
            if (string.IsNullOrWhiteSpace(taiKhoan.sMatKhau))
            {
                return "Requeid_matkhau"; // Đảm bảo lỗi chính xác cho mật khẩu
            }

            string info = tkAccess.CheckLogic(taiKhoan);
            return info;
        }
    }

}
