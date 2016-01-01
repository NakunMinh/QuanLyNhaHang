using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DangNhap
    {
        public string ChucNangDangNhap(string ma, string password)
        {
            try
            {
                NhanVien_BUS nv = new NhanVien_BUS();
                string ps = nv.LayTenPasswordTheoMa(ma);
                ps = ps.Trim();
                if (ps == password)
                {
                    return nv.LayTenChucVuTheoMa(ma);
                }
            }
            catch
            {
                return "";
            }
            return "";
        }
    }
}
