using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess : DataBaseAccess
    {
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            string info = CheckLogicDTO(taiKhoan);
            return info;
        }
    }
}
