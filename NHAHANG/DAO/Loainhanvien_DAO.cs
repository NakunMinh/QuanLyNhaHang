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
    public class Loainhanvien_DAO
    {
        public DataTable LoadDSLoaiNV()
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Tenloainhanvien FROM LOAINHANVIEN";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public string TimIdTheoTen(string ten)
        {
            string t = "";
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT IdLoainhanvien FROM LOAINHANVIEN WHERE Tenloainhanvien = @Tenloainhanvien";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tenloainhanvien", SqlDbType.NVarChar, 50);
            cmd.Parameters["@Tenloainhanvien"].Value = ten;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                t = reader.GetString(0);
            }
            reader.Close();
            return t;
        }
    }
}
