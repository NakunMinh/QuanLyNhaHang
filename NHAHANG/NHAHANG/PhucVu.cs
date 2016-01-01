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
    public partial class PhucVu : Form
    {
        public PhucVu()
        {
            InitializeComponent();
        }

        private void PhucVu_Load(object sender, EventArgs e)
        {
            //loi chao
            labelChao.Text = DangNhap._manhanvien;

            lbBan.Text = DSBan._ban;

            int ban = int.Parse(lbBan.Text);

            //neu ban chua dat
            if (DSBan.mang[ban - 1, 1] == -1)
            {
                btnLapHoaDonMoi.Visible = true;
                btnGiaiPhongBan.Visible = false;
            }
            else //neu ban da co
            {
                btnLapHoaDonMoi.Visible = false;
                btnGiaiPhongBan.Visible = true;
                //load ds loai
                dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
                //load mon an trong hd vao data3
                dataGridView3.DataSource = CTHD_BUS.LoadCTHDTheoMHD(DSBan.mang[ban - 1, 1]);
                //cap nhat lb MHD
                lbMHD.Text = DSBan.mang[ban - 1, 1].ToString();
                //cap nhat tong tien
                float kq = 0;
                int dong = dataGridView3.RowCount;
                for (int i = 0; i < dong; i++)
                {
                    kq += float.Parse(dataGridView3.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());
                }
                txtTongTien.Text = kq.ToString();
            }

        }

        private void btnLapHoaDonMoi_Click(object sender, EventArgs e)
        {
            btnLapHoaDonMoi.Visible = false;
            btnGiaiPhongBan.Visible = true;

            DSBan.dsbutton[int.Parse(lbBan.Text) - 1].BackColor = Color.Red;
            //load ds loai
            dataGridView1.DataSource = LoaiMon_BUS.LoadDSLoaiMon();
            //them 1 hd moi
            HoaDon_DTO hd = new HoaDon_DTO(int.Parse(lbBan.Text), 0);
            HoaDon_BUS.ThemHoaDon(hd);
            //cap nhat mang
            DSBan.mang[int.Parse(lbBan.Text) - 1, 1] = int.Parse(HoaDon_BUS.CoutDS());
            //cap nhat lb
            lbMHD.Text = HoaDon_BUS.CoutDS();
        }

        private void btnGiaiPhongBan_Click(object sender, EventArgs e)
        {
            btnLapHoaDonMoi.Visible = true;
            btnGiaiPhongBan.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            DSBan.dsbutton[int.Parse(lbBan.Text) - 1].BackColor = Color.Green;

            //cap nhat mang
            DSBan.mang[int.Parse(lbBan.Text) - 1, 1] = -1;
        }

        private void btnKetXuat_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "" || txtTienKhachDua.Text == "")
            {
                MessageBox.Show("Thông tin tổng tiền hoặc tiền khách đưa lỗi!");
                return;
            }
            float tongtien = float.Parse(txtTongTien.Text);
            float tienkhachdua = float.Parse(txtTienKhachDua.Text);
            float tienthua = tongtien - tienkhachdua;
            txtTienThua.Text = tienthua.ToString();
            //them vao bao cao thu
            DateTime t = DateTime.Now.Date;
            Baocaothu_DTO bc = new Baocaothu_DTO(t, "Hoa don", float.Parse(txtTongTien.Text));
            Baocaothu_BUS baocaothu = new Baocaothu_BUS();
            baocaothu.ThemBaoCao(bc);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }
            //Them mon vao cthd
            CTHD_DTO cthd = new CTHD_DTO(int.Parse(lbMHD.Text), lbMon.Text, float.Parse(lbDonGia.Text), int.Parse(txtSoLuong.Text));
            bool kq = CTHD_BUS.ThemCTHD(cthd);
            if (kq == false)
            {
                MessageBox.Show("loi!");
            }
            else
            {
                dataGridView3.DataSource = CTHD_BUS.LoadCTHDTheoMHD(int.Parse(lbMHD.Text));
            }
            //hien thi ds
            //cap nhat tong tien
            float tongtien = 0;
            int dong = dataGridView3.RowCount;
            for (int i = 0; i < dong; i++)
            {
                tongtien += float.Parse(dataGridView3.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = e.RowIndex;
            if (temp != -1)
            {
                string t = dataGridView1.Rows[temp].Cells[0].Value.ToString();
                dataGridView2.DataSource = Mon_BUS.LoadDSMonTheoLoai(t);
                lbLoaiMon.Text = t;
            }
            else
                return;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = e.RowIndex;
            if (temp != -1)
            {
                string t = dataGridView2.Rows[temp].Cells[0].Value.ToString();
                lbMon.Text = t;
                lbDonGia.Text = dataGridView2.Rows[temp].Cells[1].Value.ToString();
            }
            else
                return;
        }
    }
}
