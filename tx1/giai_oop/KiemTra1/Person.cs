using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra1
{
    internal class Person
    {
        private string hoTen;
        private string dienThoai;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập Họ Tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập Điện Thoại: ");
            dienThoai = Console.ReadLine();
        }
    }
}
