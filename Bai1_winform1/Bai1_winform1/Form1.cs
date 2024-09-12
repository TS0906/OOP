using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btthucthi_Click(object sender, EventArgs e)
        {
            Diem d = new Diem();
            float a = float.Parse(txthoanhdo.Text);
            float b = float.Parse(txttungdo.Text);
            float c = float.Parse(txtcaodo.Text);
            d.Nhap(a, b, c);
            txtToado.Text = d.In();
        }
    }
}
