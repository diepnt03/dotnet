using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_vidu2
{
    class Program
    {
        /*
         vd2: Viết chương trình xếp loại theo điểm trung bình(dtb). In kết quả xếp loại ra màn hình.
        
         + xếp loại “Yếu” nếu dtb<5.
         + xếp loại “Trung bình” nếu 5<=dtb<7.
         + xếp loại “Khá” nếu 7<=dtb<8.
         + xếp loại “Giỏi” nếu dtb>=8.
         */
        static void Main(string[] args)
        {
            float dtb;
            string xl = "";
        
            do
            {
                Console.Write("Nhap diem trung binh: ");
                dtb = float.Parse(Console.ReadLine());
                if (dtb > 10 || dtb < 0)
                {
                    Console.WriteLine("Diem khong hop le moi nhap lai");
                }
                

            } while (dtb > 10 || dtb < 0);
            

            if(dtb<5)
            {
                xl = "Yeu";
            }
            else if(dtb<7)
            {
                xl = "Trung binh";
            }
            else if (dtb < 8)
            {
                xl = "Kha";
            }
            else
            {
                xl = "Gioi";
            }

            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine("Diem: {0}    Xep loai: {1}", dtb, xl);
            Console.ReadLine();
        }
    }
}
