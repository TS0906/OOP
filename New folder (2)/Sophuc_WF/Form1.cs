using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sophuc_WF
{
    public partial class Form1 : Form
    {
        Sophuc s1, s2, s3;
        int songuyen;
        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = new Sophuc();
            s2 = new Sophuc(2, 3);
            s3 = new Sophuc(-2, -3);
            txtSP1.Text = s1.show();
            txtSP2.Text = s2.show();
            txtSP3.Text = s3.show();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void BtNhap_Click(object sender, EventArgs e)
        {
            int a = txtThuc.Text == "" ? 0 : int.Parse(txtThuc.Text);
            int b = txtAo.Text == "" ? 0 : int.Parse(txtAo.Text);
            if (rdSP1.Checked == true)
            {
                s1 = new Sophuc(a, b);
                txtSP1.Text = s1.show();
            }
            else if (rdSP2.Checked == true)
            {
                s2 = new Sophuc(a, b);
                txtSP2.Text = s2.show();
            }
            else if (rdSP3.Checked == true)
            {
                s3 = new Sophuc(a, b);
                txtSP3.Text = s3.show();
            }
        }
        private void BtNhapSN_Click(object sender, EventArgs e)
        {
            if (rdSonguyen.Checked == true)
            {
                songuyen = txtSonguyen.Text == "" ? 0 : int.Parse(txtSonguyen.Text);
                txtSN.Text = songuyen.ToString();
            }
        }
        private void BtCong2_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Cong(s2);
            txtKQ.Text = kq.show();
        }
        private void BtCong3_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Cong(s2, s3);
            txtKQ.Text = kq.show();
        }
        private void BtTru_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Tru(s2);
            txtKQ.Text= kq.show();
        }
        private void BtConga_Click(object sender, EventArgs e)
        {
            Sophuc kq1 = new Sophuc();
            Sophuc kq2 = new Sophuc();
            Sophuc kq3 = new Sophuc();
            kq1 = s1.Cong(songuyen);
            kq2 = s2.Cong(songuyen);
            kq3 = s3.Cong(songuyen);
            txtKQ1.Text= kq1.show();
            txtKQ2.Text = kq2.show();
            txtKQ3.Text = kq3.show();
        }
        private void BtTrua_Click(object sender, EventArgs e)
        {
            Sophuc kq1 = new Sophuc();
            Sophuc kq2 = new Sophuc();
            Sophuc kq3 = new Sophuc();
            kq1 = s1.Tru(songuyen);
            kq2 = s2.Tru(songuyen);
            kq3 = s3.Tru(songuyen);
            txtKQ1.Text = kq1.show();
            txtKQ2.Text = kq2.show();
            txtKQ3.Text = kq3.show();
        }
    }
}
