using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class HoaDon_DAO
    {
        public static void ThemHoaDon(HoaDon_DTO hd)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"INSERT INTO HOADON(Ban, Tongtien) VALUES (@Ban, @Tongtien)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Ban", SqlDbType.Int);
            cmd.Parameters.Add("@Tongtien", SqlDbType.Float);

            cmd.Parameters["@Ban"].Value = hd.Ban;
            cmd.Parameters["@Tongtien"].Value = hd.Tongtien;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static string CoutDS()
        {
            int t = 0;
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"SELECT COUNT(*) FROM HOADON";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                t = reader.GetInt32(0);
            }
            reader.Close();
            return t.ToString();
        }
    }
}
