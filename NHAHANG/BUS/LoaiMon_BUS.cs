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
    public class LoaiMon_BUS
    {
        public static DataTable LoadDSLoaiMon()
        {
            return LoaiMon_DAO.LoadDSLoaiMon();
        }
        public static bool ThemLoaiMon(LoaiMon_DTO loai)
        {
            return LoaiMon_DAO.ThemLoaiMon(loai);
        }
        public static bool XoaLoaiMon(LoaiMon_DTO loai)
        {
            return LoaiMon_DAO.XoaLoaiMon(loai);
        }
        public static bool CapNhatLoaiMon(LoaiMon_DTO loai)
        {
            return LoaiMon_DAO.CapNhatLoaiMon(loai);
        }
        public static DataTable DSMaLoaiMon()
        {
            return LoaiMon_DAO.DSMaLoaiMon();
        }
    }
}
