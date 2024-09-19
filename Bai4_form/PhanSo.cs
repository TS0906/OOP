using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_form
{
    public class PhanSo
    {
        int Tu, Mau;

        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }
        public PhanSo(PhanSo p)
        {
            this.Tu = p.Tu;
            this.Mau = p.Mau;
        }
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }

        public string show()
        {
            string t;
            t = Convert.ToString(Tu) + "/" + Convert.ToString(Mau);
            return t;
        }

        public PhanSo Cong(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau + this.Mau * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Tru(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau - this.Mau * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Nhan(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Chia(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau);
            kq.Mau = ps1.Tu * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }
        private int UCLN(int a, int b)
        {
            int r;
            do
            {
                r = a % b;
                if (r == 0) return b;
                else
                {
                    a = b;
                    b = r;
                }

            } while (r != 0);
            return 1;
        }
    }
}
