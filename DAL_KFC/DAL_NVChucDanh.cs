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
    public class DAL_NVChucDanh:DBConnect
    {
        //Load dgv
        public DataTable getAllChucDanh()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV, B.TENCD FROM NHANVIEN A, CHUCDANH B WHERE A.MACD = B.MACD");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã cd từ tên cd
        public string getMaCD(string TenCD)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MACD FROM CHUCDANH WHERE TENCD = N'{0}'", TenCD);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien.Rows[0].Field<string>(0);
        }
        //Lấy cbb nhân viên
        public DataTable getcbbNV()
        {
            cnn.Open();
            string sql = string.Format("SELECT HOTENNV FROM NHANVIEN WHERE MACD IS NOT NULL");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy cbb chức danh
        public DataTable getcbbCD()
        {
            cnn.Open();
            string sql = string.Format("SELECT TENCD FROM CHUCDANH");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy cbb nhân viên mới vào
        public DataTable getcbbNVMoi()
        {
            cnn.Open();
            string sql = string.Format("SELECT HOTENNV FROM NHANVIEN WHERE MACD is NULL");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themsuaNVChucDanh(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaCDNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@MaCD", nv.MaCD);
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
        public bool xoaNVChucDanh(string manv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaCDNhanVien", cnn);
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
