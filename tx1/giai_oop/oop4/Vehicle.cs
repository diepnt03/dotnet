using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Vehicle
    {
        private string hangSanXuat;
        private string mauSac;

        public string HangSanXuat
        {
            get { return hangSanXuat; }
            set { hangSanXuat = value; }
        }
        public string MauSac
        {
            get { return mauSac; }
            set { mauSac = value; }
        }

        public Vehicle()
        {
        }

        public Vehicle( string hangSanXuat, string mauSac) 
        {
            this.hangSanXuat = hangSanXuat;
            this.mauSac = mauSac;
        }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write($"Nhập hãng sản xuất: ");
            hangSanXuat = Console.ReadLine();
            Console.Write($"Nhập màu sắc    : ");
            mauSac = Console.ReadLine();
        }
    }
}