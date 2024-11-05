using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanhang
{
    static internal class Function
    {
        private static string link = "Data Source=Doanh;Initial Catalog=QTBH;Integrated Security=True";
        private static SqlConnection Connect()
        {
            return new SqlConnection(link);
        }

        public static void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
        public static DataTable GetDataTable(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlDataAdapter dat = new SqlDataAdapter(sql,conn);
            DataTable dt=new DataTable();
            dat.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }
        public static string ExecuteScalar(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cm = new SqlCommand(sql, conn);
            Object kq= cm.ExecuteScalar();
            conn.Close();
            conn.Dispose ();
            if (kq != null)
            {
                return kq.ToString();
            }
            else
            {
                return "";
            }
        }
        public static class TaiKhoanInfo
        {
            // Thuộc tính lưu tên tài khoản
            public static string TenTaiKhoan { get; set; }

            // Thuộc tính lưu tên người dùng
            public static string TenNguoiDung { get; set; }

            // Thuộc tính lưu chucvu
            public static Dictionary<string, DateTime> ThoiDiemDangNhapDict = new Dictionary<string, DateTime>();
            public static string cv { get; set; }
            public static string Manv { get; set; }
        }
    }
}
