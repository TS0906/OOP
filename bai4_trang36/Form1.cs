using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4_trang36
{
    public partial class Form1 : Form
    {
        private CTime thoiGian;
        public Form1()
        {
            InitializeComponent();
            thoiGian = new CTime();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int gio = int.Parse(txtGio.Text);
            int phut = int.Parse(txtPhut.Text);
            int giay = int.Parse(txtGiay.Text);

            thoiGian.NhapThoiGian(gio, phut, giay);
            int giaynew = int.Parse(txtGiaynew.Text);
            txtThoigian.Text = thoiGian.XuatThoiGian();
        }
        private void butCong_Click(object sender, EventArgs e)
        {
            int giayThem = int.Parse(txtGiaynew.Text);
            thoiGian = thoiGian + giayThem;
            txtKq.Text = thoiGian.XuatThoiGian();
        }
        private void butTru_Click(object sender, EventArgs e)
        {
            int giayThem = int.Parse(txtGiaynew.Text);
            thoiGian = thoiGian - giayThem;
            txtKq.Text = thoiGian.XuatThoiGian();
        }
        private void butCong1_Click(object sender, EventArgs e)
        {
            thoiGian++;
            txtKq.Text = thoiGian.XuatThoiGian();
        }
        private void butTru1_Click(object sender, EventArgs e)
        {
            thoiGian--;
            txtKq.Text = thoiGian.XuatThoiGian();
        }
    }
}
