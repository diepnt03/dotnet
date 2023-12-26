using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMau
{
    internal class Person
    {
        private string hoTen;
        private string diaChi;

        public string HoTen
        {
            get { return hoTen; }
        }

        public string DiaChi
        {
            get { return diaChi; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();
        }


    }
}
