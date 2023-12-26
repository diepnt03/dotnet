using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_bt2
{
    /*
     Viết chương trình tính thuế thu nhập khi nhập vào lương và thưởng.
        (thu nhập=lương+thưởng)
        ❑Thuế thu nhập được tính như sau:
         Dưới 9 triệu: không đóng thuế
         Từ 9 đến 15 triệu: thuế 10%
         Từ 15 đến 30 triệu: 15%
         Trên 30 triệu: 20%v
     */
    class Program
    {
        static void Main(string[] args)
        {
            float luong, thuong;
            Console.Write("Nhap luong: ");
            luong = float.Parse(Console.ReadLine());
            Console.Write("Nhap thuong: ");
            thuong = float.Parse(Console.ReadLine());

            float thunhap = (float)(luong + thuong);
            float thue;

            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Thu nhap la:{0}tr ", thunhap);


            if(thunhap < 9)
            {
                Console.WriteLine("Khong phai dong thue");
            }

            else if (thunhap <= 15 && thunhap > 9)
            {
                thue = (float)(thunhap * 0.1);
                Console.WriteLine("Phai dong thue la :{0}tr", thue);

            }

            else if(thunhap <=30 && thunhap > 15)
            {
                thue = (float)(thunhap*0.15);
                Console.WriteLine("Phai dong thue la :{0}tr", thue);
            }

            else
            {
                thue = (float)(thunhap * 0.2);
                Console.WriteLine("Phai dong thue la :{0}tr", thue);
            }

            Console.ReadLine();
        }
    }
}
