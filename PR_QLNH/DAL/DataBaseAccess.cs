using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        //Tao chuoi ket noi CSDL
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-QL0AEGI\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(strcon); //Khoi tao connect
            return conn;

        }
    }
    public class DataBaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taiKhoan)
        {
            string result = null;

            // Kết nối tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("proc_logic", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user", taiKhoan.sTaiKhoan);
                command.Parameters.AddWithValue("@pass", taiKhoan.sMatKhau);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Đọc thông báo từ stored procedure
                        result = reader["Result"].ToString();
                    }
                }
                else
                {
                    result = "Tài khoản hoặc mật khẩu không chính xác!";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                result = "Đã có lỗi xảy ra: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
  

}
