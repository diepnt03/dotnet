using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_vidu1
{
    class Program
    {
        // vd1: nhập vào: mã số(int), họ tên(string), lương(double). In ra màn hình 
        static void Main(string[] args)
        {

            {
                Console.Write("Nhap vao ma so: ");
                int maso;
                maso = int.Parse(Console.ReadLine());

                Console.Write("Nhap vao ho ten: ");
                string hoten;
                hoten = Console.ReadLine();


                Console.Write("Nhap luong: ");
                double luong;
                luong = double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------");
                Console.WriteLine("Ma so: {0}", maso);
                Console.WriteLine("Ho ten: {0}", hoten);
                Console.WriteLine("Luong: {0}", luong);
                Console.ReadLine();


            }
        }
    }
}