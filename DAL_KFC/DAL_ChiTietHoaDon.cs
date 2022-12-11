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
    public class DAL_ChiTietHoaDon:DBConnect
    {
        //Hiển thị tất cả thực đơn
        public DataTable getAllThucDon()
        {
            cnn.Open();
            string sql = string.Format("SELECT MATHUCDON, TENTHUCDON, GIABAN, GIAMGIA FROM THUCDON");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Hiển thị theo từng nhóm thực đơn
        public DataTable getTheoTungNhomThucDon(string manhom)
        {
            cnn.Open();
            string sql = string.Format("SELECT MATHUCDON, TENTHUCDON, GIABAN, GIAMGIA FROM THUCDON WHERE MANHOM = '{0}'", manhom);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã nhóm từ tên nhóm
        public string getMaNhom(string tennhom)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANHOM FROM NHOMTHUCDON WHERE TENNHOM = N'{0}'", tennhom);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }

        //thêm
        public bool themCTHD(DTO_CTHD cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themChiTietHoaDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                cmd.Parameters.AddWithValue("@MaThucDon", cthd.MaTD);
                cmd.Parameters.AddWithValue("@SLMua", cthd.SLMua);
                cmd.Parameters.AddWithValue("@TongTien", cthd.ThanhTien);
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
