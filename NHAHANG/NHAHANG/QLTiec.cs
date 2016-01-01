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
    public partial class QLTiec : Form
    {
        public QLTiec()
        {
            InitializeComponent();
        }
        void bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGridViewDSTiec.DataSource, "Id");

            txtNgayToChuc.DataBindings.Clear();
            txtNgayToChuc.DataBindings.Add("Text", dataGridViewDSTiec.DataSource, "Ngaytochuc");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataGridViewDSTiec.DataSource, "Gia");
        }
        private void QLTiec_Load(object sender, EventArgs e)
        {
            //chao
            labelChao.Text = DangNhap._manhanvien;

            //hien thi ds mon
            dataGridViewDSMon.DataSource = Mon_BUS.LoadDSMon();
            //hien thi ds tiec
            Tiec_BUS t = new Tiec_BUS();
            dataGridViewDSTiec.DataSource = t.LoadTiec();
            //bingding
            bingding();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            //hien thi ds tiec
            Tiec_BUS t = new Tiec_BUS();
            dataGridViewDSTiec.DataSource = t.LoadTiec();
            //bingding
            bingding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string id = txtID.Text;
            DateTime ngaytochuc = DateTime.Parse(txtNgayToChuc.Text);
            float gia = float.Parse(txtTongTien.Text);

            Tiec_DTO t = new Tiec_DTO(id, ngaytochuc, gia);
            //them
            Tiec_BUS t1 = new Tiec_BUS();
            t1.ThemTiec(t);
            //cap nhat danh sach tiec
            dataGridViewDSTiec.DataSource = t1.LoadTiec();
            //bingding
            bingding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string id = txtID.Text;
            DateTime ngaytochuc = DateTime.Parse(txtNgayToChuc.Text);
            float gia = float.Parse(txtTongTien.Text);

            Tiec_DTO t = new Tiec_DTO(id, ngaytochuc, gia);
            //xoa
            Tiec_BUS t1 = new Tiec_BUS();
            t1.XoaTiec(t);
            //cap nhat danh sach tiec
            dataGridViewDSTiec.DataSource = t1.LoadTiec();
            //bingding
            bingding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string id = txtID.Text;
            DateTime ngaytochuc = DateTime.Parse(txtNgayToChuc.Text);
            float gia = float.Parse(txtTongTien.Text);

            Tiec_DTO t = new Tiec_DTO(id, ngaytochuc, gia);
            //xoa
            Tiec_BUS t1 = new Tiec_BUS();
            t1.CapNhatTiec(t);
            //cap nhat danh sach tiec
            dataGridViewDSTiec.DataSource = t1.LoadTiec();
            //bingding
            bingding();
        }

        private void dataGridViewDSTiec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu
            string id = dataGridViewDSTiec.CurrentRow.Cells[0].Value.ToString();
            //load ds da dat tu Id tiec
            CTTiec_BUS t = new CTTiec_BUS();
            dataGridViewDSDaDat.DataSource = t.LoadCTHDTheoIDTiec(id);
            //cap nhat tong tien
            float kq = 0;
            int dong = dataGridViewDSDaDat.RowCount;
            for (int i = 0; i < dong; i++)
            {
                kq += float.Parse(dataGridViewDSDaDat.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridViewDSDaDat.Rows[i].Cells[2].Value.ToString());
            }
            labelTongTien.Text = kq.ToString();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            //lay du lieu
            string id = dataGridViewDSTiec.CurrentRow.Cells[0].Value.ToString();
            string mon = dataGridViewDSMon.CurrentRow.Cells[1].Value.ToString();
            float dongia = float.Parse(dataGridViewDSMon.CurrentRow.Cells[2].Value.ToString());

            int soluong = 0;
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! Vui lòng thử lại.");
                return;
            }
            else
            {
                soluong = int.Parse(txtSoLuong.Text);
            }
            CTTiec_DTO tiec = new CTTiec_DTO(id, mon, dongia, soluong);
            //them vao CTTiec
            CTTiec_BUS t = new CTTiec_BUS();
            t.ThemCTTiec(tiec);
            //hien thi CTTiec
            dataGridViewDSDaDat.DataSource = t.LoadCTHDTheoIDTiec(id);
            //cap nhat tong tien
            float kq = 0;
            int dong = dataGridViewDSDaDat.RowCount;
            for (int i = 0; i < dong; i++)
            {
                kq += (float.Parse(dataGridViewDSDaDat.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridViewDSDaDat.Rows[i].Cells[2].Value.ToString()));
            }
            labelTongTien.Text = kq.ToString();
            //cap nhat tong tien TIEC
            Tiec_BUS tiecbus = new Tiec_BUS();
            tiecbus.CapNhatTongTien(id, float.Parse(labelTongTien.Text));
            //cap nhat ds
            dataGridViewDSTiec.DataSource = tiecbus.LoadTiec();
            //bingding
            bingding();
        }
    }
}
