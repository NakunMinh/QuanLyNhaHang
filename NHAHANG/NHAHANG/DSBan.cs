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
    public partial class DSBan : Form
    {
        public static string _ban = "0";
        public static int[,] mang;
        public static Button[] dsbutton;
        public DSBan()
        {
            InitializeComponent();
        }

        private void DSBan_Load(object sender, EventArgs e)
        {
            //khoi tao mang
            mang = new int[30, 2];
            for (int i = 0; i < 30; i++)
            {
                mang[i, 0] = i + 1;
                mang[i, 1] = -1;
            }
            //khoi tao mang button
            dsbutton = new Button[30];

                for (int i = 1; i <= 30; i++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i.ToString();
                    btn.Text = "Bàn " + i.ToString();
                    btn.Width = 70;
                    btn.Height = 70;
                    btn.Tag = i;
                    btn.BackColor = Color.Green;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += btn_Click;
                    dsbutton[i - 1] = btn;
                }
        }

        void btn_Click(object sender, EventArgs e)
        {
            _ban = ((Button)sender).Tag.ToString();
            PhucVu pv = new PhucVu();
            pv.Show();
        }
    }
}
