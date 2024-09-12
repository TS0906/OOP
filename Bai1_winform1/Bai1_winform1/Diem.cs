using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_winform1
{
    internal class Diem
    {
        float hd, td, cd;
        public void Nhap(float a, float b, float c)
        {
            hd = a;
            td = b;
            cd = c;
        }
        public string In()

        {
            return "(" +hd.ToString() + " , " +td.ToString() + " , " +cd.ToString() + ")" ;
        }
    }
}