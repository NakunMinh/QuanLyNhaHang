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
    public partial class QLThietBi : Form
    {
        public QLThietBi()
        {
            InitializeComponent();
        }
        void bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDSThietBi.DataSource, "Id");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDSThietBi.DataSource, "Ten");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDSThietBi.DataSource, "Dongia");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDSThietBi.DataSource, "Soluong");
        }
        private void QLThietBi_Load(object sender, EventArgs e)
        {
            //chao
            labelChao.Text = DangNhap._manhanvien;

            CSVC_BUS t = new CSVC_BUS();
            dgvDSThietBi.DataSource = t.LoadCSVC();
            bingding();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            CSVC_BUS t = new CSVC_BUS();
            dgvDSThietBi.DataSource = t.LoadCSVC();
            bingding();
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            //lay du lieu tu form
            string id = txtID.Text;
            string ten = txtTen.Text;
            float dongia = float.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            //thao tac them
            CSVC_DTO csvc = new CSVC_DTO(id, ten, dongia, soluong);
            CSVC_BUS t = new CSVC_BUS();
            if (!t.ThemCSVC(csvc))
                MessageBox.Show("Thêm không thành công. Vui lòng thử lại!");

            //hien thi lai danh sach
            dgvDSThietBi.DataSource = t.LoadCSVC();
            bingding();

            //them vao bao cao chi
            DateTime ngay = DateTime.Now.Date;
            Baocaochi_DTO bc = new Baocaochi_DTO(ngay, "Thiet bi", float.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text));
            Baocaochi_BUS baocaochi = new Baocaochi_BUS();
            baocaochi.ThemBaoCao(bc);
        }

        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            //lay du lieu tu form
            string id = txtID.Text;
            string ten = txtTen.Text;
            float dongia = float.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            //thao tac xoa
            CSVC_DTO csvc = new CSVC_DTO(id, ten, dongia, soluong);
            CSVC_BUS t = new CSVC_BUS();
            if (!t.XoaCSVC(csvc))
                MessageBox.Show("Xóa không thành công. Vui lòng thử lại!");

            //hien thi lai danh sach
            dgvDSThietBi.DataSource = t.LoadCSVC();
            bingding();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            //lay du lieu tu form
            string id = txtID.Text;
            string ten = txtTen.Text;
            float dongia = float.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            //thao tac cap nhat
            CSVC_DTO csvc = new CSVC_DTO(id, ten, dongia, soluong);
            CSVC_BUS t = new CSVC_BUS();
            if (!t.CapNhatCSVC(csvc))
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại!");

            //hien thi lai danh sach
            dgvDSThietBi.DataSource = t.LoadCSVC();
            bingding();
        }
    }
}
