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
    public class DAL_NhanVien:DBConnect
    {
        //Lấy mã NV cuối
        public string getMaNVCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANV FROM NHANVIEN", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "NV0" + sohdmoi;
            else mahdmoi = "NV" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Lấy all nhân viên
        public DataTable getNhanVien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        //Load bảng dgv
        public DataTable loadDgvNhanVien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANV, HOTENNV, NGAYSINH, GIOITINH, CMND, SDTNV  FROM NhanVien", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        //Find nhân viên
        public DataTable findNhanVien(string HoTenNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANV, HOTENNV, NGAYSINH, GIOITINH, CMND, SDTNV  FROM NhanVien WHERE HOTENNV like N'%{0}%'", HoTenNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtFindNhanVien = new DataTable();
            da.Fill(dtFindNhanVien);
            cnn.Close();
            return dtFindNhanVien;
        }
        //Lấy 1 nhân viên
        public DataTable getMotNhanVien(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT * FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        //Lấy mã nv từ tên nv
        public string getMaNV(string HoTenNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANV FROM NHANVIEN WHERE HOTENNV = N'{0}'", HoTenNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien.Rows[0].Field<string>(0);
        }
        //Lấy họ tên từ mã nv
        public string getHoTenNV(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT HOTENNV FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien.Rows[0].Field<string>(0);
        }
        //Thêm
        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.HoTenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDTNV);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
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
        //Sửa
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.HoTenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDTNV);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
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
        //xóa
        public bool xoaNhanVien(string manv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", manv);
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
