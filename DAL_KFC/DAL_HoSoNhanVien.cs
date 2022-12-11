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
    public class DAL_HoSoNhanVien:DBConnect
    {
        //Load dgv HSNV
        public DataTable getAllHSNV()
        {
            cnn.Open();
            string sql = string.Format("SELECT HOTENNV, NGAYVAOLAM, DANTOC, TONGIAO, TINHTHANH, BANGCAP FROM HOSONHANVIEN, NHANVIEN WHERE HOSONHANVIEN.MANV = NHANVIEN.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy FileAnh
        public string getFileAnh(string manv)
        {
            cnn.Open();
            string sql = string.Format("SELECT FILEANH FROM HOSONHANVIEN WHERE MANV = '{0}'", manv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //Lấy họ tên và chức vụ từ manv
        public DataTable getTenvaCD(string manv)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV, B.TENCD FROM NHANVIEN A, CHUCDANH B WHERE A.MACD = B.MACD AND A.MANV = '{0}'", manv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy cbb Tên NV đã có
        public DataTable getcbbTenNV()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.HOTENNV FROM NHANVIEN A, HOSONHANVIEN B WHERE A.MANV = B.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy cbb Tên NV chưa có
        public DataTable getcbbTenNVChuaCo()
        {
            cnn.Open();
            string sql = string.Format("SELECT HOTENNV FROM NHANVIEN A WHERE MACD is NULL AND MaNV <> ALL (SELECT MANV FROM HoSoNhanVien)");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy 1 HSNV
        public DataTable getMotHSNV(string manv)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM HOSONHANVIEN WHERE MANV = '{0}'", manv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themHSNV(DTO_HoSoNhanVien hsnv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themHoSoNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", hsnv.MaNV);
                cmd.Parameters.AddWithValue("@DanToc", hsnv.DanToc);
                cmd.Parameters.AddWithValue("@TonGiao", hsnv.TonGiao);
                cmd.Parameters.AddWithValue("@TinhThanh", hsnv.TinhThanh);
                cmd.Parameters.AddWithValue("@NgayVaoLam", hsnv.NgayVaolam);
                cmd.Parameters.AddWithValue("@BangCap", hsnv.BangCap);
                cmd.Parameters.AddWithValue("@FileAnh", hsnv.FileAnh);
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
        //Thêm
        public bool suaHSNV(DTO_HoSoNhanVien hsnv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaHoSoNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", hsnv.MaNV);
                cmd.Parameters.AddWithValue("@DanToc", hsnv.DanToc);
                cmd.Parameters.AddWithValue("@TonGiao", hsnv.TonGiao);
                cmd.Parameters.AddWithValue("@TinhThanh", hsnv.TinhThanh);
                cmd.Parameters.AddWithValue("@NgayVaoLam", hsnv.NgayVaolam);
                cmd.Parameters.AddWithValue("@BangCap", hsnv.BangCap);
                cmd.Parameters.AddWithValue("@FileAnh", hsnv.FileAnh);
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
        public bool xoaHSNV(string manv)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaHoSoNhanVien", cnn);
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
