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
    public partial class QLMon_Loai : Form
    {
        public QLMon_Loai()
        {
            InitializeComponent();
        }

        private void QLMon_Loai_Load(object sender, EventArgs e)
        {
            //load danh sach loai mon
            dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
            bingdingLoaiMon();
            //do du lieu vao combobox
            comboBoxThuocLoai.DataSource = LoaiMon_BUS.DSMaLoaiMon();
            comboBoxThuocLoai.DisplayMember = "Maloaimon";
            //load danh sach mon an
            dataGridView2.DataSource = Mon_BUS.LoadDSMon();
            bingdingMon();
        }
        void bingdingLoaiMon()
        {
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dataGridView1.DataSource, "Maloaimon");

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dataGridView1.DataSource, "Tenloaimon");
        }
        void bingdingMon()
        {
            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", dataGridView2.DataSource, "Mamon");

            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", dataGridView2.DataSource, "Tenmon");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dataGridView2.DataSource, "Dongia");

            comboBoxThuocLoai.DataBindings.Clear();
            comboBoxThuocLoai.DataBindings.Add("Text", dataGridView2.DataSource, "Loai");
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string maloaimon = txtMaLoai.Text;
            string tenloaimon = txtTenLoai.Text;

            LoaiMon_DTO loaimon = new LoaiMon_DTO(maloaimon, tenloaimon);

            bool kt = LoaiMon_BUS.ThemLoaiMon(loaimon);

            if (kt == false)
            {
                //khong thanh cong
                MessageBox.Show("Mã loại món đã tồn tại!");
                 return;
            }
            else
            {
                //thanh cong
                MessageBox.Show("Thêm loại món thành công!");
                //load lai danh sach
                dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
                bingdingLoaiMon();
                //do du lieu vao comboboxLoai
                comboBoxThuocLoai.DataSource = LoaiMon_BUS.DSMaLoaiMon();
                comboBoxThuocLoai.DisplayMember = "Maloaimon";
            }
            
        }

        private void btnDanhSachLoai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
            bingdingLoaiMon();
        }

        private void btnCapNhatLoai_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string maloaimon = txtMaLoai.Text;
            string tenloaimon = txtTenLoai.Text;

            LoaiMon_DTO loaimon = new LoaiMon_DTO(maloaimon, tenloaimon);

            bool kt = LoaiMon_BUS.CapNhatLoaiMon(loaimon);

            if (kt == false)
            {
                //khong thanh cong
                MessageBox.Show("Mã loại món đã tồn tại!");
                return;
            }
            else
            {
                //thanh cong
                MessageBox.Show("Cập nhật loại món thành công!");
                //load lai danh sach
                dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
                bingdingLoaiMon();
                //do du lieu vao comboboxLoai
                comboBoxThuocLoai.DataSource = LoaiMon_BUS.DSMaLoaiMon();
                comboBoxThuocLoai.DisplayMember = "Maloaimon";
            }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string maloaimon = txtMaLoai.Text;
            string tenloaimon = txtTenLoai.Text;

            LoaiMon_DTO loaimon = new LoaiMon_DTO(maloaimon, tenloaimon);

            bool kt = LoaiMon_BUS.XoaLoaiMon(loaimon);

            if (kt == false)
            {
                //khong thanh cong
                MessageBox.Show("Không thành công! Vui lòng thử lại.");
                return;
            }
            else
            {
                //thanh cong
                MessageBox.Show("Xóa loại món thành công!");
                //load lai danh sach
                dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
                bingdingLoaiMon();
                //do du lieu vao comboboxLoai
                comboBoxThuocLoai.DataSource = LoaiMon_BUS.DSMaLoaiMon();
                comboBoxThuocLoai.DisplayMember = "Maloaimon";
            }
        }

        private void btnDanhSachMon_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Mon_BUS.LoadDSMon();
            bingdingMon();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string mamon = txtMaMon.Text;
            string tenmon = txtTenMon.Text;
            float dongia = float.Parse(txtDonGia.Text);
            string loai = comboBoxThuocLoai.Text;

            Mon_DTO mon = new Mon_DTO(mamon, tenmon, dongia, loai);

            bool kt = Mon_BUS.ThemMon(mon);

            if (kt == false)
            {
                MessageBox.Show("Mã món đã tồn tại!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm món thành công!");
                dataGridView2.DataSource = Mon_BUS.LoadDSMon();
                bingdingMon();
            }
        }

        private void btnCapNhatMon_Click(object sender, EventArgs e)
        {
            string mamon = txtMaMon.Text;
            string tenmon = txtTenMon.Text;
            float dongia = float.Parse(txtDonGia.Text);
            string loai = comboBoxThuocLoai.Text;

            Mon_DTO mon = new Mon_DTO(mamon, tenmon, dongia, loai);

            bool kt = Mon_BUS.CapNhatMon(mon);

            if (kt == false)
            {
                MessageBox.Show("Mã món đã tồn tại!");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật món thành công!");
                dataGridView2.DataSource = Mon_BUS.LoadDSMon();
                bingdingMon();
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            string mamon = txtMaMon.Text;
            string tenmon = txtTenMon.Text;
            float dongia = float.Parse(txtDonGia.Text);
            string loai = comboBoxThuocLoai.Text;

            Mon_DTO mon = new Mon_DTO(mamon, tenmon, dongia, loai);

            bool kt = Mon_BUS.XoaMon(mon);

            if (kt == false)
            {
                MessageBox.Show("Thao tác không thành công!");
                return;
            }
            else
            {
                MessageBox.Show("Xóa món thành công!");
                dataGridView2.DataSource = Mon_BUS.LoadDSMon();
                bingdingMon();
            }
        }
    }
}
