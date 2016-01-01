using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace NHAHANG
{
    public partial class QLBaoCao : Form
    {
        public QLBaoCao()
        {
            InitializeComponent();
        }

        private void QLBaoCao_Load(object sender, EventArgs e)
        {
            //chao
            labelChao.Text = DangNhap._manhanvien;

            //load ds thu theo ngay
            Baocaothu_BUS t = new Baocaothu_BUS();
            dataGridViewBaoCaoThu.DataSource = t.LoadDS(DateTime.Parse(dateTimePickerNgay.Text));
            //tinh tong thu
            int dong = dataGridViewBaoCaoThu.RowCount;
            float kq = 0;

            for (int i = 0; i < dong; i++)
            {
                kq += float.Parse(dataGridViewBaoCaoThu.Rows[i].Cells[2].Value.ToString());
            }
            labelTongThu.Text = kq.ToString();

            //load ds chi theo ngay
            Baocaochi_BUS t1 = new Baocaochi_BUS();
            dataGridViewChi.DataSource = t1.LoadDS(DateTime.Parse(dateTimePickerNgay.Text));
            //tinh tong chi
            int dong1 = dataGridViewChi.RowCount;
            float kq1 = 0;

            for (int i = 0; i < dong1; i++)
            {
                kq1 += float.Parse(dataGridViewChi.Rows[i].Cells[2].Value.ToString());
            }
            labelTongChi.Text = kq1.ToString();

            //load nv (ten, chucvu, chisoluong)
            NhanVien_BUS nhanvien = new NhanVien_BUS();
            dataGridViewLuongNhanVien.DataSource = nhanvien.LoadDSLuong();
            //tinh tong luong
            int dong2 = dataGridViewLuongNhanVien.RowCount;
            float kq2 = 0;

            for (int i = 0; i < dong2; i++)
            {
                kq2 += (float.Parse(dataGridViewLuongNhanVien.Rows[i].Cells[2].Value.ToString()) * 2000);
            }
            labelTongLuong.Text = kq2.ToString();

            //du lieu tinh loi nhuan
            labelThu.Text = labelTongThu.Text;
            labelChi.Text = labelTongChi.Text;
            labelLuong.Text = labelTongLuong.Text;
            //loi nhuan
            labelLoiNhuan.Text = (float.Parse(labelThu.Text) - float.Parse(labelChi.Text) - float.Parse(labelLuong.Text)).ToString();
        }
    }
}
