using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        Phanso ps1, ps2;

        public Form1()
        {
            InitializeComponent();
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void kabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps1 = new Phanso();
            ps2 = new Phanso();
            txtKQ.Enabled = false;
        }

      

        private void butnhapps_Click(object sender, EventArgs e)
        {
            if ((txtTS1.Text == "") || (txtTS2.Text == "") || (txtMS1.Text == "") || (txtMS2.Text == ""))
            {
                MessageBox.Show(" Bạn phải nhập đầy đủ tử số và mẫu số");
            }
            else
            {
                ps1 = new Phanso(int.Parse(txtTS1.Text), int.Parse(txtMS1.Text));
                ps2 = new Phanso(int.Parse(txtTS1.Text), int.Parse(txtMS2.Text));
                txtPS1.Text = ps1.show();
                txtPS2.Text = ps2.show();
            }
        }
        private void butcong_Click(object sender, EventArgs e)
        {
            Phanso kq = new Phanso();
            kq = ps1 + ps2;
            txtKQ.Text = kq.show();
        }
        private void buttru_Click(object sender, EventArgs e)
        {
            Phanso kq = new Phanso();
            kq = ps1 - ps2;
            txtKQ.Text = kq.show();
        }

        private void butnhan_Click(object sender, EventArgs e)
        {
            Phanso kq = new Phanso();
            kq = ps1 * ps2;
            txtKQ.Text = kq.show();
        }

        private void butchia_Click(object sender, EventArgs e)
        {
            Phanso kq = new Phanso();
            kq = ps1 / ps2;
            txtKQ.Text = kq.show();
        }

        private void butso_sanh_Click(object sender, EventArgs e)
        {
            if (ps1 == ps2)
            {
                txtKQ.Text = "Phân số 1 và Phân số 2 bằng nhau.";
            }
            else if (ps1 > ps2)
            {
                txtKQ.Text = "Phân số 1 lớn hơn Phân số 2.";
            }
            else
            {
                txtKQ.Text = "Phân số 1 nhỏ hơn Phân số 2.";
            }

        }
    }
}
