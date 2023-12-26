using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx11
{
   

    class Program
    {
        static void Main(string[] args)
        {
            int otp = 0;
            int n=0;
            
            List<nhanvien> dsnv = new List<nhanvien>();
            nhanvien nv2 = new nhanvien();

            do
            {
                Console.WriteLine("---------MENU----------");
                Console.WriteLine();
                Console.WriteLine("1.Them");
                Console.WriteLine("2.Hien thi danh sach");
                Console.WriteLine("3.Sap xep");
                Console.WriteLine("4.Xoa nhan vien co hsl max");
                Console.WriteLine("5.Hien thi nhan vien co hsl max");
                Console.WriteLine("6.Chen nhan vien moi");
                Console.WriteLine("7.Thoat");
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.Write("Nhap lua chon cua ban: ");
                otp = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (otp)
                {
                    case 1:
                        
                        nv2.nhapds(dsnv,ref n);
                        break;
                    case 2:
                        Console.WriteLine("****************************DANH SACH NHAN VIEN*******************************");
                        Console.WriteLine();
                        nv2.xuatds(dsnv);
                        Console.WriteLine();
                        break;
                    case 3:
                        nv2.sapx(dsnv);
                        Console.WriteLine("****************************DANH SACH NHAN VIEN SAU KHI SAP XEP*******************************");
                        Console.WriteLine();
                        nv2.xuatds(dsnv);
                        Console.WriteLine();
                        break;
                    
                    case 4:
                        nv2.xoa(dsnv);
                        Console.WriteLine("****************************DANH SACH NHAN VIEN SAU KHI XOA*******************************");
                        Console.WriteLine();
                        nv2.xuatds(dsnv);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("MAX la= " + nv2.maxhsl(dsnv));
                        Console.WriteLine("****************************DANH SACH NHAN VIEN CO HSL MAX*******************************");
                        Console.WriteLine();
                        Console.WriteLine("{0,-20}{1,-20}{2,-10}{3,-10}{4,-15}{5,-15}", "Ho ten", "Dia chi", "Hsl", "Luong", "Ma nhan vien", "Chuc vu");
                        nv2.hienthimax(dsnv);
                        Console.WriteLine();

                        break;
                    case 6:
                        nv2.themnv(dsnv);
                        Console.WriteLine("****************************DANH SACH NHAN VIEN SAU KHI ADD*******************************");
                        Console.WriteLine();
                        nv2.xuatds(dsnv);
                        Console.WriteLine();
                        break;


                }

            } while (otp < 7);

            Console.ReadLine();
        }
    }
}
