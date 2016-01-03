using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace NHAHANG
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            //chao
            labelChao.Text = DangNhap._manhanvien;

            dataGridView1.DataSource = NhanVien_BUS.LoadDSNhanVien();
            Loainhanvien_BUS t = new Loainhanvien_BUS();
            comboBoxChucVu.DataSource = t.LoadDSLoaiNV();
            comboBoxChucVu.DisplayMember = "Tenloainhanvien";
            bingding();
        }

        void bingding()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "Manhanvien");

            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "Tennhanvien");

            dateTimePickerNgaySinh.DataBindings.Clear();
            dateTimePickerNgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "Ngaysinh");

            comboBoxGioiTinh.DataBindings.Clear();
            comboBoxGioiTinh.DataBindings.Add("Text", dataGridView1.DataSource, "Gioitinh");

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dataGridView1.DataSource, "CMND");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "Diachi");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridView1.DataSource, "Sdt");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");

            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", dataGridView1.DataSource, "Luong");

            comboBoxChucVu.DataBindings.Clear();
            comboBoxChucVu.DataBindings.Add("Text", dataGridView1.DataSource, "Tenloainhanvien");
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string Manhanvien = txtMaNhanVien.Text;
            string Tennhanvien = txtTenNhanVien.Text;
            DateTime Ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Text);
            string Gioitinh = comboBoxGioiTinh.Text;
            string CMND = txtCMND.Text;
            string Diachi = txtDiaChi.Text;
            string Sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            float Luong = float.Parse(txtLuong.Text);
            Loainhanvien_BUS t = new Loainhanvien_BUS();
            string loainhanvien = t.TimIdTheoTen(comboBoxChucVu.Text);
            NhanVien_DTO nvObj = new NhanVien_DTO(Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong, loainhanvien, "123");
            if (NhanVien_BUS.ThemNhanVien(nvObj) == false)
            {
                MessageBox.Show("Đã tồn tại nhân viên này");
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = NhanVien_BUS.LoadDSNhanVien();
                bingding();
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string Manhanvien = txtMaNhanVien.Text;
            string Tennhanvien = txtTenNhanVien.Text;
            DateTime Ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Text);
            string Gioitinh = comboBoxGioiTinh.Text;
            string CMND = txtCMND.Text;
            string Diachi = txtDiaChi.Text;
            string Sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            float Luong = float.Parse(txtLuong.Text);
            Loainhanvien_BUS t = new Loainhanvien_BUS();
            string loainhanvien = t.TimIdTheoTen(comboBoxChucVu.Text);
            NhanVien_DTO nvObj = new NhanVien_DTO(Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong, loainhanvien, "123");
            if (NhanVien_BUS.XoaNhanVien(nvObj) == false)
            {
                MessageBox.Show("Không thành công!");
                return;
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                dataGridView1.DataSource = NhanVien_BUS.LoadDSNhanVien();
                bingding();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string Manhanvien = txtMaNhanVien.Text;
            string Tennhanvien = txtTenNhanVien.Text;
            DateTime Ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Text);
            string Gioitinh = comboBoxGioiTinh.Text;
            string CMND = txtCMND.Text;
            string Diachi = txtDiaChi.Text;
            string Sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            float Luong = float.Parse(txtLuong.Text);
            Loainhanvien_BUS t = new Loainhanvien_BUS();
            string loainhanvien = t.TimIdTheoTen(comboBoxChucVu.Text);
            NhanVien_DTO nvObj = new NhanVien_DTO(Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong, loainhanvien, "123");
            if (NhanVien_BUS.CapNhatNhanVien(nvObj) == false)
            {
                MessageBox.Show("Cập nhật không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!");
                dataGridView1.DataSource = NhanVien_BUS.LoadDSNhanVien();
                bingding();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm!");
            }
            else
            {
                if (radioButtonTheoTen.Checked)
                {
                    dataGridView1.DataSource = NhanVien_BUS.TimKiemTheoTen(txtTimKiem.Text);
                    //bingding();
                }
                if(radioButtonTheoGioiTinh.Checked)
                {
                    dataGridView1.DataSource = NhanVien_BUS.TimKiemTheoGioiTinh(txtTimKiem.Text);
                    //bingding();
                }
                if (radioButtonTheoChucVu.Checked)
                {
                    dataGridView1.DataSource = NhanVien_BUS.TimKiemTheoChucVu(txtTimKiem.Text);
                    //bingding();
                }
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhanVien_BUS.LoadDSNhanVien();
            bingding();
        }
    }
}
