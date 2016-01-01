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
    public class Baocaochi_DAO
    {
        public DataTable LoadDS(DateTime ngay)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT * FROM BAOCAOCHI WHERE Ngay = @Ngay";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime);
            cmd.Parameters["@Ngay"].Value = ngay;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool ThemBaoCao(Baocaochi_DTO bc)
        {
            SqlConnection conn1 = ConnectToSQL.HamKetNoi();
            string str1 = "INSERT INTO BAOCAOCHI(Ngay, Loai, Tien) VALUES (@Ngay, @Loai, @Tien)";
            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("@Ngay", SqlDbType.DateTime);
            cmd1.Parameters.Add("@Loai", SqlDbType.NVarChar, 50);
            cmd1.Parameters.Add("@Tien", SqlDbType.Float);

            cmd1.Parameters["@Ngay"].Value = bc.Ngay;
            cmd1.Parameters["@Loai"].Value = bc.Loai;
            cmd1.Parameters["@Tien"].Value = bc.Tien;

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();
            return true;
        }
    }
}
