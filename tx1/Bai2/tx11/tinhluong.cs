using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx11
{
    class tinhluong
    {
        private string hoten { get; set; }

        private string dc { get; set; }

        public int hsl { get; set; }

        private static int lcb = 1000000;

        public tinhluong()
        {
            hoten = " ";
            hoten = " ";
            hsl = 0;
        }

        public tinhluong(string hoten1, string dc1, int hsl1)
        {
            hoten = hoten1;
            dc = dc1;
            hsl = hsl1;

        }

        public double tienl()
        {
            double luong;
            luong = hsl * lcb;
            return luong;
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi nhan vien: ");
            dc = Console.ReadLine();
            Console.Write("Nhap he so luong cua nhan vien: ");
            hsl = int.Parse(Console.ReadLine());

        }

        public virtual void xuat()
        {
            Console.Write("{0,-20}{1,-20}{2,-10}{3,-10}", hoten, dc, hsl, tienl());
        }


    }
}
