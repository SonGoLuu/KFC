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
    public class DAL_HoaDon : DBConnect
    {
        //Lấy mã hd cuối
        public string getMaHDCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD FROM HOADON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "HD0" + sohdmoi;
            else mahdmoi = "HD" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //load dgv
        public DataTable getAllHoaDon()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MAHD, A.TENKH, B.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM HOADON A, NHANVIEN B WHERE A.MANVLAP = B.MANV", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //tìm kiếm
        public DataTable find(string tennv)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAHD, A.TENKH, B.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM HOADON A, NHANVIEN B WHERE A.MANVLAP = B.MANV AND B.HOTENNV like N'%{0}%'", tennv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //thêm
        public bool themHoaDon(DTO_HoaDon hd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themHoaDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
                cmd.Parameters.AddWithValue("@TenKH", hd.TenKH);
                cmd.Parameters.AddWithValue("@MaNVLap", hd.MaNVLap);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
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
