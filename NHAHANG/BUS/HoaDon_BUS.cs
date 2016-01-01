using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static void ThemHoaDon(HoaDon_DTO hd)
        {
            HoaDon_DAO.ThemHoaDon(hd);
        }
        public static string CoutDS()
        {
            return HoaDon_DAO.CoutDS();
        }
    }
}
