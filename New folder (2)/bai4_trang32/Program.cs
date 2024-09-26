using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_trang32
{
    class Diem
    {
        private double x, y; 
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Diem(Diem d)
        {
            this.x = d.x;
            this.y = d.y;
        }
        public void tinhTien(int dx)
        {
            this.x += dx;
        }
        public void tinhTien(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
        public double khoangCach()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double khoangCach(Diem d1)
        {
            return Math.Sqrt(Math.Pow(this.x - d1.x, 2) + Math.Pow(this.y - d1.y, 2));
        }
        public void hienThi()
        {
            Console.WriteLine($"Điểm có tọa độ: {x} , {y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập tọa độ điểm thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Diem d1 = new Diem(a, b);
            Console.WriteLine("Nhập tọa độ điểm thứ hai: ");
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            Diem d2 = new Diem(c, d); 

            d1.hienThi(); 
            d2.hienThi(); 

            Console.WriteLine($"Khoảng cách từ d1 đến gốc tọa độ: {d1.khoangCach()}");

            Console.WriteLine($"Khoảng cách giữa d1 và d2: {d1.khoangCach(d2)}");
        }
    }


}
