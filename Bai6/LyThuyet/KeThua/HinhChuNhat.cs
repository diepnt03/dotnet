using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class HinhChuNhat
    {


        protected int height { get; set; }
        protected int width { get; set; }

        public HinhChuNhat()
        {

        }
        public HinhChuNhat(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int Area()
        {
            return height * width;
        }

        public int Perimater()
        {
            return (height + width) * 2;
        }
        //từ khóa virtual để nói rằng phương thức này phải đưuọc ghi đè trong lớp dẫn xuất
        public virtual void Input()
        {
            Console.Write("Nhap height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Nhap width: ");
            width = int.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Width: " + width);
        }

    }
}
