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
    public class HangHoa_DAO
    {
        public DataTable LoadHangHoa()
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT * FROM HANGHOA";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new System.Data.DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool ThemHangHoa(HangHoa_DTO hh)
        {
            //kiem tra
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Id FROM HANGHOA WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = hh.Id;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count++;
                string s = reader.GetString(0);
            }
            reader.Close();
            if (count == 1)
            {
                return false;
            }

            SqlConnection conn1 = ConnectToSQL.HamKetNoi();
            string str1 = "INSERT INTO HANGHOA(Id, Ten, Dongia, Soluong) VALUES (@Id, @Ten, @Dongia, @Soluong)";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd1.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
            cmd1.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd1.Parameters.Add("@Soluong", SqlDbType.Int);

            cmd1.Parameters["@Id"].Value = hh.Id;
            cmd1.Parameters["@Ten"].Value = hh.Ten;
            cmd1.Parameters["@Dongia"].Value = hh.Dongia;
            cmd1.Parameters["@Soluong"].Value = hh.Soluong;

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();
            return true;
        }
        public bool XoaHangHoa(HangHoa_DTO hh)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM HANGHOA WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = hh.Id;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
        public bool CapNhatHangHoa(HangHoa_DTO hh)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE HANGHOA SET Ten = @Ten, Dongia = @Dongia, Soluong = @Soluong WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int);

            cmd.Parameters["@Id"].Value = hh.Id;
            cmd.Parameters["@Ten"].Value = hh.Ten;
            cmd.Parameters["@Dongia"].Value = hh.Dongia;
            cmd.Parameters["@Soluong"].Value = hh.Soluong;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
    }
}
