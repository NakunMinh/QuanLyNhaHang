using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANG
{
    public partial class QLNhaBep : Form
    {
        public QLNhaBep()
        {
            InitializeComponent();
        }

        private void btnQLNhapXuatHang_Click(object sender, EventArgs e)
        {
            QLHangHoa f = new QLHangHoa();
            f.Show();
        }

        private void btnQLMenu_Click(object sender, EventArgs e)
        {
            QLMon_Loai f = new QLMon_Loai();
            f.Show();
        }

        private void QLNhaBep_Load(object sender, EventArgs e)
        {
            labelChao.Text = DangNhap._manhanvien;
        }
    }
}
