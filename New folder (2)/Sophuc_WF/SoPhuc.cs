using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophuc_WF
{
    class Sophuc
    {
        int thuc;
        int ao;
        
        public Sophuc()
        {
            thuc = 0; ao = 0;
        }

        public Sophuc(int a, int b)
        {
            thuc = a; ao = b;
        }
        public Sophuc(Sophuc z)
        {
            this.thuc = z.thuc;
            this.ao = z.ao;
        }
        public Sophuc Cong(Sophuc z)
        {
            Sophuc kq = new Sophuc();
            kq.thuc = this.thuc + z.thuc;
            kq.ao = this.ao + z.ao;
            return kq;
        }
        public Sophuc Cong(Sophuc z1, Sophuc z2)
        {
            Sophuc kq = new Sophuc();
            kq.thuc = this.thuc + z1.thuc + z2.thuc;
            kq.ao = this.ao + z1.ao + z2.ao;

            return kq;
        }
        public Sophuc Cong(int a)
        {
            Sophuc kq = new Sophuc();
            kq.thuc = this.thuc + a;
            kq.ao = this.ao;
            return kq;
        }
        public Sophuc Tru(Sophuc z)
        {
            Sophuc kq = new Sophuc();
            kq.thuc = this.thuc - z.thuc;
            kq.ao = this.ao - z.ao;
            return kq;
        }
        public Sophuc Tru(int a)
        {
            Sophuc kq = new Sophuc();
            kq.thuc = this.thuc - a;
            kq.ao = this.ao;
            return kq;
        }
        public string show()
        {
            string s;
            if (thuc > 0)
                s = Convert.ToString(thuc) + " + " + Convert.ToString(ao) + " *  i";
            else
                s = Convert.ToString(thuc) + " - " + Convert.ToString(Math.Abs(ao)) + " *  i ";
            return s;
        }
    }
}
