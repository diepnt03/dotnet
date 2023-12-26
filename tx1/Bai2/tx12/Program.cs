using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class Program
    {
        static void Main(string[] args)
        {
            int otp = 0;

            List<svcn> dssv = new List<svcn>();
            qlsv sv1 = new qlsv();

            do
            {
                Console.WriteLine("-------MENU--------");
                Console.WriteLine("1.Nhap 1 danh sach doi tuong");
                Console.WriteLine("2.Xuat danh sach doi tuong");
                Console.WriteLine("3.Tim sinh vien theo ma");
                Console.WriteLine("4.Xoa sinh vien theo ma(khong tim thay thi thong bao)");
                Console.WriteLine("5.Thoat");
                Console.WriteLine("----------------------");

                Console.Write("Nhap lua chon cua ban: ");
                otp = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (otp)
                {
                    case 1:
                        Console.WriteLine();
                        sv1.nhapds(dssv);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("------------------DANH SACH VUA NHAP--------------------");
                        Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}", "Ma sv", "Ho ten", "Chuyen nganh","Mon hoc");
                        sv1.xuatds(dssv);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(); 
                        Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}", "Ma sv", "Ho ten", "Chuyen nganh", "Mon hoc");
                        sv1.timsv(dssv);
                        break;
                    case 4:
                        Console.WriteLine();
                        
                        Console.WriteLine("------------------DANH SACH VUA XOA--------------------");
                        Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}", "Ma sv", "Ho ten", "Chuyen nganh", "Mon hoc");
                        sv1.xoasv(dssv);
                        sv1.xuatds(dssv);
                        break;
                    case 5:

                        break;
                }
            } while (otp<5);
        }
    }
}
