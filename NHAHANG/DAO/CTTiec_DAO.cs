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
    public class CTTiec_DAO
    {
        public  bool ThemCTTiec(CTTiec_DTO cttiec)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"INSERT INTO CTTIEC(IDTiec, Mon, Dongia, Soluong) VALUES (@IDTiec, @Mon, @Dongia, @Soluong)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDTiec", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Mon", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int);


            cmd.Parameters["@IDTiec"].Value = cttiec.Id;
            cmd.Parameters["@Mon"].Value = cttiec.Mon;
            cmd.Parameters["@Dongia"].Value = cttiec.Dongia;
            cmd.Parameters["@Soluong"].Value = cttiec.Soluong;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
        }
        public  DataTable LoadCTHDTheoIDTiec(string Id)
        {
            try
            {
                SqlConnection cnn = ConnectToSQL.HamKetNoi();
                //string str = "SELECT tenmon, soluong FROM CT_HD";
                string str = @"SELECT Mon, Dongia, Soluong FROM CTTIEC WHERE IDTiec = @IDTiec";
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IDTiec", SqlDbType.NChar, 10);
                cmd.Parameters["@IDTiec"].Value = Id;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtb = new DataTable();
                da.Fill(dtb);
                return dtb;
            }
            catch { return null; }
        }
    }
}
