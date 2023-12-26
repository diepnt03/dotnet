using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_bt4
{
    /*
     Viết chương trình nhập vào số nguyên dương n (0<n<=100). In ra màn hình kết quả của tổng sau:
        S= 1+2+3+ …+n (sử dụng 3 vòng lặp: while, do…while và for)
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tong = 0;

            do
            {
                Console.Write("Nhap n= ");
                n = int.Parse(Console.ReadLine());
                if (n > 100 || n <= 0)
                {
                    Console.WriteLine("n khong hop le moi nhap lai");
                }


            } while (n > 100 || n <= 0);

            
            for(int i=1; i<=n; i++)
            {
                tong = tong + i; 
            }

            Console.WriteLine("Tong cua day so S={0}", tong);
            Console.ReadLine();
            

            /*
            int i = 1;
            do
            {
                //int i = 1;
                tong = tong + i;
                i++;
            } while (i <= n);
            Console.WriteLine("Tong cua day so S={0}", tong);
            Console.ReadLine();
            */

            /*
            int i = 1;
            while (i <= n)
            {
                tong = tong + i;
                i++;
            }
            Console.WriteLine("Tong cua day so S={0}", tong);
            Console.ReadLine();
            */
        }
    }
}
