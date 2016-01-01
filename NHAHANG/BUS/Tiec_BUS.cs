using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class Tiec_BUS
    {
        public DataTable LoadTiec()
        {
            DAO.Tiec_DAO t = new Tiec_DAO();
            return t.LoadTiec();
        }
        public bool ThemTiec(Tiec_DTO tiec)
        {
            Tiec_DAO t = new Tiec_DAO();
            return t.ThemTiec(tiec);
        }
        public bool XoaTiec(Tiec_DTO tiec)
        {
            Tiec_DAO t = new Tiec_DAO();
            return t.XoaTiec(tiec);
        }
        public bool CapNhatTiec(Tiec_DTO tiec)
        {
            Tiec_DAO t = new Tiec_DAO();
            return t.CapNhatTiec(tiec);
        }
        public bool CapNhatTongTien(string id, float tongtien)
        {
            Tiec_DAO t = new Tiec_DAO();
            return t.CapNhatTongTien(id, tongtien);
        }
    }
}
