using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        string _manhanvien;

        public string Manhanvien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }
        string _tennhanvien;

        public string Tennhanvien
        {
            get { return _tennhanvien; }
            set { _tennhanvien = value; }
        }
        DateTime _ngaysinh;

        public DateTime Ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        string _gioitinh;

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        string _cmnd;

        public string Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        float _luong;

        public float Luong
        {
            get { return _luong; }
            set { _luong = value; }
        }

        string _chucvu;

        public string Chucvu
        {
            get { return _chucvu; }
            set { _chucvu = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public NhanVien_DTO(string ma, string ten, DateTime ns, string gt, string cm, string dc, string sdt, string mail, float luong, string chucvu, string pass)
        {
            _manhanvien = ma;
            _tennhanvien = ten;
            _ngaysinh = ns;
            _gioitinh = gt;
            _cmnd = cm;
            _diachi = dc;
            _sdt = sdt;
            _email = mail;
            _luong = luong;
            _chucvu = chucvu;
            _password = pass;
        }
    }
}
