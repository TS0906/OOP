using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Diem
    {   
        float x, y, z;
        public void InPutPosition()
        {
            Console.WriteLine("Nhap hoanh do: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do: ");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cao do: ");
            z = float.Parse(Console.ReadLine());
        }
        public void OutPutPosition()
        {
            Console.WriteLine("("+x+","+y + "," + z + ")");
        }
    }
    public class Run
    {
        static public void Main()
        {
            Diem diem = new Diem();
            Console.WriteLine("Hay nhap hoanh do, tung do, cao do cho diem d: ");
            diem.InPutPosition();
            Console.WriteLine("Diem ban vua nhap co toa do la: ");
            diem.OutPutPosition();
        }
    }
}
