using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaTran
{
    private int[,] matrix;
    private int sh;
    private int sc;

    public MaTran(int sh, int sc)
    {
        this.sh = sh;
        this.sc = sc;
        matrix = new int[sh, sc]; 
    }

    public void nhap()
    {
        Console.WriteLine($"Nhập ma trận {sh} x {sc}:");
        for (int i = 0; i < sh; i++)
        {
            for (int j = 0; j < sc; j++)
            {
                Console.Write($"Nhập phần tử [{i + 1},{j + 1}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public void hien()
    {
        Console.WriteLine("Ma tran la:");
        for (int i = 0; i < sh; i++)
        {
            for (int j = 0; j < sc; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }


    public MaTran Cong(MaTran mt2)
    {
        if (this.sh != mt2.sh || this.sc != mt2.sc)
        {
            Console.WriteLine("Hai ma tran phai co cung kich thuoc đe cong.");
            return null;
        }

        MaTran result = new MaTran(this.sh, this.sc);
        for (int i = 0; i < this.sh; i++)
        {
            for (int j = 0; j < this.sc; j++)
            {
                result.matrix[i, j] = this.matrix[i, j] + mt2.matrix[i, j];
            }
        }
        return result;
    }

    public MaTran Tru(MaTran mt2)
    {
        if (this.sh != mt2.sh || this.sc != mt2.sc)
        {
            Console.WriteLine("Hai ma tran phai co cung kich thuoc đe tru.");
            return null;
        }

        MaTran result = new MaTran(this.sh, this.sc);
        for (int i = 0; i < this.sh; i++)
        {
            for (int j = 0; j < this.sc; j++)
            {
                result.matrix[i, j] = this.matrix[i, j] - mt2.matrix[i, j];
            }
        }
        return result;
    }

  
    public void DoiDau()
    {
        for (int i = 0; i < sh; i++)
        {
            for (int j = 0; j < sc; j++)
            {
                matrix[i, j] = -matrix[i, j];
            }
        }
    }
}

class Tester
{
    static void Main()
    {
      
        Console.Write("Nhap so hang cho ma tran 1: ");
        int sh1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so cot cho ma tran 1: ");
        int sc1 = Convert.ToInt32(Console.ReadLine());
        MaTran mt1 = new MaTran(sh1, sc1);
        mt1.nhap();


        Console.Write("Nhap so hang cho ma tran 2:");
        int sh2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so cot cho ma tran 2: ");
        int sc2 = Convert.ToInt32(Console.ReadLine());
        MaTran mt2 = new MaTran(sh2, sc2);
        mt2.nhap();


        Console.WriteLine("Ma tran 1:");
        mt1.hien();
        Console.WriteLine("Ma tran 2:");
        mt2.hien();


        MaTran mtTong = mt1.Cong(mt2);
        if (mtTong != null)
        {
            Console.WriteLine("Tong hai ma tran:");
            mtTong.hien();
        }

 
        MaTran mtHieu = mt1.Tru(mt2);
        if (mtHieu != null)
        {
            Console.WriteLine("Hieu hai ma tran:");
            mtHieu.hien();
        }


        mt1.DoiDau();
        Console.WriteLine("Ma tran 1 sau khi đoi dau:");
        mt1.hien();

        Console.ReadKey();
    }
}