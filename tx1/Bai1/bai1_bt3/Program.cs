using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_bt3
{
    //Viết CT nhập vào tháng và năm in ra màn hình số ngày của tháng và năm đo
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;

            do
            {
                Console.Write("Nhap thang: ");
                thang = int.Parse(Console.ReadLine());
                if (thang > 12 || thang < 1)
                {
                    Console.WriteLine("Thang khong hop le moi nhap lai");
                }


            } while (thang > 12 || thang < 1);
           
           
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());

            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.WriteLine();
                Console.WriteLine("*******************");
                Console.WriteLine("Thang {0} co 30 ngay", thang);
                if (nam % 4 == 0)
                {
                    Console.WriteLine("Nam {0} co 366 ngay", nam);
                }
                else
                {
                    Console.WriteLine("Nam {0} co 365 ngay", nam);
                }
            }
            else if(thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine();
                Console.WriteLine("*******************");
                Console.WriteLine("Thang {0} co 31 ngay", thang);
                if (nam % 4 == 0)
                {
                    Console.WriteLine("Nam {0} co 366 ngay", nam);
                }
                else
                {
                    Console.WriteLine("Nam {0} co 365 ngay", nam);
                }
            }
            else if(nam % 4 == 0 && thang == 2)
            {
                Console.WriteLine();
                Console.WriteLine("*******************");
                Console.WriteLine("Thang 2 co 29 ngay");
                Console.WriteLine("Nam {0} co 366 ngay", nam);
            }
            else
            {
                Console.WriteLine("Thang 2 co 28 ngay");
                Console.WriteLine("Nam {0} co 365 ngay", nam);
            }

            Console.ReadLine();
           
            
        }
    }
}
