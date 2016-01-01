using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CTHD_DAO
    {
        public static bool ThemCTHD(CTHD_DTO cthd)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"INSERT INTO CTHD(Mahoadon, Tenmon, Dongia, Soluong) VALUES (@Mahoadon, @Tenmon, @Dongia, @Soluong)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Mahoadon", SqlDbType.Int);
            cmd.Parameters.Add("@Tenmon", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int);


            cmd.Parameters["@Mahoadon"].Value = cthd.Mahoadon;
            cmd.Parameters["@Tenmon"].Value = cthd.Tenmon;
            cmd.Parameters["@Dongia"].Value = cthd.Dongia;
            cmd.Parameters["@Soluong"].Value = cthd.Soluong;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
        }
        public static DataTable LoadCTHDTheoMHD(int mahoadon)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            //string str = "SELECT tenmon, soluong FROM CT_HD";
            string str = @"SELECT Tenmon, Dongia, Soluong FROM CTHD WHERE mahoadon = @Mahoadon";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Mahoadon", SqlDbType.Int);
            cmd.Parameters["@Mahoadon"].Value = mahoadon;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}
