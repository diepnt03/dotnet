using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_bt1
{
    //giải phương trình bậc 2: AX2+BX+C=0 (a,b,c là các hệ số nhập từ bàn phím)
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap so a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c= ");
            c = int.Parse(Console.ReadLine());

            float denta = b * b - 4 * a * c;
            float x1, x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Nghiem cua phuong trinh x={0}", x1);
                }

            }

            else if (denta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x1=x2={0}", x1);
            }
            else if (denta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(denta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(denta)) / (2 * a));
                Console.WriteLine("Phuong trinh co nghiem x1={0} va x2={1} ", x1, x2);

            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

            Console.ReadLine();
        }
    }
}
