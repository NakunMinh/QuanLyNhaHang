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
    public partial class QLHangHoa : Form
    {
        public QLHangHoa()
        {
            InitializeComponent();
        }
        void bingdingXoa()
        {
            txtIDXoa.DataBindings.Clear();
            txtIDXoa.DataBindings.Add("Text", dgvXoa.DataSource, "Id");

            txtTenXoa.DataBindings.Clear();
            txtTenXoa.DataBindings.Add("Text", dgvXoa.DataSource, "Ten");

            txtDonGiaXoa.DataBindings.Clear();
            txtDonGiaXoa.DataBindings.Add("Text", dgvXoa.DataSource, "Dongia");

            txtSoLuongXoa.DataBindings.Clear();
            txtSoLuongXoa.DataBindings.Add("Text", dgvXoa.DataSource, "Soluong");
        }

        void bingdingSua()
        {
            txtIDSua.DataBindings.Clear();
            txtIDSua.DataBindings.Add("Text", dgvXoa.DataSource, "Id");

            txtTenSua.DataBindings.Clear();
            txtTenSua.DataBindings.Add("Text", dgvXoa.DataSource, "Ten");

            txtDonGiaSua.DataBindings.Clear();
            txtDonGiaSua.DataBindings.Add("Text", dgvXoa.DataSource, "Dongia");

            txtSoLuongSua.DataBindings.Clear();
            txtSoLuongSua.DataBindings.Add("Text", dgvXoa.DataSource, "Soluong");
        }
        private void QLHangHoa_Load(object sender, EventArgs e)
        {
            //chao
            labelChao.Text = DangNhap._manhanvien;

            tabControl.SelectedTab = tabPage1;
            HangHoa_BUS t = new HangHoa_BUS();
            dgvDS.DataSource = t.LoadHangHoa();
            dgvThem.DataSource = t.LoadHangHoa();
            dgvXoa.DataSource = t.LoadHangHoa();
            bingdingXoa();
            dgvSua.DataSource = t.LoadHangHoa();
            bingdingSua();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = "";
            string ten = "";
            float dongia = 0;
            int soluong = 0;
            //kiem tra
            if (txtIDThem.Text == "" || txtTenThem.Text == "" || txtDonGiaThem.Text == "" || txtSoLuongThem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
            }
            //lay du lieu tu form
            else
            {
                id = txtIDThem.Text;
                ten = txtTenThem.Text;
                dongia = float.Parse(txtDonGiaThem.Text);
                soluong = int.Parse(txtSoLuongThem.Text);

                //thao tac them
                HangHoa_DTO hh = new HangHoa_DTO(id, ten, dongia, soluong);
                HangHoa_BUS t = new HangHoa_BUS();
                if (!t.ThemHangHoa(hh))
                    MessageBox.Show("Thêm không thành công. Vui lòng thử lại!.");

                //hien thi lai form
                dgvThem.DataSource = t.LoadHangHoa();

                //hien thi lai tab ds
                dgvDS.DataSource = t.LoadHangHoa();
                //hien thi lai tab xoa
                dgvXoa.DataSource = t.LoadHangHoa();
                bingdingXoa();
                //hien thi lai tab sua
                dgvSua.DataSource = t.LoadHangHoa();
                bingdingSua();
                //them vao bao cao chi
                DateTime ngay = DateTime.Now.Date;
                Baocaochi_DTO bc = new Baocaochi_DTO(ngay, "Hang hoa", float.Parse(txtDonGiaThem.Text) * int.Parse(txtSoLuongThem.Text));
                Baocaochi_BUS baocaochi = new Baocaochi_BUS();
                baocaochi.ThemBaoCao(bc);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lay du lieu tu form
            string id = txtIDXoa.Text;
            string ten = txtTenXoa.Text;
            float dongia = float.Parse(txtDonGiaXoa.Text);
            int soluong = int.Parse(txtSoLuongXoa.Text);

            //thao tac them
            HangHoa_DTO hh = new HangHoa_DTO(id, ten, dongia, soluong);
            HangHoa_BUS t = new HangHoa_BUS();
            if (!t.XoaHangHoa(hh))
                MessageBox.Show("Xóa không thành công. Vui lòng thử lại!.");

            //hien thi lai form
            dgvXoa.DataSource = t.LoadHangHoa();
            bingdingXoa();

            //hien thi lai tab ds
            dgvDS.DataSource = t.LoadHangHoa();
            //hien thi lai tab them
            dgvThem.DataSource = t.LoadHangHoa();
            //hien thi lai tab sua
            dgvSua.DataSource = t.LoadHangHoa();
            bingdingSua();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //lay du lieu tu form
            string id = txtIDSua.Text;
            string ten = txtTenSua.Text;
            float dongia = float.Parse(txtDonGiaSua.Text);
            int soluong = int.Parse(txtSoLuongSua.Text);

            //thao tac them
            HangHoa_DTO hh = new HangHoa_DTO(id, ten, dongia, soluong);
            HangHoa_BUS t = new HangHoa_BUS();
            if (!t.CapNhatHangHoa(hh))
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại!.");

            //hien thi lai form
            dgvSua.DataSource = t.LoadHangHoa();
            bingdingSua();

            //hien thi lai tab ds
            dgvDS.DataSource = t.LoadHangHoa();
            //hien thi lai tab them
            dgvThem.DataSource = t.LoadHangHoa();
            //hien thi lai tab xoa
            dgvXoa.DataSource = t.LoadHangHoa();
            bingdingXoa();
        }
    }
}
