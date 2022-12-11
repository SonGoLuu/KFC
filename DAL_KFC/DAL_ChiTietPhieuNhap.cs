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
    public class DAL_ChiTietPhieuNhap:DBConnect
    {
        //load dgv
        public DataTable getCTPN(string maphieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MANL, B.TENNL, A.GIATIEN, A.SLNHAP, A.THANHTIEN FROM CHITIETPHIEUNHAP A, NGUYENLIEU B WHERE A.MANL = B. MANL AND A.MAPHIEU = '{0}'", maphieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy all thông tin phiếu nhập
        public DataTable getPN(string maphieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM PHIEUNHAP WHERE MAPHIEU = '{0}'", maphieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm CTPN
        public bool themCTPN(DTO_CTPN ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themChiTietPhieuNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", ctpn.MaPhieu);
                cmd.Parameters.AddWithValue("@MaNL", ctpn.MaNL);
                cmd.Parameters.AddWithValue("@Giatien", ctpn.GiaTien);
                cmd.Parameters.AddWithValue("@SLnhap", ctpn.SLNhap);
                cmd.Parameters.AddWithValue("@Thanhtien", ctpn.ThanhTien);
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
