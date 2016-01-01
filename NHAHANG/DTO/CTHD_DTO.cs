using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHD_DTO
    {
        int _mahoadon;

        public int Mahoadon
        {
            get { return _mahoadon; }
            set { _mahoadon = value; }
        }


        string _tenmon;

        public string Tenmon
        {
            get { return _tenmon; }
            set { _tenmon = value; }
        }
        float _dongia;

        public float Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        int _soluong;

        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public CTHD_DTO(int ma, string ten, float dg, int sl)
        {
            _mahoadon = ma;
            _tenmon = ten;
            _dongia = dg;
            _soluong = sl;
        }
    }
}
