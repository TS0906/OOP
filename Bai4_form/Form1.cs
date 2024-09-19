using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_form
{
    public partial class Form1 : Form
    {
        PhanSo ps1, ps2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ps1 = new PhanSo();
            ps2 = new PhanSo();
            txtPS1.Text = ps1.show();
            txtPS2.Text = ps2.show();
        }

        bool ktNhap()
        {
            if ((txtTS.Text != " ") && (txtMS.Text != ""))
                return true;

            else if (txtTS.Text == "")
                MessageBox.Show(" Bạn chưa nhập Tử số ");
            else
                MessageBox.Show(" Bạn chưa nhập Mẫu số ");
            return false;
        }

        private void BtNhapPS_Click(object sender, EventArgs e)
        {
            if (rdPS1.Checked == true)
            {

                if (ktNhap() == true)
                    ps1 = new PhanSo(int.Parse(txtTS.Text), int.Parse(txtMS.Text));
                txtPS1.Text = ps1.show();
            }
            else if (rdPS2.Checked == true)
            {
                ps2 = new PhanSo();
                if (ktNhap() == true)
                    ps2 = new PhanSo(int.Parse(txtTS.Text), int.Parse(txtMS.Text));
                txtPS2.Text = ps2.show();
            }
        }

        private void BtCongPS_Click(object sender, EventArgs e)
        {
            PhanSo kq = new PhanSo();

            kq = ps1.Cong(ps2);
            txtKQ.Text = kq.show();
        }

        private void BtTruPS_Click(object sender, EventArgs e)
        {
            PhanSo kq = new PhanSo();

            kq = ps1.Tru(ps2);
            this.txtKQ.Text = kq.show();
        }

        private void BtNhanPS_Click(object sender, EventArgs e)
        {
            PhanSo kq = new PhanSo();

            kq = ps1.Nhan(ps2);
            this.txtKQ.Text = kq.show();
        }

        

        private void BtChiaPS_Click(object sender, EventArgs e)
        {
            PhanSo kq = new PhanSo();

            kq = ps1.Chia(ps2);
            this.txtKQ.Text = kq.show();
        }
    }
}
