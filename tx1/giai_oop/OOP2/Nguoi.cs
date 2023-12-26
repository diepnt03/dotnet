using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Nguoi
    {
        private string hoTen;
        private string diaChi;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public Nguoi()
        {
        }

        public Nguoi(string hoTen, string diaChi)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
    }
}