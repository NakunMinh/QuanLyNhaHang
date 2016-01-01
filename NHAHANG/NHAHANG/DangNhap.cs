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
    public partial class DangNhap : Form
    {
        public static string _manhanvien = string.Empty;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string ma = txtMaNhanVien.Text;
            string password = txtPassword.Text;

            if (txtMaNhanVien.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            // dua du lieu chao
            NhanVien_BUS nv = new NhanVien_BUS();
            _manhanvien = nv.LayTenTheoMa(ma);

            BUS.DangNhap dn = new BUS.DangNhap();
            string chucvu = dn.ChucNangDangNhap(ma, password);

            switch (chucvu)
            {
                case"":
                    {
                        MessageBox.Show("Sai ma nhan vien or password!");
                        return;
                        break;
                    }
                case "Quản lý nhân sự":
                    {
                        FormNhanVien f = new FormNhanVien();
                        f.Show();
                        break;
                    }
                case "Quản lý cơ sở vật chất":
                    {
                        QLThietBi f = new QLThietBi();
                        f.Show();
                        break;
                    }
                case "Tiếp tân":
                    {
                        DSBan f = new DSBan();
                        f.Show();
                        break;
                    }
                case "Kế toán":
                    {
                        QLBaoCao f = new QLBaoCao();
                        f.Show();
                        break;
                    }
                case "Tổ chức sự kiện":
                    {
                        QLTiec f = new QLTiec();
                        f.Show();
                        break;
                    }
                case "Quản lý nhà bếp":
                    {
                        QLNhaBep f = new QLNhaBep();
                        f.Show();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Bạn không là nhân viên quản lý!");
                        return;
                        break;
                    }
            }
            //lay chuc vu
            //phan cong form
        }
    }
}
