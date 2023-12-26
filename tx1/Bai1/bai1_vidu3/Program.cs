using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_vidu3
{
    //vd3:Viết CT nhập vào các số từ(2-8) in ra màn hình các thứ tương ứng.
    class Program
    {
        static void Main(string[] args)
        {
            int thu;
            
            do
            {
                Console.Write("Nhap so tuong ung: ");
                thu = int.Parse(Console.ReadLine());
                if (thu > 8 || thu < 2)
                {
                    Console.WriteLine("So khong hop le moi nhap lai");
                }


            } while (thu > 8 || thu < 2);

            switch (thu)
            {
                case 2:
                    Console.Write("     Thu hai");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write ("     Thu ba");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Write ("     Thu tu");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Write("      Thu nam");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Write("      Thu sau");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.Write("      Thu bay");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.Write("      Chu nhat");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Khong phai la thu trong tuan");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
