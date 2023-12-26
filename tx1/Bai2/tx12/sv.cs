using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class sv
    {
        public int masv { get; set; }
        private string hoten { get; set; }
        private int cn { get; set; }

        public sv()
        {
            masv = 0;
            hoten = "";
            cn = 0;
        }

        public sv(int masv1, string ht1, int cn1)
        {
            masv = masv1;
            hoten = ht1;
            cn = cn1;

        }

        public string ktra1()
        {
            string cnh2 = " ";
            switch (cn)
            {
                case 1:
                    cnh2 = "CNTT";
                    break;
                case 2:
                    cnh2 = "HTTT";
                    break;
            }

            return cnh2;
        }
        public virtual void nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            masv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten sinh vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap chuyen nganh sinh vien(1 or 2) : ");
            cn = int.Parse(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.Write("{0,-10}{1,-20}{2,-15}",masv, hoten,ktra1());

        }

    }
}
