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
    public class DAL_TaiKhoan : DBConnect
    {
        //Kiểm tra tài khoản 
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
                cnn.Open();
                string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = '{0}' AND MATKHAU = '{1}'", TenTaiKhoan, MatKhau);
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                if (dt.Rows.Count > 0) return true;
                else return false;   
        }

        //Lấy danh sách tài khoản
        public DataTable getAllTaiKhoan()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MaNV, C.HOTENNV, A.TENTAIKHOAN, A.MATKHAU FROM TAIKHOAN A, NHANVIEN C WHERE A.MANV = C.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Lấy tên nv chưa có tài khoản
        public DataTable getCBBNV()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV FROM NHANVIEN A EXCEPT SELECT A.HOTENNV FROM NHANVIEN A, TAIKHOAN B WHERE A.MANV = B.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy all nv tài khoản
        public DataTable getAllCBBNV()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV FROM NHANVIEN A, TAIKHOAN B WHERE A.MANV = B.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã nv từ tài khoản
        public string getMaNV(string tentaikhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT MANV FROM TAIKHOAN WHERE TENTAIKHOAN ='{0}'", tentaikhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //Lấy tên tài khoản từ mã nv
        public string getTenTaiKhoan(string manv)
        {
            cnn.Open();
            string sql = string.Format("SELECT TENTAIKHOAN FROM TAIKHOAN WHERE MANV ='{0}'", manv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //Lấy mật khẩu từ tên tài khoản
        public string getMatKhau(string tentaikhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT MATKHAU FROM TAIKHOAN WHERE TENTAIKHOAN ='{0}'", tentaikhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //Tạo mới tài khoản
        public bool themTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("themPhanQuyen", cnn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                    cmd2.Parameters.AddWithValue("@TenQuyen", "0");
                    cmd2.Parameters.AddWithValue("@ChiTietQuyen", "");
                    if (cmd2.ExecuteNonQuery() > 0)
                        return true;
                }    
                    
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
        //Sửa tài khoản
        public bool suaTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaMKTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
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
        //Xóa tài khoản
        public bool xoaTaiKhoan(string TenTaiKhoan)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
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
