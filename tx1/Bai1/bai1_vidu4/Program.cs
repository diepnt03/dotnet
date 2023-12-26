using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_vidu4
{
    //Nhập x(0<x<=100). Tìm số nguyên lớn nhất trong khoảng từ 1 đến 100 chia hết cho x
    class Program
    {
        static void Main(string[] args)
        {

            int x;
           
            do
            {
                Console.Write("Nhap x: ");
                x = int.Parse(Console.ReadLine());
                if (x > 100 || x <= 0)
                {
                    Console.WriteLine("x khong hop le moi nhap lai");
                }


            } while (x > 100 || x <= 0);

            for(int i=100; i>0; i--)
            {
                if(i%x == 0)
                {
                    Console.WriteLine("So nguyen lon nhat trong khoang tu 1 đen 100 chia het cho x la: {0} ", i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
