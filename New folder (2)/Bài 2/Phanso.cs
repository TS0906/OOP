using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Phanso
    {
        int tu;
        int mau;
        public Phanso()
        {
            tu = 0;
            mau = 1;
        }
        public Phanso(int a, int b)
        {
            tu = a;
            mau = b;
        }
        public Phanso(Phanso p)
        {
            this.tu = p.tu;
            this.mau = p.mau;
        }
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public static Phanso operator + (Phanso p1, Phanso p2)
        {
            Phanso kq = new Phanso();

            kq.tu = (p1.tu * p2.mau + p1.mau * p2.tu);
            kq.mau = p1.mau * p1.mau; int a = UCLN(kq.tu, kq.mau);
            kq.tu= kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public static Phanso operator - (Phanso p1, Phanso p2)
        {
            Phanso kq = new Phanso();

            kq.tu = (p1.tu * p2.mau - p1.mau * p2.tu);
            kq.mau = p1.mau * p1.mau; int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public static Phanso operator * (Phanso p1, Phanso p2)
        {
            Phanso kq = new Phanso();

            kq.tu = (p1.tu * p2.tu);
            kq.mau = p1.mau * p2.mau; int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public static Phanso operator / (Phanso p1, Phanso p2)
        {
            Phanso kq = new Phanso();

            kq.tu = (p1.tu * p2.mau );
            kq.mau = p1.mau * p2.tu; int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;

        }
        public static bool operator >=(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau >= p2.tu * p1.mau)
                return true;
            else
                return false;
        }
        public static bool operator <=(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau <= p2.tu * p1.mau)
                return true;
            else
                return false;
        }
        public static bool operator >(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau > p2.tu * p1.mau)
                return true;
            else
                return false;
        }
        public static bool operator <(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau < p2.tu * p1.mau)
                return true;
            else
                return false;
        }

        public static bool operator ==(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau == p2.tu * p1.mau)
                return true;
            else
                return false;
        }
        public static bool operator !=(Phanso p1, Phanso p2)
        {
            if (p1.tu * p2.mau != p2.tu * p1.mau)
                return true;
            else
                return false;
        }
        public string show()
        {
            string t;
            t = Convert.ToString(tu) + "/"  +Convert.ToString(mau);
            return t;
        }
    }
        
}
