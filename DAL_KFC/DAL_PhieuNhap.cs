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
    public class DAL_PhieuNhap:DBConnect
    {
        //Lấy mã PN cuối
        public string getMaPNCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAPHIEU FROM PHIEUNHAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "PN0" + sohdmoi;
            else mahdmoi = "PN" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //load dgv
        public DataTable getAllPhieuNhap()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MAPHIEU, B.TENNCC, C.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM PHIEUNHAP A, NHACUNGCAP B, NHANVIEN C WHERE A.MANCC = B.MANCC AND A.MANV = C.MANV", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //tìm kiếm
        public DataTable find(string tennv)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAPHIEU, B.TENNCC, C.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM PHIEUNHAP A, NHACUNGCAP B, NHANVIEN C WHERE A.MANCC = B.MANCC AND A.MANV = C.MANV AND C.HOTENNV like N'%{0}%'", tennv);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Load cbb NCC
        public DataTable getCbbNCC()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENNCC FROM NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy MANCC từ TENNCC
        public string getMaNCC(string tenncc)
        {
            cnn.Open();
            string sql = string.Format("SELECT MANCC FROM NHACUNGCAP WHERE TENNCC = N'{0}'", tenncc);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //Lấy thông tin nguyên liệu từ mã nguyên liệu
        public DataTable getNguyenLieu(string manl)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM NGUYENLIEU WHERE MANL = '{0}'", manl);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //CheckNguyenLieu
        public bool checkNguyenLieu(string manl)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM NGUYENLIEU WHERE MANL = '{0}'", manl);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        //Thêm
        public bool themPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themPhieuNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", pn.MaPhieu);
                cmd.Parameters.AddWithValue("@MaNV", pn.MaNV);
                cmd.Parameters.AddWithValue("@MaNCC", pn.MaNCC);
                cmd.Parameters.AddWithValue("@Ngaylap", pn.NgayLap);
                cmd.Parameters.AddWithValue("@Tongtien", pn.TongTien);
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
