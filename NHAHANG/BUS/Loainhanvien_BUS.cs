using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class Loainhanvien_BUS
    {
        public DataTable LoadDSLoaiNV()
        {
            Loainhanvien_DAO t = new Loainhanvien_DAO();
            return t.LoadDSLoaiNV();
        }
        public string TimIdTheoTen(string ten)
        {
            Loainhanvien_DAO t = new Loainhanvien_DAO();
            return t.TimIdTheoTen(ten);
        }
    }
}
