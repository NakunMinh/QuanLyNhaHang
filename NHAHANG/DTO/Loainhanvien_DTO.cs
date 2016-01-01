using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loainhanvien_DTO
    {
        string _idloainhanvien;

        public string Idloainhanvien
        {
            get { return _idloainhanvien; }
            set { _idloainhanvien = value; }
        }
        string _tenloainhanvien;

        public string Tenloainhanvien
        {
            get { return _tenloainhanvien; }
            set { _tenloainhanvien = value; }
        }
        float _chisoluong;

        public float Chisoluong
        {
            get { return _chisoluong; }
            set { _chisoluong = value; }
        }
        public Loainhanvien_DTO(string id, string ten, float chiso)
        {
            _idloainhanvien = id;
            _tenloainhanvien = ten;
            _chisoluong = chiso;
        }
    }
}
