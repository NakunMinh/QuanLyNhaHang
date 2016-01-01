using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTTiec_DTO
    {
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _mon;

        public string Mon
        {
            get { return _mon; }
            set { _mon = value; }
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
        public CTTiec_DTO(string id, string mon, float dongia, int soluong)
        {
            _id = id;
            _mon = mon;
            _dongia = dongia;
            _soluong = soluong;
        }
    }
}
