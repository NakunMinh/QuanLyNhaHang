using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static DataTable LoadDSNhanVien()
        {
            return NhanVien_DAO.LoadDSNhanVien();
        }
        public DataTable LoadDSLuong()
        {
            NhanVien_DAO t = new NhanVien_DAO();
            return t.LoadDSLuong();
        }
        public string LayTenChucVuTheoMa(string manhanvien)
        {
            NhanVien_DAO t = new NhanVien_DAO();
            return t.LayTenChucVuTheoMa(manhanvien);
        }
        public string LayTenPasswordTheoMa(string manhanvien)
        {
            NhanVien_DAO t = new NhanVien_DAO();
            return t.LayTenPasswordTheoMa(manhanvien);
        }
        public string LayTenTheoMa(string manhanvien)
        {
            NhanVien_DAO t = new NhanVien_DAO();
            return t.LayTenTheoMa(manhanvien);
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.XoaNhanVien(nv);
        }
        public static bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.CapNhatNhanVien(nv);
        }
        public static DataTable TimKiemTheoTen(string ten)
        {
            return NhanVien_DAO.TimKiemTheoTen(ten);
        }
        public static DataTable TimKiemTheoGioiTinh(string gioitinh)
        {
            return NhanVien_DAO.TimKiemTheoGioiTinh(gioitinh);
        }
        public static DataTable TimKiemTheoChucVu(string chucvu)
        {
            return NhanVien_DAO.TimKiemTheoChucVu(chucvu);
        }
    }
}
