using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class MaTran
    {
        private int soHang;
        private int soCot;
        private int[,] a;
        public MaTran(int sh, int sc)
        {
            soHang = sh;
            soCot = sc;
            a = new int[soHang, soCot]; 
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap cac phan tu cho ma tran:");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Ma tran:");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public MaTran Cong(MaTran mt2)
        {
            if (this.soHang != mt2.soHang || this.soCot != mt2.soCot)
            {
                Console.WriteLine("Khong the cong hai ma tran co kich thuoc khac nhau.");
                return null; //trả về kết quả không hợp lệ nếu cong = null
            }

            MaTran result = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    result.a[i, j] = this.a[i, j] + mt2.a[i, j];
                }
            }

            return result;
        }

        public MaTran Hieu(MaTran mt2)
        {
            if (this.soHang != mt2.soHang || this.soCot != mt2.soCot)
            {
                Console.WriteLine("Khong the tru hai ma tran co kich thuoc khac nhau.");
                return null;
            }

            MaTran result = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    result.a[i, j] = this.a[i, j] - mt2.a[i, j];
                }
            }

            return result;
        }
        public MaTran DoiDau()
        {
            MaTran result = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    result.a[i, j] = -this.a[i, j];
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Nhập độ dài và rộng của ma trận 1: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            MaTran mt1 = new MaTran(a, b);
            Console.WriteLine("Nhap ma tran thu nhat:");
            mt1.Nhap();
            Console.WriteLine("Nhập độ dài và rộng của ma trận 2: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            MaTran mt2 = new MaTran(c, d);
            Console.WriteLine("Nhap ma tran thu hai:");
            mt2.Nhap();

            Console.WriteLine("Ma tran thu nhat:");
            mt1.Print();
            Console.WriteLine("Ma tran thu hai:");
            mt2.Print();

            MaTran mtCong = mt1.Cong(mt2);
            if (mtCong != null)
            {
                Console.WriteLine("Ma tran ket qua cua phep cong:");
                mtCong.Print();
            }

            MaTran mtHieu = mt1.Hieu(mt2);
            if (mtHieu != null)
            {
                Console.WriteLine("Ma tran ket qua cua phep tru:");
                mtHieu.Print();
            }

            MaTran mtDoiDau = mt1.DoiDau();
            Console.WriteLine("Ma tran thu nhat sau khi doi dau:");
            mtDoiDau.Print();
        }
    }
}