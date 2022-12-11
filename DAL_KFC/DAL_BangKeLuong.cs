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
    public class DAL_BangKeLuong:DBConnect
    {
        //Load dgv theo tháng năm 
        public DataTable loadDgvBangKeLuong(string thangnam)
        {
            cnn.Open();
            string sql = string.Format("select a.MaNV, a.HoTenNV, 0 as NghiPhep, b.TienLuong, b.PhuCap, cast(b.TienLuong  + b.TienLuong * b.PhuCap / 100 as float) as TongLuong, cast(b.TienLuong + b.TienLuong * b.PhuCap / 100 as float) as ThucLinh  from NhanVien a, LuongChucDanh b, HoSoNhanVien c where a.MaCD = b.MaCD and a.manv = c.manv and c.NgayVaoLam < '{0}'", thangnam);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themBangKeLuong(DTO_BangKeLuong bkl)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themBangKeLuong", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", bkl.MaNV);
                cmd.Parameters.AddWithValue("@NghiPhep", bkl.NghiPhep);
                cmd.Parameters.AddWithValue("@LuongNhan", bkl.LuongNhan);
                cmd.Parameters.AddWithValue("@ThoiGian", bkl.Thoigian);
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
