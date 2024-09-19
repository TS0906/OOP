using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class PhanSo
    {
        int ts, ms;
        public PhanSo()
        {
            ts = 0;
            ms = 1;
        }
        public void RutGon()
        {
            int ucln = UCLN(ts, ms);
            ts /= ucln;
            ms /= ucln;
        }
        public PhanSo(int tu, int mau)
        {
            ts = tu;
            ms = (mau == 0) ? 1 : mau;
            RutGon();
        }
        public PhanSo(PhanSo ps)
        {
            ts = ps.ts;
            ms = ps.ms;
        }
        private int UCLN(int a, int b)
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

        public PhanSo Cong(PhanSo ps)
        {
            int tu = this.ts * ps.ms + ps.ts * this.ms;
            int mau = this.ms * ps.ms;
            return new PhanSo(tu, mau);
        }
        public PhanSo Tru(PhanSo ps)
        {
            int tu = this.ts * ps.ms - ps.ts * this.ms;
            int mau = this.ms * ps.ms;
            return new PhanSo(tu, mau);
        }
        public PhanSo Nhan(PhanSo ps)
        {
            int tu = this.ts * ps.ts;
            int mau = this.ms * ps.ms;
            return new PhanSo(tu, mau);
        }
        public PhanSo Chia(PhanSo ps)
        {
            int tu = this.ts * ps.ms;
            int mau = this.ms * ps.ts;
            return new PhanSo(tu, mau);
        }
        public void InPs()
        {
            Console.WriteLine($"{ts}/{ms}");
        }
        // Override phương thức ToString để in đối tượng PhanSo
        public override string ToString()
        {
            return $"{ts}/{ms}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Nhap tu so phan so dau tien:  ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so phan so dau tien: ");
                int b = int.Parse(Console.ReadLine());
                PhanSo ps1 = new PhanSo(a, b);
                Console.WriteLine("Nhap tu so phan so thu hai:  ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so phan so thu hai: ");
                int d = int.Parse(Console.ReadLine());
                PhanSo ps2 = new PhanSo(c, d);
                PhanSo tong = ps1.Cong(ps2);
                PhanSo tru = ps1.Tru(ps2);
                PhanSo tich = ps1.Nhan(ps2);
                PhanSo thuong = ps1.Chia(ps2);
                Console.WriteLine("Tong: " + tong);
                Console.WriteLine("Hieu: " + tru);
                Console.WriteLine("Tich: " + tich);
                Console.WriteLine("Thuong: " + thuong);
            }
        }
    }
}