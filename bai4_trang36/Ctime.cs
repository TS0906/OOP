using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace bai4_trang36
{
    public class CTime
    {
        private int gio;
        private int phut;
        private int giay;

        public CTime()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }
        public CTime(int a, int b, int c)
        {
            this.gio = a;
            this.phut = b;
            this.giay = c;
            ChuanHoaThoiGian();
        }

        private void ChuanHoaThoiGian()
        {
            if (giay >= 60)
            {
                phut += giay / 60;
                giay %= 60;
            }
            if (phut >= 60)
            {
                gio += phut / 60;
                phut %= 60;
            }
            if (giay < 0)
            {
                giay += 60;
                phut--;
            }
            if (phut < 0)
            {
                phut += 60;
                gio--;
            }
        }

        public void NhapThoiGian(int a, int b, int c)
        {
            this.gio = a;
            this.phut = b;
            this.giay = c;
            ChuanHoaThoiGian();
        }

        public string XuatThoiGian()
        {
            return $"{gio:D2}:{phut:D2}:{giay:D2}"; //D2 dung de them so 0 vao truoc nhung chu so co 1 chu so
        }

        public static CTime operator +(CTime time, int giayThem)
        {
            CTime kq = new CTime(time.gio, time.phut, time.giay + giayThem);
            kq.ChuanHoaThoiGian();
            return kq;
        }

  
        public static CTime operator -(CTime time, int giayBot)
        {
            CTime kq = new CTime(time.gio, time.phut, time.giay - giayBot);
            kq.ChuanHoaThoiGian();
            return kq;
        }

        public static CTime operator ++(CTime time)
        {
            CTime kq = new CTime(time.gio, time.phut, time.giay + 1);
            kq.ChuanHoaThoiGian();
            return kq;
        }

        public static CTime operator --(CTime time)
        {
            CTime kq = new CTime(time.gio, time.phut, time.giay - 1);
            kq.ChuanHoaThoiGian();
            return kq;
        }
    }
}
