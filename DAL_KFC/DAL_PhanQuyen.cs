using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_KFC;

namespace DAL_KFC
{
    public class DAL_PhanQuyen:DBConnect
    {
        //Lấy ALL Tên tài khoản
        public DataTable getAllTenDangNhap()
        {
            cnn.Open();
            string sql = string.Format("SELECT TENTAIKHOAN FROM TAIKHOAN");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tên NV tương ứng
        public string getTenNV(string tentaikhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV FROM NHANVIEN A, TAIKHOAN B WHERE A.MANV = B.MANV AND B.TENTAIKHOAN = '{0}'", tentaikhoan) ;
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return dt.Rows[0].Field<string>(0);
            else return "";
        }
        //Lấy tên quyền
        public string getTenQuyen(string tentaikhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT TENQUYEN FROM PHANQUYEN WHERE TENTAIKHOAN = '{0}'", tentaikhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return dt.Rows[0].Field<string>(0);
            else return ""; 
        }
        //CheckTenTaiKhoanPhanQuyen
        public bool themsuaPhanQuyen(DTO_PhanQuyen pq)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("suaPhanQuyen", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", pq.TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenQuyen", pq.TenQuyen);
                    cmd.Parameters.AddWithValue("@ChiTietQuyen", pq.ChiTietQuyen);   
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }
            return false;
        }
    }
}
