using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
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
        public HangHoa_DTO(string id, string ten, float dongia, int soluong)
        {
            _id = id;
            _ten = ten;
            _dongia = dongia;
            _soluong = soluong;
        }
    }
}
